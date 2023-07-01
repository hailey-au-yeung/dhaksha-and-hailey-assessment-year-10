using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dhaksha_and_hailey_assessment_year_10
{
    public partial class DivForm : Form
    {
        public DivForm()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        public int func = 0;

        public int questionNo = 1;

        public int score = 0;

        public int num;

        List<PictureBox> boxes = new List<PictureBox>()
        {
            new NumberBoxes(1),
            new NumberBoxes(2),
            new NumberBoxes(3),
            new NumberBoxes(4),
            new NumberBoxes(5),
            new NumberBoxes(6),
            new NumberBoxes(7),
            new NumberBoxes(8),
        };

        public List<Label> questionLabels = new List<Label>()
        {
            new questionNos(1),
            new questionNos(2),
            new questionNos(3),
            new questionNos(4),
            new questionNos(5),
            new questionNos(6),
            new questionNos(7),
            new questionNos(8),
            new questionNos(9),
            new questionNos(10),
        };

        private void divbutton1_Click(object sender, EventArgs e)
        {
            if (questionNo <= 10)
            {
                if (func==0)
                {
                    Index index = new Index();
                    index.Show();
                    this.Hide();

                }   
                else if (func == 1) //make new question and reset boxes to gray
                {
                    //reset boxes and labels
                    divlabel4.Text = "";
                    divlabel3.Text = "";
                    divlabel2.Visible = true;
                    foreach (PictureBox btn in boxes)
                    {
                        btn.Image= Properties.Resources.pinkFlower;
                        btn.AccessibleName = "pink";
                        btn.Visible = true;
                        btn.AccessibleDescription = Convert.ToString(rnd.Next(120, 480));
                        btn.Location = new Point(btn.Location.X, Convert.ToInt32(btn.AccessibleDescription));

                    }
                    foreach (Label lab in questionLabels)
                    {
                        lab.Visible = true;
                    }

                    //set up for new question
                    func = 2;
                    divbutton1.Text = "submit";
                    divlabel5.Text = "Question "+Convert.ToString(questionNo);

                    // make new question
                    num = rnd.Next(0, 8);
                    //show question
                    divlabel2.Text = "Show "+Convert.ToString(num) + "/8";
                }
                else if (func == 2) //checking answer
                {
                    int countbutton = 0;

                    //checking user's answer             
                    foreach (PictureBox btn in boxes)
                    {
                        if (btn.AccessibleName == "purple")
                        {
                            countbutton++;
                        }
                    }

                    string userAnswer = Convert.ToString(countbutton) + "/8";

                    // checking if user is correct
                    if ("Show "+userAnswer == divlabel2.Text)
                    {
                        divlabel3.Text = "correct!";
                        score = score + 1;
                    }
                    else
                    {
                        divlabel3.Text = "incorrect :(";                        
                    }
                    func = 1;
                    foreach(Label lab in questionLabels)
                    {
                        if (lab.Text == Convert.ToString(questionNo))
                        {
                            if (divlabel3.Text=="correct!")
                            {
                                lab.Text = lab.Text + " ✓";
                                lab.BackColor=Color.MediumPurple;
                            }
                            else
                            {
                                lab.Text = lab.Text + " ✘";
                            }
                        }
                    }
                    
                    if (questionNo == 10)
                    {
                        divbutton1.Text = "finish";
                    }
                    else
                    {
                        divbutton1.Text = "next question";
                    }    
                    questionNo = questionNo + 1;

                }
                
                
            }
            else
            {
                foreach (PictureBox btn in boxes)
                {
                    btn.Visible = false;
                }
                divlabel4.Text = "Congratulations! You have finished with a score of " + Convert.ToString(score) + "/10";
                func = 0;
                divbutton1.Text = "Home";
                questionNo = 1;
                divlabel3.Text = "";
                divlabel2.Visible = false;

                MyGlobals.Score = MyGlobals.Score + score;
                Properties.Settings.Default.Score = MyGlobals.Score.ToString();
                Properties.Settings.Default.Save();
            }
            
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            //adds all boxes
            Controls.Add(boxes[0]);
            Controls.Add(boxes[1]);
            Controls.Add(boxes[2]);
            Controls.Add(boxes[3]);
            Controls.Add(boxes[4]);
            Controls.Add(boxes[5]);
            Controls.Add(boxes[6]);
            Controls.Add(boxes[7]);
            foreach (PictureBox btn in boxes)
            {
                btn.Visible = false;
            }
            Controls.Add(questionLabels[0]);
            Controls.Add(questionLabels[1]);
            Controls.Add(questionLabels[2]);
            Controls.Add(questionLabels[3]);
            Controls.Add(questionLabels[4]);
            Controls.Add(questionLabels[5]);
            Controls.Add(questionLabels[6]);
            Controls.Add(questionLabels[7]);
            Controls.Add(questionLabels[8]);
            Controls.Add(questionLabels[9]);
            foreach (Label lab in questionLabels)
            {
                lab.Visible = false;
            }

            //sets up for first question
            func = 1;
            divlabel4.Text = "press the flowers to show the fraction\rclick the button to start!";
            divlabel2.Visible = false;
        }

        
    }
}
