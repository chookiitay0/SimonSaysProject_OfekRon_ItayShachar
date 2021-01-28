using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        private PictureBox[] array_Colors = new PictureBox[arrayLength];
        
        Random rnd = new Random();

        private int[] blinkOrder = new int[10];
        private int k;
        private int countFlash = 0;
        private int level = 1;
        private int countCompBlink = -1;
        private int countClicks = 0;
        string strStage;

        private Win_SimonSays WinnerMessage = new Win_SimonSays();
        private Lose_SimonSays LoseMessage = new Lose_SimonSays();

        private void SetImagesArray()
        {
            array_Colors[0] = pictureBox0;
            array_Colors[1] = pictureBox1;
            array_Colors[2] = pictureBox2;
            array_Colors[3] = pictureBox3;

            for (int i = 0; i < blinkOrder.Length; i++)
            {
                blinkOrder[i] = rnd.Next(0, 4);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            array_Colors[0].Visible = true;
            array_Colors[1].Visible = true;
            array_Colors[2].Visible = true;
            array_Colors[3].Visible = true;
            startButton.Visible = false;

            SetImagesArray();
            countClicks = 0;
            countCompBlink = -1;
            level = 1;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countCompBlink++;
            countFlash = 0;

            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (countFlash == 0)
                array_Colors[blinkOrder[countCompBlink]].Visible = false;

            else if (countFlash == 1)
                array_Colors[blinkOrder[countCompBlink]].Visible = true;

            else
            {
                if ((countCompBlink + 1) >= level)
                    timer1.Stop();

                timer2.Stop();
            }
            countFlash++;
        }

        public void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            countClicks++;

            string imageName = pictureBox.Name;
            k = int.Parse(imageName.Substring(imageName.Length - 1));

            countFlash = 0;

            timer3.Start();

            if (k != blinkOrder[countClicks - 1])
            {
                LoseMessage.Show();
                array_Colors[0].Visible = false;
                array_Colors[1].Visible = false;
                array_Colors[2].Visible = false;
                array_Colors[3].Visible = false;

                startButton.Visible = true;
            }

            if (countClicks == level)
            {
                strStage = "Stage " + level;
                stage.Text = strStage;
                stage.Visible = true;
                countClicks = 0;
                countCompBlink = -1;

                if (level == blinkOrder.Length)
                {
                    //המחשב מציג הודעה, מעלים את התמונות ומחזיר את כפתור ההתחלה
                    WinnerMessage.Show();
                    array_Colors[0].Visible = false;
                    array_Colors[1].Visible = false;
                    array_Colors[2].Visible = false;
                    array_Colors[3].Visible = false;

                    startButton.Visible = true;
                }

                else
                {
                    // המחשב ממשיך לשלב הבא
                    timer1.Start();

                    level++;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (countFlash == 0)
                array_Colors[k].Visible = false;

            else if (countFlash == 1)
                array_Colors[k].Visible = true;

            else
                timer3.Stop();

            countFlash++;
        }

        
    }
}
