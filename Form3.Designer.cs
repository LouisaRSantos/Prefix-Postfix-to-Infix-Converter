namespace Prefix_and_Postfix_to_Infix_Converter
{
    partial class PostfixForm
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
            this.LBL2_F3 = new System.Windows.Forms.Label();
            this.LB1_F3 = new System.Windows.Forms.Label();
            this.RTB1_F3 = new System.Windows.Forms.RichTextBox();
            this.btnconvert_F3 = new System.Windows.Forms.Button();
            this.T1_F3 = new System.Windows.Forms.TextBox();
            this.LBL1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL2_F3
            // 
            this.LBL2_F3.AutoSize = true;
            this.LBL2_F3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2_F3.Location = new System.Drawing.Point(44, 194);
            this.LBL2_F3.Name = "LBL2_F3";
            this.LBL2_F3.Size = new System.Drawing.Size(90, 13);
            this.LBL2_F3.TabIndex = 9;
            this.LBL2_F3.Text = "Infix Expression:";
            // 
            // LB1_F3
            // 
            this.LB1_F3.AutoSize = true;
            this.LB1_F3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB1_F3.Location = new System.Drawing.Point(47, 95);
            this.LB1_F3.Name = "LB1_F3";
            this.LB1_F3.Size = new System.Drawing.Size(215, 13);
            this.LB1_F3.TabIndex = 8;
            this.LB1_F3.Text = "Type the Expression below without space";
            // 
            // RTB1_F3
            // 
            this.RTB1_F3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB1_F3.Location = new System.Drawing.Point(47, 210);
            this.RTB1_F3.Name = "RTB1_F3";
            this.RTB1_F3.Size = new System.Drawing.Size(296, 45);
            this.RTB1_F3.TabIndex = 7;
            this.RTB1_F3.Text = "";
            // 
            // btnconvert_F3
            // 
            this.btnconvert_F3.Location = new System.Drawing.Point(166, 153);
            this.btnconvert_F3.Name = "btnconvert_F3";
            this.btnconvert_F3.Size = new System.Drawing.Size(75, 23);
            this.btnconvert_F3.TabIndex = 6;
            this.btnconvert_F3.Text = "Convert";
            this.btnconvert_F3.UseVisualStyleBackColor = true;
            this.btnconvert_F3.Click += new System.EventHandler(this.btnconvert_F3_Click);
            // 
            // T1_F3
            // 
            this.T1_F3.Location = new System.Drawing.Point(50, 111);
            this.T1_F3.Name = "T1_F3";
            this.T1_F3.Size = new System.Drawing.Size(296, 20);
            this.T1_F3.TabIndex = 5;
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.BackColor = System.Drawing.Color.Transparent;
            this.LBL1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBL1.Location = new System.Drawing.Point(127, 51);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(140, 25);
            this.LBL1.TabIndex = 10;
            this.LBL1.Text = "Postfix -> Infix";
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
            this.menuStrip1.Size = new System.Drawing.Size(387, 24);
            this.menuStrip1.TabIndex = 11;
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
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.creatorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.creatorToolStripMenuItem.Text = "Creator";
            this.creatorToolStripMenuItem.Click += new System.EventHandler(this.creatorToolStripMenuItem_Click);
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // PostfixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(387, 286);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.LBL2_F3);
            this.Controls.Add(this.LB1_F3);
            this.Controls.Add(this.RTB1_F3);
            this.Controls.Add(this.btnconvert_F3);
            this.Controls.Add(this.T1_F3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PostfixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postfix to Infix";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL2_F3;
        private System.Windows.Forms.Label LB1_F3;
        private System.Windows.Forms.RichTextBox RTB1_F3;
        private System.Windows.Forms.Button btnconvert_F3;
        private System.Windows.Forms.TextBox T1_F3;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}