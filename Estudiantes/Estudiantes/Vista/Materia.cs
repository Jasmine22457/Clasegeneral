using Estudiantes.Data;
using Estudiantes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Vista
{
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            materia mat = new materia();

            mat.nombreMateria = textBox1.Text;
            ClsMateria clsMateria = new ClsMateria();
            clsMateria.Guardar(mat);
        }
    }
}
