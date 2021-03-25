using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixAndFlux
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FixAndFlux.Controls.AddConsoleControl addConsoleControl = new Controls.AddConsoleControl();
            addConsoleControl.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FixAndFlux.Controls.AddClientControl clientControl = new Controls.AddClientControl();
            clientControl.Show();
        }
    }
}
