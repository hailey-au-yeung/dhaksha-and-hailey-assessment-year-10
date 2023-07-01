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
    public partial class LoginForm : Form
    {
        Index index = new Index();
        public LoginForm()
        {
            InitializeComponent();
        }
           
        
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbusers.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter(); // linking the access database
        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbluser WHERE username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader(); //adding userrname and password to the data base

            if (dr.Read() == true)
            {
                index.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Text = "";
                txtpassword.Text = "";
                txtusername.Focus(); //checking if username and password are right
                con.Close();


            }
        }

        private void chbxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowpassword.Checked)
            {
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '*'; //confidentiality of passwords

            }
        }

        private void btncreateaccount_Click(object sender, EventArgs e)
        {
            new formregister().Show();
            this.Hide();
        }
    }
}
