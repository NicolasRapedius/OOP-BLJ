using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warenkorb
{
    public partial class Form1 : Form
    {
        List<OrderItem> orderedItems = new List<OrderItem>();

        public Form1()
        {
            InitializeComponent();
            // Verbindung zur Datenbank herstellen
            string connectionString = "Server=mssql1.webland.ch;Database=d041e_blj;User Id=d041e_blj;Password=BljDbPw_01;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Abfrage vorbereiten
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from products";

            // Abfrage ausführen 
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Product p = new Product();
                p.Id = Convert.ToInt32(reader["id"]);
                p.Name = reader["product_name"].ToString();
                p.Price = Convert.ToDouble( reader["price"]);
                comboBoxProdukt.Items.Add(p.Name.ToString() + ", Preis:" +  p.Price.ToString() + " Fr.");
            }

        }

        private void comboBoxProdukt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = comboBoxProdukt.SelectedItem as Product;
            int anz = Convert.ToInt32(Anzahl.Value);
            OrderItem item = new OrderItem(selectedProduct, anz);
            orderedItems.Add(item);
        }


        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Warenkorb cart = new Warenkorb(orderedItems);
            // Form modal anzeigen
            //I like kids - Nicolas Rapedius (The Pedo)
            cart.ShowDialog();
        }
    }
}
