using System;
using System.Windows.Forms;

namespace PIS_Projekt
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void Prijava_Load(object sender, EventArgs e)
        {
            korisnickoIme.Select();
        }
        private void korisnickoIme_Click(object sender, EventArgs e)
        {

        }
        private void lozinka_Click(object sender, EventArgs e)
        {

            lozinka.PasswordChar = '*';
        }
        private void PrijavaButton(object sender, EventArgs e)
        {
            pocetnaLjekarnik pocetnaForma = new pocetnaLjekarnik();
            pocetnaForma.ShowDialog();
        }

        private void Prijava2button_Click(object sender, EventArgs e)
        {
            pocetnaLijecnik pocetnaForma = new pocetnaLijecnik();
            pocetnaForma.ShowDialog();
           
        }


    }
}
