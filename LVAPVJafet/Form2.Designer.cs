
namespace LVAPVJafet
{
    partial class Frm2
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
            this.bttCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttCerrar
            // 
            this.bttCerrar.Location = new System.Drawing.Point(658, 337);
            this.bttCerrar.Name = "bttCerrar";
            this.bttCerrar.Size = new System.Drawing.Size(114, 61);
            this.bttCerrar.TabIndex = 0;
            this.bttCerrar.Text = "Cerrar";
            this.bttCerrar.UseVisualStyleBackColor = true;
            this.bttCerrar.Click += new System.EventHandler(this.bttCerrar_Click);
            // 
            // Frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttCerrar);
            this.Name = "Frm2";
            this.Text = "Forma 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttCerrar;
    }
}