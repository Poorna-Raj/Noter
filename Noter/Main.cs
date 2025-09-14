using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                            font-family: Segoe UI, sans-serif;
                            padding: 20px;
                        }}
                        pre, code {{
                            background: #f4f4f4;
                            border-radius: 5px;
                            padding: 2px 5px;
                        }}
                        h1 {{ color: darkblue; }}
                        h2 {{ color: darkgreen; }}
                        h3 {{ color: darkred; }}
                    </style>
                </head>
                <body>{html}</body>
                </html>";

            webView.NavigateToString(fullHtml);
        }
    }
}
