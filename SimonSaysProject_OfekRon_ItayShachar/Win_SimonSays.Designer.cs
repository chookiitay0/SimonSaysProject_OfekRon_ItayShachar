namespace SimonSaysProject_OfekRon_ItayShachar
{
    partial class Win_SimonSays
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
            this.Win_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Win_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Win_PictureBox
            // 
            this.Win_PictureBox.Image = global::SimonSaysProject_OfekRon_ItayShachar.Properties.Resources.Winner1;
            this.Win_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.Win_PictureBox.Name = "Win_PictureBox";
            this.Win_PictureBox.Size = new System.Drawing.Size(600, 400);
            this.Win_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Win_PictureBox.TabIndex = 0;
            this.Win_PictureBox.TabStop = false;
            // 
            // Win_SimonSays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 401);
            this.Controls.Add(this.Win_PictureBox);
            this.Name = "Win_SimonSays";
            this.Text = "Who would believe that you\'ll win the game but you actually did it!";
            ((System.ComponentModel.ISupportInitialize)(this.Win_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Win_PictureBox;
    }
}