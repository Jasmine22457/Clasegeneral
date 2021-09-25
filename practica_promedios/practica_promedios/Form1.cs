using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica_promedios.Entidades;
using practica_promedios.Negocio;

namespace practica_promedios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        notas prom = new notas();
        private void bonton1_Click(object sender, EventArgs e)
        {

            prom.Laboratorio1 = double.Parse(textBox1.Text);
            prom.Parcial01 = double.Parse(textBox2.Text);
            prom.Laboratorio02 = double.Parse(textBox3.Text);
            prom.Parcial02 = double.Parse(textBox4.Text);
            prom.Laboratorio03 = double.Parse(textBox5.Text);
            prom.Parcial03 = double.Parse(textBox6.Text);

            NClsPropiedades val1 = new NClsPropiedades();

            MessageBox.Show(val1.promedioos(prom));
            

          



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
