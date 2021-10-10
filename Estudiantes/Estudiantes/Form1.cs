using Estudiantes.Data;
using Estudiantes.Negocio;
using Estudiantes.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            estudiante es = new estudiante();

            es.nombresEstudiante = textBox1.Text;
            es.apellidos = textBox2.Text;
            es.usuario = textBox3.Text;

            ClsEstudiantes clsEstudiantes = new ClsEstudiantes();
            clsEstudiantes.Guardar(es);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();

            materia.Show();
        }
    }
}
