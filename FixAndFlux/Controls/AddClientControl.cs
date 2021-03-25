using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FixAndFlux.Classes;

namespace FixAndFlux.Controls
{
    public partial class AddClientControl : Form
    {
        public AddClientControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            FixAndFlux.Classes.Client client = new Classes.Client();
            client.ClientFirstName = firstNameTextBox.Text;
            client.ClientName = nameTextBox.Text;
            client.Phone = phoneTextBox.Text;
            client.Email = emailTextBox.Text;
            bool result = client.Insert(client);
            if (result)
            {
                MessageBox.Show("Client inserted successfully!");
            }
            else
            {
                MessageBox.Show("Client not inserted");
            }
            this.Close();
        }
    }
}
