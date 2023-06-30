namespace dhaksha_and_hailey_assessment_year_10
{
    partial class MultForm
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
            this.lblscore = new System.Windows.Forms.Label();
            this.lblnumA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnumB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.checkbutton = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.restartbutton = new System.Windows.Forms.Button();
            this.lblhoverinst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblscore.ForeColor = System.Drawing.Color.Maroon;
            this.lblscore.Location = new System.Drawing.Point(35, 35);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(98, 29);
            this.lblscore.TabIndex = 0;
            this.lblscore.Text = "Score: 0";
            // 
            // lblnumA
            // 
            this.lblnumA.AutoSize = true;
            this.lblnumA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblnumA.Font = new System.Drawing.Font("Kristen ITC", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumA.Location = new System.Drawing.Point(101, 89);
            this.lblnumA.Name = "lblnumA";
            this.lblnumA.Size = new System.Drawing.Size(106, 80);
            this.lblnumA.TabIndex = 1;
            this.lblnumA.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // lblnumB
            // 
            this.lblnumB.AutoSize = true;
            this.lblnumB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblnumB.Font = new System.Drawing.Font("Kristen ITC", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumB.Location = new System.Drawing.Point(282, 89);
            this.lblnumB.Name = "lblnumB";
            this.lblnumB.Size = new System.Drawing.Size(106, 80);
            this.lblnumB.TabIndex = 3;
            this.lblnumB.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 80);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Kristen ITC", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(465, 88);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(123, 88);
            this.txtAnswer.TabIndex = 7;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // checkbutton
            // 
            this.checkbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkbutton.Font = new System.Drawing.Font("Kristen ITC", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbutton.Location = new System.Drawing.Point(623, 86);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(172, 84);
            this.checkbutton.TabIndex = 8;
            this.checkbutton.Text = "Check";
            this.checkbutton.UseVisualStyleBackColor = false;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblStatus.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(43, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 44);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Correct";
            // 
            // restartbutton
            // 
            this.restartbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.restartbutton.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartbutton.Location = new System.Drawing.Point(1001, 516);
            this.restartbutton.Name = "restartbutton";
            this.restartbutton.Size = new System.Drawing.Size(198, 92);
            this.restartbutton.TabIndex = 11;
            this.restartbutton.Text = "Restart";
            this.restartbutton.UseVisualStyleBackColor = false;
            this.restartbutton.Click += new System.EventHandler(this.restartbutton_Click);
            // 
            // lblhoverinst
            // 
            this.lblhoverinst.AutoSize = true;
            this.lblhoverinst.Font = new System.Drawing.Font("Kristen ITC", 14.25F);
            this.lblhoverinst.Location = new System.Drawing.Point(868, 86);
            this.lblhoverinst.Name = "lblhoverinst";
            this.lblhoverinst.Size = new System.Drawing.Size(459, 52);
            this.lblhoverinst.TabIndex = 12;
            this.lblhoverinst.Text = "Hover For Instructions!";
            this.lblhoverinst.MouseLeave += new System.EventHandler(this.lblhoverinst_MouseLeave);
            this.lblhoverinst.MouseHover += new System.EventHandler(this.lblhoverinst_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1239, 635);
            this.Controls.Add(this.lblhoverinst);
            this.Controls.Add(this.restartbutton);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnumB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnumA);
            this.Controls.Add(this.lblscore);
            this.Font = new System.Drawing.Font("Kristen ITC", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label lblnumA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnumB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button restartbutton;
        private System.Windows.Forms.Label lblhoverinst;
    }
}

