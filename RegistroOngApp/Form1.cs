using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroOngApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbRol1.Items.Add("Voluntario");
            cmbRol1.Items.Add("Coordinador");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbRol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string rol = cmbRol1.SelectedItem?.ToString();

            MessageBox.Show($"Nombre: {nombre} - Rol: {rol}");
        }
    }
}
