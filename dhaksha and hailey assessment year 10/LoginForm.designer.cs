namespace dhaksha_and_hailey_assessment_year_10
{
    partial class LoginForm
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
            this.btncreateaccount = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.chbxShowpassword = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblgetstarted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncreateaccount
            // 
            this.btncreateaccount.BackColor = System.Drawing.Color.White;
            this.btncreateaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncreateaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreateaccount.ForeColor = System.Drawing.Color.LightPink;
            this.btncreateaccount.Location = new System.Drawing.Point(46, 739);
            this.btncreateaccount.Name = "btncreateaccount";
            this.btncreateaccount.Size = new System.Drawing.Size(519, 72);
            this.btncreateaccount.TabIndex = 19;
            this.btncreateaccount.Text = "CREATE ACCOUNT";
            this.btncreateaccount.UseVisualStyleBackColor = false;
            this.btncreateaccount.Click += new System.EventHandler(this.btncreateaccount_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LightPink;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(46, 649);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(519, 72);
            this.btnlogin.TabIndex = 18;
            this.btnlogin.Text = "LOG IN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // chbxShowpassword
            // 
            this.chbxShowpassword.AutoSize = true;
            this.chbxShowpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbxShowpassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbxShowpassword.Location = new System.Drawing.Point(322, 572);
            this.chbxShowpassword.Name = "chbxShowpassword";
            this.chbxShowpassword.Size = new System.Drawing.Size(243, 41);
            this.chbxShowpassword.TabIndex = 17;
            this.chbxShowpassword.Text = "Show Password";
            this.chbxShowpassword.UseVisualStyleBackColor = true;
            this.chbxShowpassword.CheckedChanged += new System.EventHandler(this.chbxShowpassword_CheckedChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(46, 451);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(519, 63);
            this.txtpassword.TabIndex = 14;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(39, 400);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(139, 37);
            this.lblpassword.TabIndex = 13;
            this.lblpassword.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("MS UI Gothic", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(46, 304);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(519, 63);
            this.txtusername.TabIndex = 12;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(39, 253);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(146, 37);
            this.lblusername.TabIndex = 11;
            this.lblusername.Text = "Username";
            // 
            // lblgetstarted
            // 
            this.lblgetstarted.AutoSize = true;
            this.lblgetstarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgetstarted.ForeColor = System.Drawing.Color.LightPink;
            this.lblgetstarted.Location = new System.Drawing.Point(35, 158);
            this.lblgetstarted.Name = "lblgetstarted";
            this.lblgetstarted.Size = new System.Drawing.Size(307, 61);
            this.lblgetstarted.TabIndex = 10;
            this.lblgetstarted.Text = "Get Started";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 968);
            this.Controls.Add(this.btncreateaccount);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.chbxShowpassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblgetstarted);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreateaccount;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox chbxShowpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblgetstarted;
    }
}