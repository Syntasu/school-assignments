using System;
using System.Windows.Forms;

namespace ProgrammerenHuiswerk_Rente
{
    public partial class Form1 : Form
    {
        private int jaren = 0;
        private double bedrag = 0;
        private double rente = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnBereken_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtJaar.Text, out jaren))
            {
                MessageBox.Show("Het ingevoerde aantal jaren is incorrect!", "ERROR", MessageBoxButtons.OK);
                return;
            }

            if(!double.TryParse(txtBedrag.Text, out bedrag))
            {
                MessageBox.Show("Het ingevoerde bedrag is incorrect!", "ERROR", MessageBoxButtons.OK);
                return;
            }

            if (!double.TryParse(txtRente.Text, out rente))
            {
                MessageBox.Show("Het ingevoerde rente is incorrect!", "ERROR", MessageBoxButtons.OK);
                return;
            }

            for (int i = 0; i < jaren; i++)
            {
                double roundedBedrag = Math.Round(bedrag, 2);
                lbResult.Items.Add($"Na {i + 1} jaar is het bedrag {roundedBedrag} euro");

                bedrag *= (1 + 0.01 * rente);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void ResetAll()
        {
            bedrag = 0;
            rente = 0;
            jaren = 0;

            txtBedrag.Text = "";
            txtRente.Text = "";
            txtJaar.Text = "";

            lbResult.Items.Clear();
        }
    }
}
