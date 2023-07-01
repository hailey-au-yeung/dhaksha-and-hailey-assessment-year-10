using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static dhaksha_and_hailey_assessment_year_10.AddForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace dhaksha_and_hailey_assessment_year_10
{
    public partial class AddForm : Form
    {

        Random rnd = new Random(); //naming all of the global variables
        int total;
        int score;
        Bunny mybunny;
        Bunny Mybunny;
        int locx = 1;
        int locx2 = 1;
        int pointsadded = 0;
        



        int time = 0;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        Timer addtimer;


        public AddForm()
        {
            InitializeComponent();
            SetUpGame();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mybunny = new Bunny(6);
            Controls.Add(mybunny);
            this.mybunny.MouseHover += new System.EventHandler(this.mybunny_MouseHover);
            this.mybunny.MouseLeave += new System.EventHandler(this.mybunny_MouseLeave);


            Mybunny = new Bunny(8);
            Controls.Add(Mybunny); // adding bunnies for game
            this.Mybunny.MouseHover += new System.EventHandler(this.Mybunny_MouseHover);
            this.Mybunny.MouseLeave += new System.EventHandler(this.Mybunny_MouseLeave);

            points.Visible = false;

            //set up timer
            t.Interval = 1000;
            t.Enabled = true;
            t.Tick += timer_Tick;

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            time = time + 1;

            timelabel.Text = Convert.ToString(time) + " s";
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers!");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1); // ensuring only numbers are inputed
            }
        }

        private void CheckButtonClickEvent(object sender, EventArgs e)
        {
            checkanswer();            
        }

        private void SetUpGame()
        {
            int NumA = rnd.Next(1, 10);
            int NumB = rnd.Next(1, 10);

            txtAnswer.Text = null;

            total = NumA + NumB;
            lblNumA.Text = NumA.ToString();
            lblNumB.Text = NumB.ToString(); //method for question
           
        }

        private void StopGame()
        {

            if (time > 0 && time < 11)
            {
                MyGlobals.Score = MyGlobals.Score + 10;
                Properties.Settings.Default.Score = MyGlobals.Score.ToString();
                Properties.Settings.Default.Save();
                pointsadded = 10;
            }
            else if (time > 10 && time < 16)
            {
                MyGlobals.Score = MyGlobals.Score + 7;
                Properties.Settings.Default.Score = MyGlobals.Score.ToString();
                Properties.Settings.Default.Save();
                pointsadded = 7;
            }
            else if (time > 15 && time < 21)
            {
                MyGlobals.Score = MyGlobals.Score + 5;
                Properties.Settings.Default.Score = MyGlobals.Score.ToString();
                Properties.Settings.Default.Save();
                pointsadded = 5;
            }
            else if (time > 20 && time < 26)
            {
                MyGlobals.Score = MyGlobals.Score + 3;
                Properties.Settings.Default.Score = MyGlobals.Score.ToString();
                Properties.Settings.Default.Save();
                pointsadded = 3; ;
            }
            else if (time > 25 && time < 31)
            {
                MyGlobals.Score = MyGlobals.Score + 2;
                Properties.Settings.Default.Score = MyGlobals.Score.ToString();
                Properties.Settings.Default.Save();
                pointsadded = 2;
            }
            else
            {
                MyGlobals.Score = MyGlobals.Score + 1;
                Properties.Settings.Default.Score = MyGlobals.Score.ToString();
                Properties.Settings.Default.Save();
                pointsadded = 1;
            }

            Controls.Clear(); // Clears the form controls

            System.Windows.Forms.Label wellDoneLabel = new System.Windows.Forms.Label();
            wellDoneLabel.Text = "Well done you finished with a time of " + time + " seconds and " + pointsadded + " points";
            wellDoneLabel.AutoSize = true;
            wellDoneLabel.Location = new Point(50, 200);
            wellDoneLabel.Font = new System.Drawing.Font("Kristen ITC", 25, System.Drawing.FontStyle.Bold);

            Controls.Add(wellDoneLabel); ;
            Controls.Add (restartbutton); ; //prints a label to show end of game
            SoundPlayer cheering = new SoundPlayer(Properties.Resources.cheeringSound);
            cheering.Play();
            timelabel.Visible = false;
            points.Visible = true;
           


        }

        private void restartbutton_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }
        
        private void checkanswer()
        {
            int userEntered = Convert.ToInt32(txtAnswer.Text);
            int y = 40;
            int x = rnd.Next(35, 40);


            if (userEntered == total)
            {
                lblStatus.Text = "Correct";
                lblStatus.ForeColor = Color.Green; //checking  user's answer

              

                if (locx > 350)
                {
                    y = 0;
                    StopGame(); //stopping car at finish line
                }
                else
                {
                    mybunny.Location = new Point(locx + y, 300); // moving bunny when answewr is correct
                    SoundPlayer hop = new SoundPlayer(Properties.Resources.BunnyHop);
                    hop.Play();

                }

                locx = locx + y;




                SetUpGame();


            }

            else if (userEntered == null)
            {
                lblStatus.Text = "Incorrect";
                lblStatus.ForeColor = Color.Red;
            }

            else
            {
                lblStatus.Text = "Incorrect";
                lblStatus.ForeColor = Color.Red;

            }
            if (locx2 > 350)
            {
                x = 0;
                
            }
            else
            {
                Mybunny.Location = new Point(locx2 + x, 400); //moving second bunny always
                


            }


            locx2 = locx2 + x;

        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkanswer();
                e.SuppressKeyPress = true;

            }     //to make enter key work to submit answer
        }

        private void lblhoverinst_MouseHover(object sender, EventArgs e)
        {
            lblhoverinst.Text = "How To Play: Answer the question right to make your bunny hops along a spot. " +
                "Your bunny is the one on the top! Beat the other bunny to the finish line in the race!";
            lblhoverinst.MaximumSize = new Size(300, 0);
            lblhoverinst.AutoSize = true; //wraps textr
        }

        private void lblhoverinst_MouseLeave(object sender, EventArgs e)
        {
            lblhoverinst.Text = "Hover for Instructions";
            
        }

        private void mybunny_MouseHover (object sender, EventArgs e)
        {
            lblhoverbunnies.Text = " Hi! I am your Bunny!. Our aim is to beat the other bunny in the race. Get a question right, the further we hop!!";
            lblhoverbunnies.MaximumSize = new Size(300, 0);
            lblhoverbunnies.AutoSize = true;
        }
        private void mybunny_MouseLeave(object sender, EventArgs e)
        {
            lblhoverbunnies.Text = "Hover Over the Bunnies!"; //hovering effectr
        }
        private void Mybunny_MouseHover(object sender, EventArgs e)
        {
            lblhoverbunnies.Text = " Hi! My name is Nibbles!!. Are you ready to race?";
            lblhoverbunnies.MaximumSize = new Size(300, 0);
            lblhoverbunnies.AutoSize = true;
        }
        private void Mybunny_MouseLeave(object sender, EventArgs e)
        {
            lblhoverbunnies.Text = "Hover Over the Bunnies!";
        }

              
    }
}
