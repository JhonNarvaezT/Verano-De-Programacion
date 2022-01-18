using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double metros;

            metros = double.Parse(this.textmetros.Text);

            double centimetros = metros * 100;
            double pulgadas = centimetros/2.54;
            double pies = pulgadas / 12;
            double yardas= pies/3;

            lstR.Items.Add("Resumen de conversiones");
            lstR.Items.Add("Medida en metros" +metros.ToString("0.00"));
            lstR.Items.Add("____________________________________________");
            lstR.Items.Add("Medida en metros" + centimetros.ToString("0.00"));
            lstR.Items.Add("Medida en pulgadas" + pulgadas.ToString("0.00"));
            lstR.Items.Add("Medida en pies" + pies.ToString("0.00"));
            lstR.Items.Add("Medida en yardas" + yardas.ToString("0.00"));
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            textmetros.Clear();
            lstR.Items.Clear();
            textmetros.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro de salir?", "Medidas", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes) this.Close();
        }

        private void Textmetros_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void BtnCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToUInt32(e.KeyChar) == 13)
            {
                btnLimpiar.Focus();
            }
        }
    }
}
