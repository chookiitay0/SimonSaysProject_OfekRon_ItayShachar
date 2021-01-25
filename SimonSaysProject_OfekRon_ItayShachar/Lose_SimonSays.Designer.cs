namespace SimonSaysProject_OfekRon_ItayShachar
{
    partial class Lose_SimonSays
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
            this.lose_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lose_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lose_PictureBox
            // 
            this.lose_PictureBox.Image = global::SimonSaysProject_OfekRon_ItayShachar.Properties.Resources.Loser;
            this.lose_PictureBox.Location = new System.Drawing.Point(0, 0);
            this.lose_PictureBox.Name = "lose_PictureBox";
            this.lose_PictureBox.Size = new System.Drawing.Size(600, 400);
            this.lose_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lose_PictureBox.TabIndex = 0;
            this.lose_PictureBox.TabStop = false;
            // 
            // Lose_SimonSays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 401);
            this.Controls.Add(this.lose_PictureBox);
            this.Name = "Lose_SimonSays";
            this.Text = "You lost the game as I expected...";
            ((System.ComponentModel.ISupportInitialize)(this.lose_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lose_PictureBox;
    }
}