using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace dhaksha_and_hailey_assessment_year_10
{
    public partial class MultForm : Form
    {
        Random rnd = new Random();
        int total;
        int score;
        picture pic1;
        picture pic2;
        picture pic3;
        picture pic4;
        picture pic5;
        picture pic6;
        picture pic7;
        picture pic8;
        picture pic9; ////naming all of the global variables
        int decidingno = 0;
        int time = 0;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        Timer addtimer;
        int pointsadded = 0;
        public MultForm()
        {
            InitializeComponent();
            SetUpGame();
        }

      

      
        

        private void checkbutton_Click(object sender, EventArgs e)
        {
            checkanswer();          
        }

        private void PictureBoxInput()
        {
            
            switch (score)
            {
                
                case 1:
                    pic1 = new picture(1,decidingno);
                    Controls.Add(pic1);
                    pic1.Location = new Point(50, 200);
                    break;
                case 2:
                    pic6 = new picture(6, decidingno);
                    Controls.Add(pic6);
                    pic6.Location = new Point(290, 320);
                    break;
                case 3:
                    pic9 = new picture(9, decidingno);
                    Controls.Add(pic9);
                    pic9.Location = new Point(290, 440);
                    break;
                case 4:
                    pic5 = new picture(5, decidingno);
                    Controls.Add(pic5);
                    pic5.Location = new Point(170,320);
                    break;
                case 5:
                    pic2 = new picture(2, decidingno);
                    Controls.Add(pic2);
                    pic2.Location = new Point(170, 200);
                    break;
                case 6:
                    pic3 = new picture(3, decidingno);
                    Controls.Add(pic3);
                    pic3.Location = new Point(290, 200);
                    break;
                case 7:
                    pic7 = new picture(7, decidingno);
                    Controls.Add(pic7);
                    pic7.Location = new Point(50, 440);
                    break;
                case 8:
                    pic4 = new picture(4, decidingno);
                    Controls.Add(pic4);
                    pic4.Location = new Point(50, 320);
                    break;
                case 9:
                    pictureend();

                    break;


            }

        }
        public async Task pictureend() //change mushroom into gnome
        {
            pic8 = new picture(8, decidingno);
            Controls.Add(pic8);
            pic8.Location = new Point(170, 440);
            await Task.Delay(350);
            StopGame();
            
        }

        private void SetUpGame()
        {
            int NumA = rnd.Next(1, 5);
            int NumB = rnd.Next(1, 5);

            txtAnswer.Text = null;

            total = NumA * NumB;
            lblnumA.Text = NumA.ToString();
            lblnumB.Text = NumB.ToString(); //code for question




        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Only Numbers!");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);

            }

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

            Label wellDoneLabel = new Label();
            wellDoneLabel.Text = "Well done you finished the picture in " + time + " seconds and "+ pointsadded + " points!";
            wellDoneLabel.AutoSize = true;
            wellDoneLabel.Font = new System.Drawing.Font("Kristen ITC", 20, System.Drawing.FontStyle.Bold);
            wellDoneLabel.Location = new Point(50, 75);

          

            if (decidingno == 1)
            {
                PictureBox finalpicturebox = new PictureBox();
                finalpicturebox.Image = Properties.Resources.finalpic;
                finalpicturebox.Size = new Size(400, 400);
                finalpicturebox.SizeMode = PictureBoxSizeMode.Zoom;
                finalpicturebox.Location = new Point(250, 200);
                Controls.Add(finalpicturebox); ;
            }
            else
            {
                PictureBox birdfinalpicturebox = new PictureBox();
                birdfinalpicturebox.Image = Properties.Resources.birdfinalpic;
                birdfinalpicturebox.Size = new Size(400, 400);
                birdfinalpicturebox.SizeMode = PictureBoxSizeMode.Zoom;
                birdfinalpicturebox.Location = new Point(250, 200);
                Controls.Add(birdfinalpicturebox); ;

            }

            Controls.Add(wellDoneLabel); ;
            Controls.Add(restartbutton); ;  //printing a well done label to signify end of game
            SoundPlayer cheering = new SoundPlayer(Properties.Resources.cheeringSound);
            cheering.Play();



        }

        private void checkanswer()
        {
            int userEntered = Convert.ToInt32(txtAnswer.Text);

            if (userEntered == total)
            {
                lblStatus.Text = "Correct";
                lblStatus.ForeColor = Color.Green;

                score += 1;


                SetUpGame();
                PictureBoxInput();
                SoundPlayer right = new SoundPlayer(Properties.Resources.right_answer);
                right.Play();


            }

            else
            {
                lblStatus.Text = "Incorrect";
                lblStatus.ForeColor = Color.Red; // if answer is incorrect

            }

        }

        private void restartbutton_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        } 

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                checkanswer();
                e.SuppressKeyPress = true;
            }     //to make enter key work to submit answer
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decidingno = rnd.Next(1, 3); //randomly decides num
                                         //set up timer
            t.Interval = 1000;
            t.Enabled = true;
            t.Tick += timer_Tick;

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            time = time + 1;

            lblscore.Text = Convert.ToString(time) + " s";
        }
    

        private void lblhoverinst_MouseHover(object sender, EventArgs e)
        {
            lblhoverinst.Text = "How To Play: Get the answer right, a piece of the picture is revealed. Finish the picture!";
            lblhoverinst.MaximumSize = new Size(300, 0);
            lblhoverinst.AutoSize = true;

        }

        private void lblhoverinst_MouseLeave(object sender, EventArgs e)
        {
            lblhoverinst.Text = "Hover for Instructions"; //hovering feature
        }
    }
    }
    

