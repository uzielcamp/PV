
namespace LVAPVJafet
{
    partial class frmAdoptionRequest
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
            this.mntPickUpDay = new System.Windows.Forms.MonthCalendar();
            this.lblPPetName = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lblPickUpDay = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.prgSave = new System.Windows.Forms.ProgressBar();
            this.bttSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mntPickUpDay
            // 
            this.mntPickUpDay.Location = new System.Drawing.Point(18, 64);
            this.mntPickUpDay.Name = "mntPickUpDay";
            this.mntPickUpDay.TabIndex = 0;
            this.mntPickUpDay.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblPPetName
            // 
            this.lblPPetName.AutoSize = true;
            this.lblPPetName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPetName.Location = new System.Drawing.Point(582, 204);
            this.lblPPetName.Name = "lblPPetName";
            this.lblPPetName.Size = new System.Drawing.Size(94, 22);
            this.lblPPetName.TabIndex = 1;
            this.lblPPetName.Text = "Pet Name";
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(501, 240);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(256, 20);
            this.txtPetName.TabIndex = 2;
            // 
            // lblPickUpDay
            // 
            this.lblPickUpDay.AutoSize = true;
            this.lblPickUpDay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickUpDay.Location = new System.Drawing.Point(0, 23);
            this.lblPickUpDay.Name = "lblPickUpDay";
            this.lblPickUpDay.Size = new System.Drawing.Size(421, 22);
            this.lblPickUpDay.TabIndex = 3;
            this.lblPickUpDay.Text = "Choose the day you are going to pick up your pet";
            this.lblPickUpDay.Click += new System.EventHandler(this.lblPickUpDay_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(14, 250);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(50, 22);
            this.lblHour.TabIndex = 5;
            this.lblHour.Text = "Hour";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(70, 254);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(124, 20);
            this.txtHour.TabIndex = 6;
            // 
            // prgSave
            // 
            this.prgSave.Location = new System.Drawing.Point(571, 333);
            this.prgSave.Name = "prgSave";
            this.prgSave.Size = new System.Drawing.Size(186, 24);
            this.prgSave.TabIndex = 7;
            this.prgSave.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(602, 374);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(116, 49);
            this.bttSave.TabIndex = 8;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LVAPVJafet.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(535, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdoptionRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.prgSave);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPickUpDay);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.lblPPetName);
            this.Controls.Add(this.mntPickUpDay);
            this.Name = "frmAdoptionRequest";
            this.Text = "Adoption Request";
            this.Load += new System.EventHandler(this.frmAdoptionRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mntPickUpDay;
        private System.Windows.Forms.Label lblPPetName;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lblPickUpDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.ProgressBar prgSave;
        private System.Windows.Forms.Button bttSave;
    }
}