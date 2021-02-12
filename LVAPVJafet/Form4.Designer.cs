
namespace LVAPVJafet
{
    partial class frmadopt
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
            this.lbladresse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblspaceoptiob = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbladresse
            // 
            this.lbladresse.AutoSize = true;
            this.lbladresse.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladresse.Location = new System.Drawing.Point(12, 22);
            this.lbladresse.Name = "lbladresse";
            this.lbladresse.Size = new System.Drawing.Size(63, 23);
            this.lbladresse.TabIndex = 0;
            this.lbladresse.Text = "Adress ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblspaceoptiob
            // 
            this.lblspaceoptiob.AutoSize = true;
            this.lblspaceoptiob.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspaceoptiob.Location = new System.Drawing.Point(379, 22);
            this.lblspaceoptiob.Name = "lblspaceoptiob";
            this.lblspaceoptiob.Size = new System.Drawing.Size(55, 23);
            this.lblspaceoptiob.TabIndex = 2;
            this.lblspaceoptiob.Text = "Sapce";
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(440, 22);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(155, 30);
            this.lst.TabIndex = 3;
            // 
            // frmadopt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.lblspaceoptiob);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbladresse);
            this.Name = "frmadopt";
            this.Text = "Adopt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladresse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblspaceoptiob;
        private System.Windows.Forms.ListBox lst;
    }
}