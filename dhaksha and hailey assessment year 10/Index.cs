using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dhaksha_and_hailey_assessment_year_10
{
    public partial class Index : Form
    {
        SubForm subForm = new SubForm();
        DivForm divForm = new DivForm();
        AddForm addForm = new AddForm();
        MultForm multForm = new MultForm();
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score.Text = "Score: " + Properties.Settings.Default.Score;
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            subForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            divForm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            addForm.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            multForm.Show(); //opens up the different forms when button is clicked
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       
    }

}
public static class MyGlobals
{
    public static int Score;

    
}


