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
            this.SuspendLayout();
            // 
            // LBL2_F3
            // 
            this.LBL2_F3.AutoSize = true;
            this.LBL2_F3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2_F3.Location = new System.Drawing.Point(43, 162);
            this.LBL2_F3.Name = "LBL2_F3";
            this.LBL2_F3.Size = new System.Drawing.Size(90, 13);
            this.LBL2_F3.TabIndex = 9;
            this.LBL2_F3.Text = "Infix Expression:";
            // 
            // LB1_F3
            // 
            this.LB1_F3.AutoSize = true;
            this.LB1_F3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB1_F3.Location = new System.Drawing.Point(43, 63);
            this.LB1_F3.Name = "LB1_F3";
            this.LB1_F3.Size = new System.Drawing.Size(215, 13);
            this.LB1_F3.TabIndex = 8;
            this.LB1_F3.Text = "Type the Expression below without space";
            // 
            // RTB1_F3
            // 
            this.RTB1_F3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB1_F3.Location = new System.Drawing.Point(46, 178);
            this.RTB1_F3.Name = "RTB1_F3";
            this.RTB1_F3.Size = new System.Drawing.Size(296, 45);
            this.RTB1_F3.TabIndex = 7;
            this.RTB1_F3.Text = "";
            // 
            // btnconvert_F3
            // 
            this.btnconvert_F3.Location = new System.Drawing.Point(162, 121);
            this.btnconvert_F3.Name = "btnconvert_F3";
            this.btnconvert_F3.Size = new System.Drawing.Size(75, 23);
            this.btnconvert_F3.TabIndex = 6;
            this.btnconvert_F3.Text = "Convert";
            this.btnconvert_F3.UseVisualStyleBackColor = true;
            this.btnconvert_F3.Click += new System.EventHandler(this.btnconvert_F3_Click);
            // 
            // T1_F3
            // 
            this.T1_F3.Location = new System.Drawing.Point(46, 79);
            this.T1_F3.Name = "T1_F3";
            this.T1_F3.Size = new System.Drawing.Size(296, 20);
            this.T1_F3.TabIndex = 5;
            // 
            // PostfixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(385, 286);
            this.Controls.Add(this.LBL2_F3);
            this.Controls.Add(this.LB1_F3);
            this.Controls.Add(this.RTB1_F3);
            this.Controls.Add(this.btnconvert_F3);
            this.Controls.Add(this.T1_F3);
            this.Name = "PostfixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postfix to Infix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL2_F3;
        private System.Windows.Forms.Label LB1_F3;
        private System.Windows.Forms.RichTextBox RTB1_F3;
        private System.Windows.Forms.Button btnconvert_F3;
        private System.Windows.Forms.TextBox T1_F3;
    }
}