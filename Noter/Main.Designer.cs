namespace Noter
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.utilBtnPanel = new System.Windows.Forms.Panel();
            this.btnCloseIcon = new FontAwesome.Sharp.IconButton();
            this.btnMaxIcon = new FontAwesome.Sharp.IconButton();
            this.btnMinIcon = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.txtMarkdown = new System.Windows.Forms.RichTextBox();
            this.HeaderPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.utilBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.HeaderPanel.Controls.Add(this.utilBtnPanel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1064, 47);
            this.HeaderPanel.TabIndex = 0;
            // 
            // centerPanel
            // 
            this.centerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.centerPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.centerPanel.Controls.Add(this.ContentPanel);
            this.centerPanel.Controls.Add(this.ToolPanel);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(254, 47);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(810, 634);
            this.centerPanel.TabIndex = 2;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 47);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(254, 634);
            this.SidePanel.TabIndex = 1;
            // 
            // ToolPanel
            // 
            this.ToolPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.Size = new System.Drawing.Size(810, 27);
            this.ToolPanel.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ContentPanel.Controls.Add(this.splitContainer1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 27);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(810, 607);
            this.ContentPanel.TabIndex = 1;
            // 
            // utilBtnPanel
            // 
            this.utilBtnPanel.Controls.Add(this.btnMinIcon);
            this.utilBtnPanel.Controls.Add(this.btnMaxIcon);
            this.utilBtnPanel.Controls.Add(this.btnCloseIcon);
            this.utilBtnPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.utilBtnPanel.Location = new System.Drawing.Point(961, 0);
            this.utilBtnPanel.Name = "utilBtnPanel";
            this.utilBtnPanel.Size = new System.Drawing.Size(103, 47);
            this.utilBtnPanel.TabIndex = 4;
            // 
            // btnCloseIcon
            // 
            this.btnCloseIcon.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnCloseIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseIcon.IconChar = FontAwesome.Sharp.IconChar._0;
            this.btnCloseIcon.IconColor = System.Drawing.Color.White;
            this.btnCloseIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseIcon.IconSize = 16;
            this.btnCloseIcon.Location = new System.Drawing.Point(68, 3);
            this.btnCloseIcon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCloseIcon.Name = "btnCloseIcon";
            this.btnCloseIcon.Size = new System.Drawing.Size(32, 41);
            this.btnCloseIcon.TabIndex = 0;
            this.btnCloseIcon.UseVisualStyleBackColor = false;
            this.btnCloseIcon.Click += new System.EventHandler(this.btnCloseIcon_Click);
            // 
            // btnMaxIcon
            // 
            this.btnMaxIcon.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnMaxIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaxIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaxIcon.IconColor = System.Drawing.Color.White;
            this.btnMaxIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxIcon.IconSize = 16;
            this.btnMaxIcon.Location = new System.Drawing.Point(38, 3);
            this.btnMaxIcon.Name = "btnMaxIcon";
            this.btnMaxIcon.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMaxIcon.Size = new System.Drawing.Size(32, 39);
            this.btnMaxIcon.TabIndex = 3;
            this.btnMaxIcon.UseVisualStyleBackColor = false;
            this.btnMaxIcon.Click += new System.EventHandler(this.btnMaxIcon_Click);
            // 
            // btnMinIcon
            // 
            this.btnMinIcon.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnMinIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMinIcon.IconColor = System.Drawing.Color.White;
            this.btnMinIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinIcon.IconSize = 16;
            this.btnMinIcon.Location = new System.Drawing.Point(3, 4);
            this.btnMinIcon.Name = "btnMinIcon";
            this.btnMinIcon.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMinIcon.Size = new System.Drawing.Size(32, 39);
            this.btnMinIcon.TabIndex = 4;
            this.btnMinIcon.UseVisualStyleBackColor = false;
            this.btnMinIcon.Click += new System.EventHandler(this.btnMinIcon_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(810, 607);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.txtMarkdown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 607);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.webView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 607);
            this.panel2.TabIndex = 0;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView.Location = new System.Drawing.Point(0, 0);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(536, 607);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // txtMarkdown
            // 
            this.txtMarkdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarkdown.Location = new System.Drawing.Point(0, 0);
            this.txtMarkdown.Name = "txtMarkdown";
            this.txtMarkdown.Size = new System.Drawing.Size(270, 607);
            this.txtMarkdown.TabIndex = 0;
            this.txtMarkdown.Text = "";
            this.txtMarkdown.TextChanged += new System.EventHandler(this.txtMarkdown_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "Main";
            this.Text = "Noter";
            this.HeaderPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.utilBtnPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel utilBtnPanel;
        private FontAwesome.Sharp.IconButton btnCloseIcon;
        private FontAwesome.Sharp.IconButton btnMaxIcon;
        private FontAwesome.Sharp.IconButton btnMinIcon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private System.Windows.Forms.RichTextBox txtMarkdown;
    }
}

