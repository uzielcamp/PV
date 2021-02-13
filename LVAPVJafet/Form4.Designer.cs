
namespace LVAPVJafet
{
    partial class frmAdopt
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
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblspaceoptiob = new System.Windows.Forms.Label();
            this.txtSapce = new System.Windows.Forms.ListBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbladresse
            // 
            this.lbladresse.AutoSize = true;
            this.lbladresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladresse.Location = new System.Drawing.Point(12, 22);
            this.lbladresse.Name = "lbladresse";
            this.lbladresse.Size = new System.Drawing.Size(74, 24);
            this.lbladresse.TabIndex = 0;
            this.lbladresse.Text = "Adress ";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(81, 22);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(279, 20);
            this.txtAdress.TabIndex = 1;
            // 
            // lblspaceoptiob
            // 
            this.lblspaceoptiob.AutoSize = true;
            this.lblspaceoptiob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspaceoptiob.Location = new System.Drawing.Point(379, 22);
            this.lblspaceoptiob.Name = "lblspaceoptiob";
            this.lblspaceoptiob.Size = new System.Drawing.Size(64, 24);
            this.lblspaceoptiob.TabIndex = 2;
            this.lblspaceoptiob.Text = "Sapce";
            // 
            // txtSapce
            // 
            this.txtSapce.FormattingEnabled = true;
            this.txtSapce.Location = new System.Drawing.Point(440, 22);
            this.txtSapce.Name = "txtSapce";
            this.txtSapce.Size = new System.Drawing.Size(155, 30);
            this.txtSapce.TabIndex = 3;
            this.txtSapce.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(382, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "e-Mail";
            this.lblEmail.Click += new System.EventHandler(this.lbl_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(440, 71);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(155, 20);
            this.txtemail.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 119);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(140, 24);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(157, 121);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(201, 20);
            this.txtPhoneNumber.TabIndex = 9;
            // 
            // frmAdopt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtSapce);
            this.Controls.Add(this.lblspaceoptiob);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lbladresse);
            this.Name = "frmAdopt";
            this.Text = "Adopt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladresse;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblspaceoptiob;
        private System.Windows.Forms.ListBox txtSapce;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}