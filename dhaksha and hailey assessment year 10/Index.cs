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
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            subForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            divForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addForm.Show();

        }
    }
}
