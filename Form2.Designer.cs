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
            this.btnconvert_F2 = new System.Windows.Forms.Button();
            this.RTB1_F2 = new System.Windows.Forms.RichTextBox();
            this.LB1_F2 = new System.Windows.Forms.Label();
            this.LBL2_F2 = new System.Windows.Forms.Label();
            this.LBL1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // T1_F2
            // 
            this.T1_F2.Location = new System.Drawing.Point(47, 97);
            this.T1_F2.Name = "T1_F2";
            this.T1_F2.Size = new System.Drawing.Size(296, 20);
            this.T1_F2.TabIndex = 0;
            // 
            // btnconvert_F2
            // 
            this.btnconvert_F2.Location = new System.Drawing.Point(163, 139);
            this.btnconvert_F2.Name = "btnconvert_F2";
            this.btnconvert_F2.Size = new System.Drawing.Size(75, 23);
            this.btnconvert_F2.TabIndex = 1;
            this.btnconvert_F2.Text = "Convert";
            this.btnconvert_F2.UseVisualStyleBackColor = true;
            this.btnconvert_F2.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // RTB1_F2
            // 
            this.RTB1_F2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB1_F2.Location = new System.Drawing.Point(47, 196);
            this.RTB1_F2.Name = "RTB1_F2";
            this.RTB1_F2.Size = new System.Drawing.Size(296, 45);
            this.RTB1_F2.TabIndex = 2;
            this.RTB1_F2.Text = "";
            // 
            // LB1_F2
            // 
            this.LB1_F2.AutoSize = true;
            this.LB1_F2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB1_F2.Location = new System.Drawing.Point(44, 81);
            this.LB1_F2.Name = "LB1_F2";
            this.LB1_F2.Size = new System.Drawing.Size(215, 13);
            this.LB1_F2.TabIndex = 3;
            this.LB1_F2.Text = "Type the Expression below without space";
            // 
            // LBL2_F2
            // 
            this.LBL2_F2.AutoSize = true;
            this.LBL2_F2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL2_F2.Location = new System.Drawing.Point(44, 180);
            this.LBL2_F2.Name = "LBL2_F2";
            this.LBL2_F2.Size = new System.Drawing.Size(90, 13);
            this.LBL2_F2.TabIndex = 4;
            this.LBL2_F2.Text = "Infix Expression:";
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.BackColor = System.Drawing.Color.Transparent;
            this.LBL1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LBL1.Location = new System.Drawing.Point(127, 33);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(132, 25);
            this.LBL1.TabIndex = 5;
            this.LBL1.Text = "Prefix -> Infix";
            // 
            // PrefixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(388, 287);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.LBL2_F2);
            this.Controls.Add(this.LB1_F2);
            this.Controls.Add(this.RTB1_F2);
            this.Controls.Add(this.btnconvert_F2);
            this.Controls.Add(this.T1_F2);
            this.Name = "PrefixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prefix To Infix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T1_F2;
        private System.Windows.Forms.Button btnconvert_F2;
        private System.Windows.Forms.RichTextBox RTB1_F2;
        private System.Windows.Forms.Label LB1_F2;
        private System.Windows.Forms.Label LBL2_F2;
        private System.Windows.Forms.Label LBL1;
    }
}