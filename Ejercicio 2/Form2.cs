using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form2 : Form
    {

        public List<Estudiantes> listEstudents = new List<Estudiantes>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgdDatos.DataSource = listEstudents;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargardatos_Click(object sender, EventArgs e)
        {
            txtMensaje1.Text = dgdDatos.CurrentRow.Cells[0].Value.ToString();
            txtMensaje2.Text = dgdDatos.CurrentRow.Cells[1].Value.ToString();
            txtMensaje3.Text = dgdDatos.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
