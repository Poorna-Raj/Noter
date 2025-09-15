using Markdig;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Noter
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private string CurrentSelectedPath { get; set; } = string.Empty;
        private string CurrentFilePath { get; set; } = string.Empty;

        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = string.Empty;
            // hook MouseDown on header
            this.HeaderPanel.MouseDown += HeaderPanel_MouseDown;
            //load icons
            loadIcons();
            webView.Source = new Uri("about:blank");
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnCloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadIcons()
        {
            btnCloseIcon.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            btnMaxIcon.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMinIcon.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnOpenFolder.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            btnNewFile.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnSaveIcon.IconChar = FontAwesome.Sharp.IconChar.Save;
        }

        private void btnMaxIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnMinIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtMarkdown_TextChanged(object sender, EventArgs e)
        {
            string markdown = txtMarkdown.Text;
            string html = Markdown.ToHtml(markdown);

            string fullHtml = $@"
                <html>
                <head>
                <meta charset='utf-8'>
                <style>
                    body {{
                        background-color: black; /* dark gray */
                        color: #d4d4d4;            /* light gray text */
                        font-family: Segoe UI, sans-serif;
                        padding: 10px;
                    }}
                    pre, code {{
                        background: #2d2d2d; /* darker block for code */
                        color: #f8f8f2;      /* almost white text */
                        border-radius: 5px;
                        padding: 4px 6px;
                        font-family: Consolas, monospace;
                    }}
                    h1 {{ color: #569cd6; }} /* soft blue */
                    h2 {{ color: #4ec9b0; }} /* teal */
                    h3 {{ color: #c586c0; }} /* purple */
                    a  {{ color: #9cdcfe; }} /* link blue */
                    strong {{ color: #ffd700; }} /* highlight bold */
                </style>
                </head>
                <body>{html}</body>
                </html>";


            webView.NavigateToString(fullHtml);
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            folderBrowser.Description = "Select a folder to save or edit Markdown files";
            folderBrowser.ShowNewFolderButton = true;

            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                CurrentSelectedPath = folderBrowser.SelectedPath;

                updateFileItems();
            }
        }

        private void Item_OnFileSelected(object sender, string filePath)
        {
            this.txtMarkdown.Text = File.ReadAllText(filePath);
            this.CurrentFilePath = filePath;
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            if(this.CurrentSelectedPath == "")
            {
                MessageBox.Show("Path is empty");
                return;
            }

            string fileName = Interaction.InputBox("Enter new Markdown file name:",
                                           "New File",
                                           "Untitled.md");

            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }

            if (!fileName.EndsWith(".md", StringComparison.OrdinalIgnoreCase))
            {
                fileName += ".md";
            }

            string newFilePath = Path.Combine(CurrentSelectedPath, fileName);

            if (File.Exists(newFilePath))
            {
                MessageBox.Show("File already exists. Please choose another name.");
                return;
            }

            File.WriteAllText(newFilePath, "");

            updateFileItems();
        }

        private void updateFileItems()
        {
            this.filePanel.Controls.Clear();
            string[] mdFiles = Directory.GetFiles(CurrentSelectedPath, "*.md");

            if (mdFiles.Length <= 0)
            {
                MessageBox.Show("No md files");
                return;
            }

            foreach (var file in mdFiles)
            {
                var item = new FileView(file);
                item.onSelectedFile += Item_OnFileSelected;
                this.filePanel.Controls.Add(item);
            }
        }

        private void btnSaveIcon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
            {
                MessageBox.Show("Please open a file");
                return;
            }

            try
            {
                File.WriteAllText(CurrentFilePath, txtMarkdown.Text);
                MessageBox.Show("File Saved Successfully");
                updateFileItems();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
