using System;
using System.Windows.Forms;

namespace PIS_Projekt
{
    public partial class dodavanjeLjekarnikaForm : Form
    {
        public dodavanjeLjekarnikaForm()
        {
            InitializeComponent();
        }

        private void dodajLjekarnikaButton_Click(object sender, EventArgs e)
        {
            ljekarnikForm noviLjekarnik = new ljekarnikForm();
            noviLjekarnik.ShowDialog();
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            ljekarnikForm noviLjekarnik = new ljekarnikForm();
            noviLjekarnik.ShowDialog();
        }
    }
}
