
namespace LVAPVJafet
{
    partial class frmSearchResults
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
            this.lblWeFoundYourAnimal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWeFoundYourAnimal2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeFoundYourAnimal
            // 
            this.lblWeFoundYourAnimal.AutoSize = true;
            this.lblWeFoundYourAnimal.BackColor = System.Drawing.Color.Red;
            this.lblWeFoundYourAnimal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeFoundYourAnimal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWeFoundYourAnimal.Location = new System.Drawing.Point(38, 73);
            this.lblWeFoundYourAnimal.Name = "lblWeFoundYourAnimal";
            this.lblWeFoundYourAnimal.Size = new System.Drawing.Size(249, 27);
            this.lblWeFoundYourAnimal.TabIndex = 1;
            this.lblWeFoundYourAnimal.Text = "We found your animal";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LVAPVJafet.Properties.Resources.prrrrrrrrrrooooooo;
            this.pictureBox2.Location = new System.Drawing.Point(55, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LVAPVJafet.Properties.Resources.perro_perdido;
            this.pictureBox1.Location = new System.Drawing.Point(307, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblWeFoundYourAnimal2
            // 
            this.lblWeFoundYourAnimal2.AutoSize = true;
            this.lblWeFoundYourAnimal2.BackColor = System.Drawing.Color.Red;
            this.lblWeFoundYourAnimal2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeFoundYourAnimal2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblWeFoundYourAnimal2.Location = new System.Drawing.Point(302, 276);
            this.lblWeFoundYourAnimal2.Name = "lblWeFoundYourAnimal2";
            this.lblWeFoundYourAnimal2.Size = new System.Drawing.Size(249, 27);
            this.lblWeFoundYourAnimal2.TabIndex = 3;
            this.lblWeFoundYourAnimal2.Text = "We found your animal";
            // 
            // frmSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWeFoundYourAnimal2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblWeFoundYourAnimal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSearchResults";
            this.Text = "Search Results";
            this.Load += new System.EventHandler(this.FrmSerachResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWeFoundYourAnimal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblWeFoundYourAnimal2;
    }
}