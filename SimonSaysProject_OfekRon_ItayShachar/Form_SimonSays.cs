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
        private int[] array_Colors = new int[arrayLength];

        private int count = 0;

        private void SetImagesArray()
        {
            array_Colors[0] = 1;
            array_Colors[1] = 2;
            array_Colors[2] = 3;
            array_Colors[3] = 4;
        }

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
            switch (array_Colors[count])
            {
                case 1:
                    greenPictureBox.Visible = false;
                    timer2.Start();
                    break;
                case 2:
                    RedPictureBox.Visible = false;
                    timer2.Start();
                    break;
                case 3:
                    BluePictureBox.Visible = false;
                    timer2.Start();
                    break;
                case 4:
                    YellowPictureBox.Visible = false;
                    timer2.Start();
                    break;
                default:
                    break;

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    greenPictureBox.Visible = true;
                    break;
                case 2:
                    RedPictureBox.Visible = true;
                    break;
                case 3:
                    BluePictureBox.Visible = true;
                    break;
                case 4:
                    YellowPictureBox.Visible = true;
                    break;
                default:
                    break;
            }

            count++;
            timer2.Stop();
        }

        private void greenPictureBox_Click(object sender, EventArgs e)
        {

        }

        public void color_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;



        }
    }
}
