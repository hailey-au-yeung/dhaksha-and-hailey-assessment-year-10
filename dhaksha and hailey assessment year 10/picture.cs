using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dhaksha_and_hailey_assessment_year_10
{
    internal class picture : PictureBox
    {
        public int PictureNumber { get; set; }

        Random rnd = new Random();
        public int decidingnum = 0; //naming all of the global variables



        public picture(int pictureNumber, int decidingnum)
        {
            PictureNumber = pictureNumber;

            


            if (decidingnum == 1)
            {

                if (PictureNumber == 1)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.pic1;
                }
                else if (PictureNumber == 2)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.pic_2;
                }
                else if (PictureNumber == 3)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.pic3;
                }
                else if (PictureNumber == 4)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.pic4;
                }
                else if (PictureNumber == 5)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.pic5;
                }
                else if (PictureNumber == 6)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.pic6;
                }
                else if (PictureNumber == 7)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.pic7;
                }
                else if (PictureNumber == 8)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.pic8;
                }
                else if (PictureNumber == 9)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.pic9;
                }
                
            }

            else
            {
                if (PictureNumber == 1)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.birdpic1;
                }
                else if (PictureNumber == 2)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.birdpic2;
                }
                else if (PictureNumber == 3)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.birdpic3;
                }
                else if (PictureNumber == 4)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.birdpic4;
                }
                else if (PictureNumber == 5)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.birdpic5;
                }
                else if (PictureNumber == 6)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.birdpic6;
                }
                else if (PictureNumber == 7)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.birdpic7;
                }
                else if (PictureNumber == 8)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.birdpic8;
                }
                else if (PictureNumber == 9)
                {
                    Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.birdpic9;
                } //adding certain pictures to different places
                
            }

            
            // setup some label attributes
            Size = new Size(120, 120);
            SizeMode = PictureBoxSizeMode.Zoom;



            }



        }
    }

