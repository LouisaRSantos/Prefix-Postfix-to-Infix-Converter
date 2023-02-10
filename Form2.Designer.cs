namespace Prefix_and_Postfix_to_Infix_Converter
{
    partial class PrefixForm
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
            this.T1_F2 = new System.Windows.Forms.TextBox();
            this.btnconvert = new System.Windows.Forms.Button();
            this.RTB1_F2 = new System.Windows.Forms.RichTextBox();
            this.LB1_F2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // T1_F2
            // 
            this.T1_F2.Location = new System.Drawing.Point(46, 85);
            this.T1_F2.Name = "T1_F2";
            this.T1_F2.Size = new System.Drawing.Size(296, 20);
            this.T1_F2.TabIndex = 0;
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(162, 123);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(75, 23);
            this.btnconvert.TabIndex = 1;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // RTB1_F2
            // 
            this.RTB1_F2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB1_F2.Location = new System.Drawing.Point(46, 166);
            this.RTB1_F2.Name = "RTB1_F2";
            this.RTB1_F2.Size = new System.Drawing.Size(296, 45);
            this.RTB1_F2.TabIndex = 2;
            this.RTB1_F2.Text = "";
            // 
            // LB1_F2
            // 
            this.LB1_F2.AutoSize = true;
            this.LB1_F2.Location = new System.Drawing.Point(43, 59);
            this.LB1_F2.Name = "LB1_F2";
            this.LB1_F2.Size = new System.Drawing.Size(203, 13);
            this.LB1_F2.TabIndex = 3;
            this.LB1_F2.Text = "Type the Expression below without space";
            // 
            // PrefixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(388, 287);
            this.Controls.Add(this.LB1_F2);
            this.Controls.Add(this.RTB1_F2);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.T1_F2);
            this.Name = "PrefixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prefix To Infix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T1_F2;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.RichTextBox RTB1_F2;
        private System.Windows.Forms.Label LB1_F2;
    }
}