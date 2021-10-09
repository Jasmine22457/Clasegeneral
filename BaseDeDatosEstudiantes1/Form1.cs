using BaseDeDatosEstudiantes1.Data;
using BaseDeDatosEstudiantes1.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatosEstudiantes1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            estudiante es = new estudiante();

            es.nombresEstudiante = textBox1.Text;
            es.apellidos = textBox2.Text;
            es.usuario = textBox3.Text;
            es.contrasenia = textBox4.Text;

            ClsEstudiante clsEstudiante = new ClsEstudiante();
            clsEstudiante.Guardar(es);

            
        }
    }
}
