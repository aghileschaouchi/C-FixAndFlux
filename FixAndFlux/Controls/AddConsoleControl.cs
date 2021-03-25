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
    public partial class AddConsoleControl : Form
    {
        private FixAndFlux.Classes.Console console = new Classes.Console();

        public AddConsoleControl()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            console.ConsoleName = consoleNameComboBox.Text;
            console.Problem = problemRTBox.Text;
            console.Fixed = false;
            console.ClientId = int.Parse(clientIdComboBox.Text);
            bool result = console.Insert(console);
            if (result)
            {
                MessageBox.Show("Console inserted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to insert the console");
            }
            this.Close();
        }

        private void AddConsole_Load(object sender, EventArgs e)
        {
            Client client = new Client();
            DataTable clientDataTable = client.Select();
            clientIdComboBox.BindingContext = this.BindingContext;
            clientIdComboBox.DataSource = clientDataTable;
            clientIdComboBox.DisplayMember = "ClientId";
        }

        private void consoleBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
