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
    public partial class Form1 : Form
    {
        public List<Estudiantes> listEstudents = new List<Estudiantes>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviarregistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensaje1.Text) || string.IsNullOrEmpty(txtMensaje2.Text) || string.IsNullOrEmpty(txtMensaje3.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                int id = int.Parse(txtMensaje1.Text);
                string nombre = txtMensaje2.Text;
                string apellidos = txtMensaje3.Text;
                listEstudents.Add(new Estudiantes() { 
                
                        ID = id, Nombres = nombre, Apellidos = apellidos
                });
                MessageBox.Show("Su registro  fue agregado con exito");
                txtMensaje1.Clear();
                txtMensaje2.Clear();
                txtMensaje3.Clear();
            }
        }

        private void btnEnviardatos_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (listEstudents.Count > 0)
            {
                //enviar los datos
                f2.listEstudents = this.listEstudents;
                f2.Show();
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un registro");
            }
        }
    }
}
