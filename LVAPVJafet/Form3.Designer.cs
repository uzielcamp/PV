﻿
namespace LVAPVJafet
{
    partial class frmstartingscreen
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
            this.bttStartingscreen = new System.Windows.Forms.Button();
            this.bttsearch = new System.Windows.Forms.Button();
            this.lblquestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttStartingscreen
            // 
            this.bttStartingscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttStartingscreen.Location = new System.Drawing.Point(103, 225);
            this.bttStartingscreen.Name = "bttStartingscreen";
            this.bttStartingscreen.Size = new System.Drawing.Size(207, 100);
            this.bttStartingscreen.TabIndex = 2;
            this.bttStartingscreen.Text = "Adopt";
            this.bttStartingscreen.UseVisualStyleBackColor = true;
            this.bttStartingscreen.Click += new System.EventHandler(this.bttAdopt_Click);
            // 
            // bttsearch
            // 
            this.bttsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttsearch.Location = new System.Drawing.Point(484, 225);
            this.bttsearch.Name = "bttsearch";
            this.bttsearch.Size = new System.Drawing.Size(183, 100);
            this.bttsearch.TabIndex = 3;
            this.bttsearch.Text = "Search";
            this.bttsearch.UseVisualStyleBackColor = true;
            this.bttsearch.Click += new System.EventHandler(this.bttsearch_Click);
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(111, 92);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(556, 55);
            this.lblquestion.TabIndex = 4;
            this.lblquestion.Text = "What do you want to do?";
            // 
            // frmstartingscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.bttsearch);
            this.Controls.Add(this.bttStartingscreen);
            this.Name = "frmstartingscreen";
            this.Text = "Starting screen";
            this.Load += new System.EventHandler(this.frmstartingscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttStartingscreen;
        private System.Windows.Forms.Button bttsearch;
        private System.Windows.Forms.Label lblquestion;
    }
}