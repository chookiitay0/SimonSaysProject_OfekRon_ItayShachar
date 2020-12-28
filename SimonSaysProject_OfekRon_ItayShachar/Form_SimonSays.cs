using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimonSaysProject_OfekRon_ItayShachar.Properties;


namespace SimonSaysProject_OfekRon_ItayShachar
{
    public partial class Form_SimonSays : Form
    {
        public Form_SimonSays()
        {
            InitializeComponent();

            SetImagesArray();
        }

        private const int arrayLength = 4;
        private Image[] array_Colors = new Image[arrayLength];

        private int count = 0;

        private void SetImagesArray()
        {
            array_Colors[0] = Resources.Green;
            array_Colors[1] = Resources.Red;

            array_Colors[2] = Resources.Blue;
            array_Colors[3] = Resources.Yellow;
        }
        
        // private static int RandomColor(Image[] array_Colors)
        // {
            int green = 1;
            int red = 2;
            int blue = 3;
            int yellow = 4;


        // }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (count >= 4)
            {
                case 1:
                    count++;
                    greenPictureBox.Visible = !greenPictureBox.Visible;
                    break;
                case 2:
                    count++;
                    RedPictureBox.Visible = !RedPictureBox.Visible;
                    break;
                case 3:
                    count++;
                    BluePictureBox.Visible = !BluePictureBox.Visible;
                    break;
                case 4:
                    count++;
                    YellowPictureBox.Visible = !YellowPictureBox.Visible;
                    break;
                default:
                    break;
            }




        }
    }
}
