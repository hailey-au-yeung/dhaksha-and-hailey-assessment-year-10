namespace dhaksha_and_hailey_assessment_year_10
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNumA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.restartbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblhoverbunnies = new System.Windows.Forms.Label();
            this.lblhoverinst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.ForeColor = System.Drawing.Color.Maroon;
            this.lblScore.Location = new System.Drawing.Point(35, 35);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(98, 29);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Font = new System.Drawing.Font("Kristen ITC", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumA.Location = new System.Drawing.Point(101, 89);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(106, 80);
            this.lblNumA.TabIndex = 1;
            this.lblNumA.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 80);
            this.label3.TabIndex = 2;
            this.label3.Text = "+";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Font = new System.Drawing.Font("Kristen ITC", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNumB.Location = new System.Drawing.Point(282, 89);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(106, 80);
            this.lblNumB.TabIndex = 3;
            this.lblNumB.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 80);
            this.label5.TabIndex = 4;
            this.label5.Text = "=";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(106, 206);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(146, 44);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Correct";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(459, 89);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(123, 74);
            this.txtAnswer.TabIndex = 6;
            this.txtAnswer.TextChanged += new System.EventHandler(this.CheckAnswer);
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Font = new System.Drawing.Font("Kristen ITC", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(623, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CheckButtonClickEvent);
            // 
            // restartbutton
            // 
            this.restartbutton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.restartbutton.Font = new System.Drawing.Font("Kristen ITC", 12F);
            this.restartbutton.Location = new System.Drawing.Point(933, 553);
            this.restartbutton.Name = "restartbutton";
            this.restartbutton.Size = new System.Drawing.Size(293, 93);
            this.restartbutton.TabIndex = 8;
            this.restartbutton.Text = "Home";
            this.restartbutton.UseVisualStyleBackColor = false;
            this.restartbutton.Click += new System.EventHandler(this.restartbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblhoverbunnies
            // 
            this.lblhoverbunnies.AutoSize = true;
            this.lblhoverbunnies.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoverbunnies.Location = new System.Drawing.Point(924, 260);
            this.lblhoverbunnies.Name = "lblhoverbunnies";
            this.lblhoverbunnies.Size = new System.Drawing.Size(481, 52);
            this.lblhoverbunnies.TabIndex = 11;
            this.lblhoverbunnies.Text = "Hover Over the Bunnies!";
            // 
            // lblhoverinst
            // 
            this.lblhoverinst.AutoSize = true;
            this.lblhoverinst.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoverinst.Location = new System.Drawing.Point(924, 35);
            this.lblhoverinst.Name = "lblhoverinst";
            this.lblhoverinst.Size = new System.Drawing.Size(457, 52);
            this.lblhoverinst.TabIndex = 10;
            this.lblhoverinst.Text = "Hover for Instructions!";
            this.lblhoverinst.MouseLeave += new System.EventHandler(this.lblhoverinst_MouseLeave);
            this.lblhoverinst.MouseHover += new System.EventHandler(this.lblhoverinst_MouseHover);
            // 
            // AddForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1249, 667);
            this.Controls.Add(this.lblhoverbunnies);
            this.Controls.Add(this.lblhoverinst);
            this.Controls.Add(this.restartbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumA);
            this.Controls.Add(this.lblScore);
            this.Font = new System.Drawing.Font("Kristen ITC", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maths Addition Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button restartbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblhoverbunnies;
        private System.Windows.Forms.Label lblhoverinst;
    }
}

