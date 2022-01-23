using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap4
{
    public partial class FrmMultas : Form
    {
        ListViewItem item;
        public FrmMultas()
        {
            InitializeComponent();
        }

        private void FrmMultas_Load(object sender, EventArgs e)
        {
            lblFecha.Text=DateTime.Today.ToShortDateString();
            lblHora.Text=DateTime.Now.ToShortTimeString();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String Placa = txtPlaca.Text;
            double Velocidad = double.Parse(txtVelocidad.Text);
            DateTime Fecha = DateTime.Parse(lblFecha.Text);
            DateTime Hora = DateTime.Parse(lblHora.Text);

            double Multa = 0;
            if (Velocidad<=70)
                Multa=0;
            else if (Velocidad >70 && Velocidad <=90)
                Multa=120;
            else if (Velocidad>90 && Velocidad <=100)
                Multa=320;
            else if (Velocidad>100)
                Multa=500;

            ListViewItem Fila = new ListViewItem(Placa);
            Fila.SubItems.Add(lblHora.Text);
            Fila.SubItems.Add(lblFecha.Text);
            Fila.SubItems.Add(Velocidad.ToString("0.00"));
            Fila.SubItems.Add(Multa.ToString(".00"));
            lvMultas.Items.Add(Fila);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (item != null)
            {
                lvMultas.Items.Remove(item);
                MessageBox.Show("Su multa ha sido eliminada exitosamente....!!!");
            }else
            {
                MessageBox.Show("Debe seleccionar una multa de la lista");
            }
        }

        private void lvMultas_MouseClick(object sender, MouseEventArgs e)
        {
            item= lvMultas.GetItemAt(e.X, e.Y);
        }
    }
}
