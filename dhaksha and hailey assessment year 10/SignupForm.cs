using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace dhaksha_and_hailey_assessment_year_10
{
    public partial class formregister : Form
    {
        public formregister()
        {
            InitializeComponent();
           
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbusers.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();// linking the access database



        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" && txtpassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Sign up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtpassword.Text == txtconfirm.Text)
            {
                con.Open();
                string register = "INSERT INTO tbluser VALUES('" + txtusername.Text + "', '" + txtpassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your account has been successfully created", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.Text = "";
                txtpassword.Text = "";
                txtconfirm.Text = ""; 
            }
            else
            {
                MessageBox.Show("Your passwords do not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtconfirm.Text = "";
                txtpassword.Focus(); //passwords have to match
            }

        }

        private void chbxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowpassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtconfirm.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtconfirm.PasswordChar = '*'; //confidentiality of passwords
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();

        }
    }
}
