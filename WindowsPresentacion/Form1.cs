using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado("A12", "Pedro", "Gomez");
            MessageBox.Show("Comision: " + Empleado.Comision);
            Empleado empleado2 = new Empleado("A18", "Maria", "Castanio");
            Empleado.Comision = 25;
            MessageBox.Show("Comision: " + Empleado.Comision);
        }
    }
}
