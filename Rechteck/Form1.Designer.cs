namespace Rechteck
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
            this.button1 = new System.Windows.Forms.Button();
            this.Beenden = new System.Windows.Forms.Button();
            this.Breite = new System.Windows.Forms.Label();
            this.Höhe = new System.Windows.Forms.Label();
            this.textbreite = new System.Windows.Forms.TextBox();
            this.texthoehe = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Ausgabe = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Beenden
            // 
            this.Beenden.Location = new System.Drawing.Point(805, 332);
            this.Beenden.Name = "Beenden";
            this.Beenden.Size = new System.Drawing.Size(269, 32);
            this.Beenden.TabIndex = 1;
            this.Beenden.Text = "Beenden";
            this.Beenden.UseVisualStyleBackColor = true;
            this.Beenden.Click += new System.EventHandler(this.Beenden_Click);
            // 
            // Breite
            // 
            this.Breite.AutoSize = true;
            this.Breite.Location = new System.Drawing.Point(65, 60);
            this.Breite.Name = "Breite";
            this.Breite.Size = new System.Drawing.Size(161, 20);
            this.Breite.TabIndex = 2;
            this.Breite.Text = "Breite des Rechtecks";
            // 
            // Höhe
            // 
            this.Höhe.AutoSize = true;
            this.Höhe.Location = new System.Drawing.Point(65, 197);
            this.Höhe.Name = "Höhe";
            this.Höhe.Size = new System.Drawing.Size(150, 20);
            this.Höhe.TabIndex = 3;
            this.Höhe.Text = "Höhe des Rechteck";
            // 
            // textbreite
            // 
            this.textbreite.Location = new System.Drawing.Point(366, 60);
            this.textbreite.Name = "textbreite";
            this.textbreite.Size = new System.Drawing.Size(277, 26);
            this.textbreite.TabIndex = 4;
            // 
            // texthoehe
            // 
            this.texthoehe.Location = new System.Drawing.Point(366, 191);
            this.texthoehe.Name = "texthoehe";
            this.texthoehe.Size = new System.Drawing.Size(281, 26);
            this.texthoehe.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(362, 332);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(281, 26);
            this.textBox3.TabIndex = 6;
            // 
            // Ausgabe
            // 
            this.Ausgabe.AutoSize = true;
            this.Ausgabe.Location = new System.Drawing.Point(76, 332);
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.Size = new System.Drawing.Size(135, 20);
            this.Ausgabe.TabIndex = 7;
            this.Ausgabe.Text = "Ausgabe (Fläche)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(839, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.texthoehe);
            this.Controls.Add(this.textbreite);
            this.Controls.Add(this.Höhe);
            this.Controls.Add(this.Breite);
            this.Controls.Add(this.Beenden);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Beenden;
        private System.Windows.Forms.Label Breite;
        private System.Windows.Forms.Label Höhe;
        private System.Windows.Forms.TextBox textbreite;
        private System.Windows.Forms.TextBox texthoehe;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Ausgabe;
        private System.Windows.Forms.Button button2;
    }
}

