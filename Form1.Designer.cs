namespace Prefix_and_Postfix_to_Infix_Converter
{
    partial class PrePostConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrePostConverter));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBL1 = new System.Windows.Forms.Label();
            this.LBL2 = new System.Windows.Forms.Label();
            this.BTN_pre = new System.Windows.Forms.Button();
            this.BTN_post = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.howToUseToolStripMenuItem.Text = "How to use?";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatorToolStripMenuItem,
            this.converterToolStripMenuItem});
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // creatorToolStripMenuItem
            // 
            this.creatorToolStripMenuItem.Name = "creatorToolStripMenuItem";
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.creatorToolStripMenuItem.Text = "Creator";
            this.creatorToolStripMenuItem.Click += new System.EventHandler(this.creatorToolStripMenuItem_Click);
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.converterToolStripMenuItem.Text = "Converter";
            this.converterToolStripMenuItem.Click += new System.EventHandler(this.converterToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.BackColor = System.Drawing.Color.Transparent;
            this.LBL1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBL1.Location = new System.Drawing.Point(81, 82);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(232, 25);
            this.LBL1.TabIndex = 1;
            this.LBL1.Text = "Prefix and Postfix -> Infix";
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.BackColor = System.Drawing.Color.Transparent;
            this.LBL2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2.Location = new System.Drawing.Point(71, 117);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(260, 15);
            this.LBL2.TabIndex = 2;
            this.LBL2.Text = "Welcome to prefix and postfix to infix conversion!";
            // 
            // BTN_pre
            // 
            this.BTN_pre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_pre.Location = new System.Drawing.Point(70, 182);
            this.BTN_pre.Name = "BTN_pre";
            this.BTN_pre.Size = new System.Drawing.Size(78, 33);
            this.BTN_pre.TabIndex = 3;
            this.BTN_pre.Text = "Prefix";
            this.BTN_pre.UseVisualStyleBackColor = false;
            this.BTN_pre.Click += new System.EventHandler(this.BTN_pre_Click);
            // 
            // BTN_post
            // 
            this.BTN_post.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_post.Location = new System.Drawing.Point(253, 182);
            this.BTN_post.Name = "BTN_post";
            this.BTN_post.Size = new System.Drawing.Size(78, 33);
            this.BTN_post.TabIndex = 4;
            this.BTN_post.Text = "Postfix";
            this.BTN_post.UseVisualStyleBackColor = false;
            this.BTN_post.Click += new System.EventHandler(this.BTN_post_Click);
            // 
            // PrePostConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(389, 288);
            this.Controls.Add(this.BTN_post);
            this.Controls.Add(this.BTN_pre);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrePostConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Infix Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.Button BTN_pre;
        private System.Windows.Forms.Button BTN_post;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

