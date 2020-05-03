using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PIS_Projekt
{
    public partial class pocetnaLjekarnik : Form
    {
        public pocetnaLjekarnik()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ReceptButton_Click(object sender, EventArgs e)
        {
            receptFroma novaReceptForma = new receptFroma();
            novaReceptForma.ShowDialog();
        }

        private void pocetna_Load(object sender, EventArgs e)
        {
            vrijeme.Text = DateTime.Now.ToLongTimeString();
            datum.Text = DateTime.Now.ToShortDateString();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Naplatabutton_Click(object sender, EventArgs e)
        {

        }

        private void izdavanjeLijekovadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dodajLjekarnikaButton_Click(object sender, EventArgs e)
        {
            dodavanjeLjekarnikaForm noviLjekarnik = new dodavanjeLjekarnikaForm();
            noviLjekarnik.ShowDialog();
        }
    }
}
