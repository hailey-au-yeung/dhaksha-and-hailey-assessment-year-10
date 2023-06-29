using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dhaksha_and_hailey_assessment_year_10
{
    internal class mushroom : System.Windows.Forms.PictureBox
    {
        public int Number { get; set; }
        Random rnd = new Random();

        public mushroom(int number)
        {
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.Zoom;
            Image = Properties.Resources.mushroom;
            if (number==7) { Location = new Point(94, 48); }
            else if (number == 3) { Location = new Point(454, 125); }
            else if (number == 2) { Location = new Point(715, 12); }
            else if (number == 8) { Location = new Point(1051, 90); }
            else if (number == 6) { Location = new Point(1147, 307); }
            else if (number == 1) { Location = new Point(812, 420); }
            else if (number == 5) { Location = new Point(320, 375); }
            else if (number == 4) { Location = new Point(22, 291); }
        }
    }
}
