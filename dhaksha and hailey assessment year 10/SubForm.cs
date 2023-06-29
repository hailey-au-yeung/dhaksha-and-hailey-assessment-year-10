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
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        int buttonFunc = 0;

        int answer;

        int count = 0;

        System.Media.SoundPlayer pop = new System.Media.SoundPlayer(Properties.Resources.popSound);
        System.Media.SoundPlayer cheer = new System.Media.SoundPlayer(Properties.Resources.cheeringSound);

        List<PictureBox> mushrooms = new List<PictureBox>() 
        {
            new mushroom(1), //1
            new mushroom(2), //2
            new mushroom(3), //3
            new mushroom(4), //4
            new mushroom(5), //5
            new mushroom(6), //6
            new mushroom(7), //7
            new mushroom(8), //8
        };

        private void SubForm_Load(object sender, EventArgs e) //setup screen
        {
            foreach (PictureBox mush in mushrooms)
            {
                Controls.Add(mush);
                mush.Visible = false;
                mush.Image = Properties.Resources.mushroom;
            }
            subnumber1.Visible = false;
            subnumber2.Visible = false;
            sublabel2.Visible = false;
            sublabel4.Visible = false;
            subtextBox1.Visible = false;
            subbutton1.Visible = true;
            sublabel1.Text = "";
        }

        private void subbutton1_Click(object sender, EventArgs e) 
        {
            if (buttonFunc == 0) //start game
            {
                subnumber1.Visible = true;
                subnumber2.Visible = true;
                sublabel2.Visible = true;
                sublabel4.Visible = true;
                sublabel3.Visible = false;
                subtextBox1.Visible = true;
                foreach (PictureBox mush in mushrooms)
                {
                    mush.Visible = true;
                }
                makeQuestion();
                subbutton1.Text = "Check";
                buttonFunc = 1;

            }

            else if (buttonFunc == 1) //press to check answer and setup next question
            {
                checkAnswer();
            }

        }

        private void subtextBox1_KeyDown(object sender, KeyEventArgs e) //enter to check answer and setup next question
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkAnswer();
                e.SuppressKeyPress = true;
            }
        }
        public void checkAnswer() //check answer and setup next question
        {
            if (subtextBox1.Text == Convert.ToString(answer))
            {
                mushroomChange();
                sublabel1.Text = "Correct!";
                subtextBox1.Text = "";
                    

                makeQuestion();
            }
            else
            {
                sublabel1.Text = "Incorrect, Try Again";
            }
        }
        public void makeQuestion() 
        {
            subnumber1.Text = Convert.ToString(rnd.Next(0, 8));
            subnumber2.Text = Convert.ToString(rnd.Next(0, 8));
            answer = Convert.ToInt32(subnumber1.Text) - Convert.ToInt32(subnumber2.Text);

        }

        public async Task mushroomChange() //change mushroom into gnome
        {
            mushrooms[count].Image = Properties.Resources.explosion;            
            pop.Play();
            await Task.Delay(250);
            mushrooms[count].Image = Properties.Resources.gnome;
            count = count + 1;
            //if game is finished
            if (count >= 8)
            {
                foreach (PictureBox mush in mushrooms)
                {
                    mush.Image = Properties.Resources.smilingGnome;
                    mush.Size=new Size(150,150);
                }
                subnumber1.Visible = false;
                subnumber2.Visible = false;
                sublabel2.Visible = false;
                sublabel4.Visible = false;
                sublabel1.Visible = false;
                subtextBox1.Visible = false;
                subbutton1.Visible = false;
                subbutton2.Visible = true;
                sublabel3.Visible = true;
                cheer.Play();
                sublabel3.Text = "Well done! You've finished :)";
            }
        }

        private void subbutton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
