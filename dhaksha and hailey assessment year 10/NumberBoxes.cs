using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

namespace dhaksha_and_hailey_assessment_year_10
{
    internal class NumberBoxes : System.Windows.Forms.PictureBox
    {
        public int Number { get; set; }

        Random rnd = new Random();

        public NumberBoxes(int number)
        {
            //constructor
            this.Number = number;

            //setup label properties
            int xvariable = (number - 1) * 110 +40;
            AccessibleDescription = Convert.ToString(rnd.Next(120, 480));
            Location = new System.Drawing.Point(xvariable, Convert.ToInt32(AccessibleDescription));
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.Zoom;
            Image = Properties.Resources.pinkFlower;
            AccessibleName = "pink";
            Click += NumberBoxes_Click;
            Cursor= Cursors.Hand;

        }

        //toggle green and gray
        private void NumberBoxes_Click(object sender, EventArgs e)
        {
            if (AccessibleName == "pink")
            {
                Image = Properties.Resources.purpleFlower;
                AccessibleName = "purple";
            }
            else
            {
                Image = Properties.Resources.pinkFlower;
                AccessibleName = "pink";
            }
        }

    }
}