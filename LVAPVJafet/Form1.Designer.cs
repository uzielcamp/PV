
namespace LVAPVJafet
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttAbrirfrm2 = new System.Windows.Forms.Button();
            this.bttCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttAbrirfrm2
            // 
            this.bttAbrirfrm2.Location = new System.Drawing.Point(572, 361);
            this.bttAbrirfrm2.Name = "bttAbrirfrm2";
            this.bttAbrirfrm2.Size = new System.Drawing.Size(174, 58);
            this.bttAbrirfrm2.TabIndex = 0;
            this.bttAbrirfrm2.Text = "Llamar a forma 2";
            this.bttAbrirfrm2.UseVisualStyleBackColor = true;
            this.bttAbrirfrm2.Click += new System.EventHandler(this.bttAbrirfrm2_Click);
            // 
            // bttCerrar
            // 
            this.bttCerrar.Location = new System.Drawing.Point(44, 361);
            this.bttCerrar.Name = "bttCerrar";
            this.bttCerrar.Size = new System.Drawing.Size(147, 64);
            this.bttCerrar.TabIndex = 1;
            this.bttCerrar.Text = "Cerrar";
            this.bttCerrar.UseVisualStyleBackColor = true;
            this.bttCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttCerrar);
            this.Controls.Add(this.bttAbrirfrm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttAbrirfrm2;
        private System.Windows.Forms.Button bttCerrar;
    }
}

