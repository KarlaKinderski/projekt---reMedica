using System;
using System.Windows.Forms;

namespace PIS_Projekt
{
    public partial class ljekarnikForm : Form
    {
        public ljekarnikForm()
        {
            InitializeComponent();
        }

        private void OdustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
