using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Simulator
{
    public partial class Form1 : Form
    {
        private Auto auto;
        public Form1()
        {
            InitializeComponent();
            comboBoxAutos.Items.Add(new Auto("Porsche", 250));
            comboBoxAutos.Items.Add(new Auto("Opel", 90));
            comboBoxAutos.Items.Add(new Auto("Ferrari", 370));
        }
        private void comboBoxAutos_SelectedIndexChanged(object sender, EventArgs e)
        {

            auto = comboBoxAutos.SelectedItem as Auto;
            labelPS.Text = auto.PS.ToString() + " PS";
            labelKmhAuto.Text = Convert.ToInt32(auto.AktuelleGeschwindigkeit).ToString();
            progressBarTank.Value = Convert.ToInt32(auto.TankFuellstand);


        }
        private void pictureBoxHupe_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.hupe);
            player.Play();
        }

  
       

        private void pictureBoxSchlüssel_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Start);
            player.Play();
        }

        private void timerTanken_Tick(object sender, EventArgs e)
        {
            auto.auftanken();
            progressBarTank.Value = Convert.ToInt32(auto.TankFuellstand);
        }

        private void pictureBoxTanken_MouseDown(object sender, MouseEventArgs e)
        {
            timerTanken.Start();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Tanken);
            player.Play();
        }

        private void pictureBoxTanken_MouseUp(object sender, MouseEventArgs e)
        {
            timerTanken.Stop();
        }

        private void buttonGas_MouseDown(object sender, MouseEventArgs e)
        {
            timerGas.Start();
        }

        private void timerGas_Tick(object sender, EventArgs e)
        {
            auto.GibGas();
            labelKmhAuto.Text = Convert.ToInt32(auto.AktuelleGeschwindigkeit).ToString();
            progressBarTank.Value = Convert.ToInt32(auto.TankFuellstand);


        }

        private void buttonGas_MouseUp(object sender, MouseEventArgs e)
        {
            timerGas.Stop();
        }
    }
}
