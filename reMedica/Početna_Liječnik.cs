using System;
using System.Windows.Forms;

namespace PIS_Projekt
{
    public partial class pocetnaLijecnik : Form
    {
        public pocetnaLijecnik()
        {
            InitializeComponent();
        }

        private void Početna_Liječnik_Load(object sender, EventArgs e)
        {
            vrijeme.Text = DateTime.Now.ToLongTimeString();
            datum.Text = DateTime.Now.ToShortDateString();
            OIBTextBox.Select();
        }

        private void DodajPacijentaButton_Click(object sender, EventArgs e)
        {
            pacijentiForma noviPacijent = new pacijentiForma();
            noviPacijent.ShowDialog();
        }

        private void azuriranjePacijentaFormaButton_Click(object sender, EventArgs e)
        {
            azuriranjePacijentaForma novoAzruriranje = new azuriranjePacijentaForma();
            novoAzruriranje.ShowDialog();
        }

        private void PrepisiButton_Click(object sender, EventArgs e)
        {
            prepisLijekovaForma noviPrepisLijekova = new prepisLijekovaForma();
            noviPrepisLijekova.ShowDialog();
        }

        private void OIBTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodajLječnikaButton_Click(object sender, EventArgs e)
        {
            dodavanjeLječnikaForm noviLjecnik = new dodavanjeLječnikaForm();
            noviLjecnik.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            narucivanjeNaPregledForm novaNarudzba = new narucivanjeNaPregledForm();
            novaNarudzba.ShowDialog();
        }

        private void dijagnozaITerpaijaButton_Click(object sender, EventArgs e)
        {
            dijagnozaITerpijaForm novadijagnozaITerapija = new dijagnozaITerpijaForm();
            novadijagnozaITerapija.ShowDialog();
        }
    }
}
