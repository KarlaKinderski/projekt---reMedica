using System;
using System.Windows.Forms;

namespace PIS_Projekt
{
    public partial class dodavanjeLječnikaForm : Form
    {
        public dodavanjeLječnikaForm()
        {
            InitializeComponent();
        }

        private void dodajLijecnikaButton_Click(object sender, EventArgs e)
        {
            lijecnikForm noviLijcnik = new lijecnikForm();
            noviLijcnik.ShowDialog();
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            lijecnikForm noviLijecnik = new lijecnikForm();
            noviLijecnik.ShowDialog();
        }

        private void azurirajButton_Click(object sender, EventArgs e)
        {
            lijecnikForm noviLijecnik = new lijecnikForm();
            noviLijecnik.ShowDialog();
        }

        private void OdustaniButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
