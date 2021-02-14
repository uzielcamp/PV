
namespace LVAPVJafet
{
    partial class FrmSearch
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
            this.lblPetName = new System.Windows.Forms.Label();
            this.txbPetname = new System.Windows.Forms.TextBox();
            this.lblCharacteristic = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblspecies = new System.Windows.Forms.Label();
            this.ckbCharacteristc = new System.Windows.Forms.CheckedListBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(12, 23);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(93, 24);
            this.lblPetName.TabIndex = 0;
            this.lblPetName.Text = "Pet Name";
            // 
            // txbPetname
            // 
            this.txbPetname.Location = new System.Drawing.Point(111, 23);
            this.txbPetname.Name = "txbPetname";
            this.txbPetname.Size = new System.Drawing.Size(226, 20);
            this.txbPetname.TabIndex = 1;
            this.txbPetname.TextChanged += new System.EventHandler(this.txbPetname_TextChanged);
            // 
            // lblCharacteristic
            // 
            this.lblCharacteristic.AutoSize = true;
            this.lblCharacteristic.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacteristic.Location = new System.Drawing.Point(12, 68);
            this.lblCharacteristic.Name = "lblCharacteristic";
            this.lblCharacteristic.Size = new System.Drawing.Size(125, 22);
            this.lblCharacteristic.TabIndex = 2;
            this.lblCharacteristic.Text = "Characteristic";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblspecies
            // 
            this.lblspecies.AutoSize = true;
            this.lblspecies.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspecies.Location = new System.Drawing.Point(13, 114);
            this.lblspecies.Name = "lblspecies";
            this.lblspecies.Size = new System.Drawing.Size(80, 22);
            this.lblspecies.TabIndex = 4;
            this.lblspecies.Text = "Species";
            // 
            // ckbCharacteristc
            // 
            this.ckbCharacteristc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCharacteristc.FormattingEnabled = true;
            this.ckbCharacteristc.Items.AddRange(new object[] {
            "Big",
            "Medium",
            "Small"});
            this.ckbCharacteristc.Location = new System.Drawing.Point(424, 72);
            this.ckbCharacteristc.Name = "ckbCharacteristc";
            this.ckbCharacteristc.Size = new System.Drawing.Size(95, 67);
            this.ckbCharacteristc.TabIndex = 7;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(371, 72);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(47, 22);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Size";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(373, 21);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 22);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(424, 23);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(131, 20);
            this.txtAge.TabIndex = 10;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(578, 21);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(56, 22);
            this.lblColor.TabIndex = 11;
            this.lblColor.Text = "Color";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(640, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // bttSearch
            // 
            this.bttSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSearch.Location = new System.Drawing.Point(343, 304);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(122, 57);
            this.bttSearch.TabIndex = 13;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Rabbit",
            "Birds",
            "Snake",
            "Spiders",
            "Iguana",
            "Pig",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(99, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bttSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.ckbCharacteristc);
            this.Controls.Add(this.lblspecies);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCharacteristic);
            this.Controls.Add(this.txbPetname);
            this.Controls.Add(this.lblPetName);
            this.Name = "FrmSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.TextBox txbPetname;
        private System.Windows.Forms.Label lblCharacteristic;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblspecies;
        private System.Windows.Forms.CheckedListBox ckbCharacteristc;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}