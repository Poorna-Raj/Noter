using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noter
{
    public partial class FileView : UserControl
    {
        public string FilePath { get; private set; }
        public FileView(string filePath)
        {
            InitializeComponent();
            this.FilePath = filePath;
            lblFileName.Text = Path.GetFileName(filePath);

            this.Click += FileView_Click;
            foreach (Control ctl in this.Controls)
            {
                ctl.Click += FileView_Click;
            }
        }

        private void FileView_Click(object sender, EventArgs e)
        {
            onSelectedFile?.Invoke(this, FilePath);
        }

        public event EventHandler<string> onSelectedFile;
    }
}
