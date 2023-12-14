namespace Würfel
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
            this.labelAktuellerWurf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Wurf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Letzter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAktuellerWurf
            // 
            this.labelAktuellerWurf.AutoSize = true;
            this.labelAktuellerWurf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAktuellerWurf.Location = new System.Drawing.Point(509, 99);
            this.labelAktuellerWurf.Name = "labelAktuellerWurf";
            this.labelAktuellerWurf.Size = new System.Drawing.Size(47, 48);
            this.labelAktuellerWurf.TabIndex = 0;
            this.labelAktuellerWurf.Text = "0";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // Wurf
            // 
            this.Wurf.AutoSize = true;
            this.Wurf.Location = new System.Drawing.Point(92, 315);
            this.Wurf.Name = "Wurf";
            this.Wurf.Size = new System.Drawing.Size(101, 20);
            this.Wurf.TabIndex = 2;
            this.Wurf.Text = "Letzter Wurf:";
          
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "Würfeln";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Letzter
            // 
            this.Letzter.AutoSize = true;
            this.Letzter.Location = new System.Drawing.Point(276, 315);
            this.Letzter.Name = "Letzter";
            this.Letzter.Size = new System.Drawing.Size(18, 20);
            this.Letzter.TabIndex = 4;
            this.Letzter.Text = "0";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Letzter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Wurf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAktuellerWurf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAktuellerWurf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Wurf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Letzter;
    }
}

