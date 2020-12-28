namespace SimonSaysProject_OfekRon_ItayShachar
{
    partial class Form_SimonSays
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SimonSays));
            this.YellowPictureBox = new System.Windows.Forms.PictureBox();
            this.BluePictureBox = new System.Windows.Forms.PictureBox();
            this.RedPictureBox = new System.Windows.Forms.PictureBox();
            this.greenPictureBox = new System.Windows.Forms.PictureBox();
            this.circle = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.YellowPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            this.SuspendLayout();
            // 
            // YellowPictureBox
            // 
            this.YellowPictureBox.Image = global::SimonSaysProject_OfekRon_ItayShachar.Properties.Resources.Yellow;
            this.YellowPictureBox.Location = new System.Drawing.Point(116, 262);
            this.YellowPictureBox.Name = "YellowPictureBox";
            this.YellowPictureBox.Size = new System.Drawing.Size(220, 200);
            this.YellowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YellowPictureBox.TabIndex = 4;
            this.YellowPictureBox.TabStop = false;
            // 
            // BluePictureBox
            // 
            this.BluePictureBox.Image = global::SimonSaysProject_OfekRon_ItayShachar.Properties.Resources.Blue;
            this.BluePictureBox.Location = new System.Drawing.Point(352, 262);
            this.BluePictureBox.Name = "BluePictureBox";
            this.BluePictureBox.Size = new System.Drawing.Size(220, 200);
            this.BluePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluePictureBox.TabIndex = 3;
            this.BluePictureBox.TabStop = false;
            this.BluePictureBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // RedPictureBox
            // 
            this.RedPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RedPictureBox.Image")));
            this.RedPictureBox.Location = new System.Drawing.Point(352, 45);
            this.RedPictureBox.Name = "RedPictureBox";
            this.RedPictureBox.Size = new System.Drawing.Size(220, 200);
            this.RedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPictureBox.TabIndex = 2;
            this.RedPictureBox.TabStop = false;
            this.RedPictureBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // greenPictureBox
            // 
            this.greenPictureBox.Image = global::SimonSaysProject_OfekRon_ItayShachar.Properties.Resources.Green;
            this.greenPictureBox.Location = new System.Drawing.Point(116, 45);
            this.greenPictureBox.Name = "greenPictureBox";
            this.greenPictureBox.Size = new System.Drawing.Size(220, 200);
            this.greenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenPictureBox.TabIndex = 1;
            this.greenPictureBox.TabStop = false;
            // 
            // circle
            // 
            this.circle.Image = global::SimonSaysProject_OfekRon_ItayShachar.Properties.Resources.Circle;
            this.circle.Location = new System.Drawing.Point(-2, 0);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(689, 499);
            this.circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circle.TabIndex = 0;
            this.circle.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.startButton.Location = new System.Drawing.Point(207, 505);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(280, 49);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start Playing!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_SimonSays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 598);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.YellowPictureBox);
            this.Controls.Add(this.BluePictureBox);
            this.Controls.Add(this.RedPictureBox);
            this.Controls.Add(this.greenPictureBox);
            this.Controls.Add(this.circle);
            this.Name = "Form_SimonSays";
            this.Text = "Simon Says";
            ((System.ComponentModel.ISupportInitialize)(this.YellowPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.PictureBox greenPictureBox;
        private System.Windows.Forms.PictureBox RedPictureBox;
        private System.Windows.Forms.PictureBox BluePictureBox;
        private System.Windows.Forms.PictureBox YellowPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

