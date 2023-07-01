using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static dhaksha_and_hailey_assessment_year_10.AddForm;

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
            Controls.Clear(); // Clears the form controls

            Label wellDoneLabel = new Label();
            wellDoneLabel.Text = "Well done your final score is " + score;
            wellDoneLabel.AutoSize = true;
            wellDoneLabel.Location = new Point(200, 200);
            wellDoneLabel.Font = new System.Drawing.Font("Kristen ITC", 40, System.Drawing.FontStyle.Bold);

            Controls.Add(wellDoneLabel); ;
            Controls.Add (restartbutton); ; //prints a label to show end of game
            SoundPlayer cheering = new SoundPlayer(Properties.Resources.cheeringSound);
            cheering.Play();



        }

        private void restartbutton_Click(object sender, EventArgs e)
        {
            Application.Restart(); //restarts application to play game again
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

                score += 1;

                lblScore.Text = "Score: " + score; //adding to score


                if (locx > 350)
                {
                    y = 0;
                    StopGame(); //stopping car at finish line
                }
                else
                {
                    mybunny.Location = new Point(locx + y, 300); // moving car when answewr is correct
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
                StopGame();
            }
            else
            {
                Mybunny.Location = new Point(locx2 + x, 400); //moving second car always
                


            }


            locx2 = locx2 + x;

        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkanswer();

            }     //to make enter key work to submit answer
        }

        private void lblhoverinst_MouseHover(object sender, EventArgs e)
        {
            lblhoverinst.Text = "How To Play: Answer the question right to make your bunnt hops along a spot. " +
                "Your bunny is the one on the top! Beat the other bunny to the finish line in the race!";
            lblhoverinst.MaximumSize = new Size(300, 0);
            lblhoverinst.AutoSize = true;
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
            lblhoverbunnies.Text = "Hover Over the Bunnies!";
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
