namespace Tannenbaum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStammBreite = new System.Windows.Forms.TextBox();
            this.textBoxStammHoehe = new System.Windows.Forms.TextBox();
            this.textBoxKronenHoehe = new System.Windows.Forms.TextBox();
            this.buttonErstellen = new System.Windows.Forms.Button();
            this.textBoxAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stammbreite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stammhöhe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kronenhöhe";
            // 
            // textBoxStammBreite
            // 
            this.textBoxStammBreite.Location = new System.Drawing.Point(137, 15);
            this.textBoxStammBreite.Name = "textBoxStammBreite";
            this.textBoxStammBreite.Size = new System.Drawing.Size(132, 26);
            this.textBoxStammBreite.TabIndex = 3;
            // 
            // textBoxStammHoehe
            // 
            this.textBoxStammHoehe.Location = new System.Drawing.Point(137, 61);
            this.textBoxStammHoehe.Name = "textBoxStammHoehe";
            this.textBoxStammHoehe.Size = new System.Drawing.Size(132, 26);
            this.textBoxStammHoehe.TabIndex = 4;
            // 
            // textBoxKronenHoehe
            // 
            this.textBoxKronenHoehe.Location = new System.Drawing.Point(137, 106);
            this.textBoxKronenHoehe.Name = "textBoxKronenHoehe";
            this.textBoxKronenHoehe.Size = new System.Drawing.Size(132, 26);
            this.textBoxKronenHoehe.TabIndex = 5;
            // 
            // buttonErstellen
            // 
            this.buttonErstellen.Location = new System.Drawing.Point(307, 105);
            this.buttonErstellen.Name = "buttonErstellen";
            this.buttonErstellen.Size = new System.Drawing.Size(132, 29);
            this.buttonErstellen.TabIndex = 6;
            this.buttonErstellen.Text = "Tanne zeichnen";
            this.buttonErstellen.UseVisualStyleBackColor = true;
            this.buttonErstellen.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAusgabe
            // 
            this.textBoxAusgabe.Location = new System.Drawing.Point(27, 168);
            this.textBoxAusgabe.Multiline = true;
            this.textBoxAusgabe.Name = "textBoxAusgabe";
            this.textBoxAusgabe.ReadOnly = true;
            this.textBoxAusgabe.Size = new System.Drawing.Size(412, 335);
            this.textBoxAusgabe.TabIndex = 7;
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 537);
            this.Controls.Add(this.textBoxAusgabe);
            this.Controls.Add(this.buttonErstellen);
            this.Controls.Add(this.textBoxKronenHoehe);
            this.Controls.Add(this.textBoxStammHoehe);
            this.Controls.Add(this.textBoxStammBreite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStammBreite;
        private System.Windows.Forms.TextBox textBoxStammHoehe;
        private System.Windows.Forms.TextBox textBoxKronenHoehe;
        private System.Windows.Forms.Button buttonErstellen;
        private System.Windows.Forms.TextBox textBoxAusgabe;
    }
}

