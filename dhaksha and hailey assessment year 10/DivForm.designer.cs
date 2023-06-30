namespace dhaksha_and_hailey_assessment_year_10
{
    partial class DivForm
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
            this.divbutton1 = new System.Windows.Forms.Button();
            this.divlabel2 = new System.Windows.Forms.Label();
            this.divlabel3 = new System.Windows.Forms.Label();
            this.divlabel4 = new System.Windows.Forms.Label();
            this.divlabel5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // divbutton1
            // 
            this.divbutton1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.divbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divbutton1.Font = new System.Drawing.Font("Kristen ITC", 10F);
            this.divbutton1.Location = new System.Drawing.Point(1015, 468);
            this.divbutton1.Name = "divbutton1";
            this.divbutton1.Size = new System.Drawing.Size(222, 67);
            this.divbutton1.TabIndex = 0;
            this.divbutton1.Text = "start";
            this.divbutton1.UseVisualStyleBackColor = false;
            this.divbutton1.Click += new System.EventHandler(this.divbutton1_Click);
            // 
            // divlabel2
            // 
            this.divlabel2.AutoSize = true;
            this.divlabel2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.divlabel2.Font = new System.Drawing.Font("Kristen ITC", 16F);
            this.divlabel2.Location = new System.Drawing.Point(562, 26);
            this.divlabel2.Name = "divlabel2";
            this.divlabel2.Size = new System.Drawing.Size(213, 58);
            this.divlabel2.TabIndex = 3;
            this.divlabel2.Text = "Show _/8";
            // 
            // divlabel3
            // 
            this.divlabel3.AutoSize = true;
            this.divlabel3.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold);
            this.divlabel3.ForeColor = System.Drawing.Color.Black;
            this.divlabel3.Location = new System.Drawing.Point(1040, 398);
            this.divlabel3.Name = "divlabel3";
            this.divlabel3.Size = new System.Drawing.Size(0, 44);
            this.divlabel3.TabIndex = 4;
            // 
            // divlabel4
            // 
            this.divlabel4.AutoSize = true;
            this.divlabel4.Font = new System.Drawing.Font("Kristen ITC", 16F);
            this.divlabel4.ForeColor = System.Drawing.Color.Black;
            this.divlabel4.Location = new System.Drawing.Point(403, 246);
            this.divlabel4.Name = "divlabel4";
            this.divlabel4.Size = new System.Drawing.Size(38, 58);
            this.divlabel4.TabIndex = 5;
            this.divlabel4.Text = " ";
            // 
            // divlabel5
            // 
            this.divlabel5.AutoSize = true;
            this.divlabel5.Font = new System.Drawing.Font("Kristen ITC", 10.875F);
            this.divlabel5.ForeColor = System.Drawing.Color.Black;
            this.divlabel5.Location = new System.Drawing.Point(36, 26);
            this.divlabel5.Name = "divlabel5";
            this.divlabel5.Size = new System.Drawing.Size(26, 40);
            this.divlabel5.TabIndex = 6;
            this.divlabel5.Text = " ";
            // 
            // DivForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1289, 573);
            this.Controls.Add(this.divlabel5);
            this.Controls.Add(this.divlabel4);
            this.Controls.Add(this.divlabel3);
            this.Controls.Add(this.divlabel2);
            this.Controls.Add(this.divbutton1);
            this.Name = "DivForm";
            this.Text = "DivForm";
            this.Load += new System.EventHandler(this.DivForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button divbutton1;
        private System.Windows.Forms.Label divlabel2;
        private System.Windows.Forms.Label divlabel3;
        private System.Windows.Forms.Label divlabel4;
        private System.Windows.Forms.Label divlabel5;
    }
}

