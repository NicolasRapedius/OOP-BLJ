namespace Auto_Simulator
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBoxSchlüssel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelWählen = new System.Windows.Forms.Label();
            this.comboBoxAutos = new System.Windows.Forms.ComboBox();
            this.labelPS = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBarTank = new System.Windows.Forms.ProgressBar();
            this.labelGear = new System.Windows.Forms.Label();
            this.labelKMH = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelGearAuto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelKmhAuto = new System.Windows.Forms.Label();
            this.pictureBoxTankanzeigeLeer = new System.Windows.Forms.PictureBox();
            this.pictureBoxTankAnzeigeVoll = new System.Windows.Forms.PictureBox();
            this.groupBoxAnAus = new System.Windows.Forms.GroupBox();
            this.buttonBremse = new System.Windows.Forms.Button();
            this.buttonGas = new System.Windows.Forms.Button();
            this.pictureBoxTanken = new System.Windows.Forms.PictureBox();
            this.pictureBoxHupe = new System.Windows.Forms.PictureBox();
            this.timerTanken = new System.Windows.Forms.Timer(this.components);
            this.timerGas = new System.Windows.Forms.Timer(this.components);
            pictureBoxSchlüssel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxSchlüssel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTankanzeigeLeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTankAnzeigeVoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanken)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSchlüssel
            // 
            pictureBoxSchlüssel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchlüssel.Image")));
            pictureBoxSchlüssel.Location = new System.Drawing.Point(20, 62);
            pictureBoxSchlüssel.Name = "pictureBoxSchlüssel";
            pictureBoxSchlüssel.Size = new System.Drawing.Size(49, 51);
            pictureBoxSchlüssel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxSchlüssel.TabIndex = 3;
            pictureBoxSchlüssel.TabStop = false;
            pictureBoxSchlüssel.Click += new System.EventHandler(this.pictureBoxSchlüssel_Click);
            // 
            // labelWählen
            // 
            this.labelWählen.AutoSize = true;
            this.labelWählen.Location = new System.Drawing.Point(12, 9);
            this.labelWählen.Name = "labelWählen";
            this.labelWählen.Size = new System.Drawing.Size(97, 20);
            this.labelWählen.TabIndex = 0;
            this.labelWählen.Text = "Auto wählen";
            // 
            // comboBoxAutos
            // 
            this.comboBoxAutos.FormattingEnabled = true;
            this.comboBoxAutos.Location = new System.Drawing.Point(113, 6);
            this.comboBoxAutos.Name = "comboBoxAutos";
            this.comboBoxAutos.Size = new System.Drawing.Size(298, 28);
            this.comboBoxAutos.TabIndex = 1;
            this.comboBoxAutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutos_SelectedIndexChanged);
            // 
            // labelPS
            // 
            this.labelPS.AutoSize = true;
            this.labelPS.ForeColor = System.Drawing.Color.Maroon;
            this.labelPS.Location = new System.Drawing.Point(434, 4);
            this.labelPS.Name = "labelPS";
            this.labelPS.Size = new System.Drawing.Size(43, 20);
            this.labelPS.TabIndex = 2;
            this.labelPS.Text = "0 PS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.progressBarTank);
            this.groupBox1.Controls.Add(this.labelGear);
            this.groupBox1.Controls.Add(this.labelKMH);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBoxTankanzeigeLeer);
            this.groupBox1.Controls.Add(this.pictureBoxTankAnzeigeVoll);
            this.groupBox1.Location = new System.Drawing.Point(123, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 216);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // progressBarTank
            // 
            this.progressBarTank.Location = new System.Drawing.Point(71, 163);
            this.progressBarTank.Name = "progressBarTank";
            this.progressBarTank.Size = new System.Drawing.Size(344, 32);
            this.progressBarTank.TabIndex = 8;
            // 
            // labelGear
            // 
            this.labelGear.AutoSize = true;
            this.labelGear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelGear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGear.Location = new System.Drawing.Point(308, 22);
            this.labelGear.Name = "labelGear";
            this.labelGear.Size = new System.Drawing.Size(45, 20);
            this.labelGear.TabIndex = 3;
            this.labelGear.Text = "Gear";
            // 
            // labelKMH
            // 
            this.labelKMH.AutoSize = true;
            this.labelKMH.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelKMH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKMH.Location = new System.Drawing.Point(22, 21);
            this.labelKMH.Name = "labelKMH";
            this.labelKMH.Size = new System.Drawing.Size(39, 20);
            this.labelKMH.TabIndex = 2;
            this.labelKMH.Text = "kmh";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Controls.Add(this.labelGearAuto);
            this.groupBox3.Location = new System.Drawing.Point(312, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 93);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // labelGearAuto
            // 
            this.labelGearAuto.AutoSize = true;
            this.labelGearAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGearAuto.ForeColor = System.Drawing.Color.Cyan;
            this.labelGearAuto.Location = new System.Drawing.Point(31, 22);
            this.labelGearAuto.Name = "labelGearAuto";
            this.labelGearAuto.Size = new System.Drawing.Size(51, 55);
            this.labelGearAuto.TabIndex = 1;
            this.labelGearAuto.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.labelKmhAuto);
            this.groupBox2.Location = new System.Drawing.Point(26, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 93);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // labelKmhAuto
            // 
            this.labelKmhAuto.AutoSize = true;
            this.labelKmhAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKmhAuto.ForeColor = System.Drawing.Color.Lime;
            this.labelKmhAuto.Location = new System.Drawing.Point(97, 22);
            this.labelKmhAuto.Name = "labelKmhAuto";
            this.labelKmhAuto.Size = new System.Drawing.Size(51, 55);
            this.labelKmhAuto.TabIndex = 0;
            this.labelKmhAuto.Text = "0";
            // 
            // pictureBoxTankanzeigeLeer
            // 
            this.pictureBoxTankanzeigeLeer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxTankanzeigeLeer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTankanzeigeLeer.Image")));
            this.pictureBoxTankanzeigeLeer.Location = new System.Drawing.Point(-10, 131);
            this.pictureBoxTankanzeigeLeer.Name = "pictureBoxTankanzeigeLeer";
            this.pictureBoxTankanzeigeLeer.Size = new System.Drawing.Size(107, 99);
            this.pictureBoxTankanzeigeLeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTankanzeigeLeer.TabIndex = 7;
            this.pictureBoxTankanzeigeLeer.TabStop = false;
            // 
            // pictureBoxTankAnzeigeVoll
            // 
            this.pictureBoxTankAnzeigeVoll.Image = global::Auto_Simulator.Properties.Resources.d6232971_b22e_4edb_a493_306813aab1f7_removebg_preview;
            this.pictureBoxTankAnzeigeVoll.Location = new System.Drawing.Point(-1, 137);
            this.pictureBoxTankAnzeigeVoll.Name = "pictureBoxTankAnzeigeVoll";
            this.pictureBoxTankAnzeigeVoll.Size = new System.Drawing.Size(98, 79);
            this.pictureBoxTankAnzeigeVoll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTankAnzeigeVoll.TabIndex = 10;
            this.pictureBoxTankAnzeigeVoll.TabStop = false;
            this.pictureBoxTankAnzeigeVoll.Visible = false;
            // 
            // groupBoxAnAus
            // 
            this.groupBoxAnAus.BackColor = System.Drawing.Color.Red;
            this.groupBoxAnAus.Location = new System.Drawing.Point(73, 64);
            this.groupBoxAnAus.Name = "groupBoxAnAus";
            this.groupBoxAnAus.Size = new System.Drawing.Size(22, 20);
            this.groupBoxAnAus.TabIndex = 7;
            this.groupBoxAnAus.TabStop = false;
            // 
            // buttonBremse
            // 
            this.buttonBremse.Location = new System.Drawing.Point(276, 296);
            this.buttonBremse.Name = "buttonBremse";
            this.buttonBremse.Size = new System.Drawing.Size(135, 178);
            this.buttonBremse.TabIndex = 8;
            this.buttonBremse.Text = "Bremse";
            this.buttonBremse.UseVisualStyleBackColor = true;
            // 
            // buttonGas
            // 
            this.buttonGas.Location = new System.Drawing.Point(435, 306);
            this.buttonGas.Name = "buttonGas";
            this.buttonGas.Size = new System.Drawing.Size(121, 178);
            this.buttonGas.TabIndex = 9;
            this.buttonGas.Text = "Gas";
            this.buttonGas.UseVisualStyleBackColor = true;
            this.buttonGas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGas_MouseDown);
            this.buttonGas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonGas_MouseUp);
            // 
            // pictureBoxTanken
            // 
            this.pictureBoxTanken.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTanken.Image")));
            this.pictureBoxTanken.Location = new System.Drawing.Point(20, 212);
            this.pictureBoxTanken.Name = "pictureBoxTanken";
            this.pictureBoxTanken.Size = new System.Drawing.Size(49, 51);
            this.pictureBoxTanken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTanken.TabIndex = 5;
            this.pictureBoxTanken.TabStop = false;
            this.pictureBoxTanken.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTanken_MouseDown);
            this.pictureBoxTanken.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxTanken_MouseUp);
            // 
            // pictureBoxHupe
            // 
            this.pictureBoxHupe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHupe.Image")));
            this.pictureBoxHupe.Location = new System.Drawing.Point(20, 136);
            this.pictureBoxHupe.Name = "pictureBoxHupe";
            this.pictureBoxHupe.Size = new System.Drawing.Size(49, 51);
            this.pictureBoxHupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHupe.TabIndex = 4;
            this.pictureBoxHupe.TabStop = false;
            this.pictureBoxHupe.Click += new System.EventHandler(this.pictureBoxHupe_Click);
            // 
            // timerTanken
            // 
            this.timerTanken.Interval = 950;
            this.timerTanken.Tick += new System.EventHandler(this.timerTanken_Tick);
            // 
            // timerGas
            // 
            this.timerGas.Tick += new System.EventHandler(this.timerGas_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 496);
            this.Controls.Add(this.buttonGas);
            this.Controls.Add(this.buttonBremse);
            this.Controls.Add(this.groupBoxAnAus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxTanken);
            this.Controls.Add(this.pictureBoxHupe);
            this.Controls.Add(pictureBoxSchlüssel);
            this.Controls.Add(this.labelPS);
            this.Controls.Add(this.comboBoxAutos);
            this.Controls.Add(this.labelWählen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(pictureBoxSchlüssel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTankanzeigeLeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTankAnzeigeVoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTanken)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWählen;
        private System.Windows.Forms.ComboBox comboBoxAutos;
        private System.Windows.Forms.Label labelPS;
        private System.Windows.Forms.PictureBox pictureBoxHupe;
        private System.Windows.Forms.PictureBox pictureBoxTanken;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelGear;
        private System.Windows.Forms.Label labelKMH;
        private System.Windows.Forms.Label labelKmhAuto;
        private System.Windows.Forms.Label labelGearAuto;
        private System.Windows.Forms.PictureBox pictureBoxTankanzeigeLeer;
        private System.Windows.Forms.GroupBox groupBoxAnAus;
        private System.Windows.Forms.ProgressBar progressBarTank;
        private System.Windows.Forms.Button buttonBremse;
        private System.Windows.Forms.Button buttonGas;
        private System.Windows.Forms.PictureBox pictureBoxTankAnzeigeVoll;
        private System.Windows.Forms.Timer timerTanken;
        private System.Windows.Forms.Timer timerGas;
    }
}

