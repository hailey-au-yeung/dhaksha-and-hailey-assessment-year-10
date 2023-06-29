using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dhaksha_and_hailey_assessment_year_10
{
    internal class questionNos: System.Windows.Forms.Label
    {
        public int Number { get; set; }

        public questionNos(int number)
        {
            Number = number;
            Text = Convert.ToString(number);
            Size = new Size(109, 30);
            Font = new Font("Microsoft Sans Serif", 13);
            Location = new System.Drawing.Point(1080,(50+number*30));
        }
    }
}
