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
            this.panel3 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ToolPanel = new System.Windows.Forms.Panel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.utilBtnPanel = new System.Windows.Forms.Panel();
            this.btnCloseIcon = new FontAwesome.Sharp.IconButton();
            this.btnMaxIcon = new FontAwesome.Sharp.IconButton();
            this.btnMinIcon = new FontAwesome.Sharp.IconButton();
            this.HeaderPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.utilBtnPanel.SuspendLayout();
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
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.ContentPanel);
            this.panel3.Controls.Add(this.ToolPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(254, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 634);
            this.panel3.TabIndex = 2;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "Main";
            this.Text = "Noter";
            this.HeaderPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.utilBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ToolPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel utilBtnPanel;
        private FontAwesome.Sharp.IconButton btnCloseIcon;
        private FontAwesome.Sharp.IconButton btnMaxIcon;
        private FontAwesome.Sharp.IconButton btnMinIcon;
    }
}

