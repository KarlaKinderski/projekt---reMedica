using System;
using System.Windows.Forms;

namespace PIS_Projekt
{
    public partial class lijecnikForm : Form
    {
        public lijecnikForm()
        {
            InitializeComponent();
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
