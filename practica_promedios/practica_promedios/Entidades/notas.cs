using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_promedios.Entidades
{
    class notas
    {
        private double laboratorio1;
        private double parcial01;
        private double promedio01;
        private double laboratorio02;
        private double parcial02;
        private double promedio02;
        private double laboratorio03;
        private double parcial03;
        private double promedi03;
        private double nota_final;
       

        public notas()
        {
        }

        

        public double Laboratorio1 { get => laboratorio1; set => laboratorio1 = value; }
        public double Parcial01 { get => parcial01; set => parcial01 = value; }
        public double Promedio01 { get => promedio01; set => promedio01 = value; }
        public double Laboratorio02 { get => laboratorio02; set => laboratorio02 = value; }
        public double Parcial02 { get => parcial02; set => parcial02 = value; }
        public double Promedio02 { get => promedio02; set => promedio02 = value; }
        public double Laboratorio03 { get => laboratorio03; set => laboratorio03 = value; }
        public double Parcial03 { get => parcial03; set => parcial03 = value; }
        public double Promedi03 { get => promedi03; set => promedi03 = value; }
        public double Nota_final { get => nota_final; set => nota_final = value; }
    }
}
