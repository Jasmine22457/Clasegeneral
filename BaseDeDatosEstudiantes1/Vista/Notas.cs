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

namespace BaseDeDatosEstudiantes1.Vista
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            notas not = new notas();

            not.idEstudiante = int.Parse(textBox01.Text);
            not.idMateria = int.Parse(textBox02.Text);
            not.idNotas = int.Parse(textBox03.Text);

            ClsNotas cls = new ClsNotas();
            cls.Guardar(not);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
