using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace dhaksha_and_hailey_assessment_year_10
{
    public class Bunny : PictureBox
    {
       
        public int BunnyNumber { get; set; }

        public Bunny( int bunnyNumber)
        { // car constructor
          
            BunnyNumber = bunnyNumber;
            int yvariable = (BunnyNumber) * 50; //ens2uring locations are different 

            if (bunnyNumber == 6)
            { 
                Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.bunny1; //adding car images
            }
            else if (bunnyNumber == 8)
            {
                Image = dhaksha_and_hailey_assessment_year_10.Properties.Resources.bunny2;
            }

           
            // setup some label attributes
            Size = new Size(200,100);
            SizeMode = PictureBoxSizeMode.Zoom;
            Location = new Point(1, yvariable);
        }

       

        }
    }

    
    

