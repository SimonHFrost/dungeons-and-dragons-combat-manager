using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBoxFinal.Text = "";
            textBoxNumberOfPlayers.Text = "";
            textBoxTotalXp.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            int players = Convert.ToInt16(textBoxNumberOfPlayers.Text);
            int totalxp = Convert.ToInt16(textBoxTotalXp.Text);
            double xp = totalxp / players;

            xp = Math.Floor(randomize(xp));

            textBoxFinal.Text = Convert.ToString(xp);
        }

        private double randomize(double number)
        {
            Random prng = new Random();
            double addition = prng.NextDouble() * (0.2 * number);
            if(prng.NextDouble() > 0.5) { addition = -addition; }
            return number + addition;
        }
    }
}
