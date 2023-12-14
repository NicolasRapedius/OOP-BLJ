namespace Warenkorb
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.link = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hinzufuegen = new System.Windows.Forms.Button();
            this.Anzahl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnazhlProdukte = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxProdukt = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anzahl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(627, 31);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(156, 20);
            this.link.TabIndex = 0;
            this.link.TabStop = true;
            this.link.Text = "Warenkorb anzeigen";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxProdukt);
            this.groupBox1.Controls.Add(this.hinzufuegen);
            this.groupBox1.Controls.Add(this.Anzahl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // hinzufuegen
            // 
            this.hinzufuegen.Location = new System.Drawing.Point(278, 205);
            this.hinzufuegen.Name = "hinzufuegen";
            this.hinzufuegen.Size = new System.Drawing.Size(257, 45);
            this.hinzufuegen.TabIndex = 4;
            this.hinzufuegen.Text = "Zum Warenkorb hinzufügen";
            this.hinzufuegen.UseVisualStyleBackColor = true;
            // 
            // Anzahl
            // 
            this.Anzahl.Location = new System.Drawing.Point(278, 131);
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.Size = new System.Drawing.Size(75, 26);
            this.Anzahl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkt:";
            // 
            // AnazhlProdukte
            // 
            this.AnazhlProdukte.AutoSize = true;
            this.AnazhlProdukte.Location = new System.Drawing.Point(542, 31);
            this.AnazhlProdukte.Name = "AnazhlProdukte";
            this.AnazhlProdukte.Size = new System.Drawing.Size(28, 20);
            this.AnazhlProdukte.TabIndex = 2;
            this.AnazhlProdukte.Text = "(0)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(578, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxProdukt
            // 
            this.comboBoxProdukt.FormattingEnabled = true;
            this.comboBoxProdukt.Location = new System.Drawing.Point(203, 38);
            this.comboBoxProdukt.Name = "comboBoxProdukt";
            this.comboBoxProdukt.Size = new System.Drawing.Size(462, 28);
            this.comboBoxProdukt.TabIndex = 5;
            this.comboBoxProdukt.SelectedIndexChanged += new System.EventHandler(this.comboBoxProdukt_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnazhlProdukte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.link);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anzahl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hinzufuegen;
        private System.Windows.Forms.NumericUpDown Anzahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AnazhlProdukte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxProdukt;
    }
}

