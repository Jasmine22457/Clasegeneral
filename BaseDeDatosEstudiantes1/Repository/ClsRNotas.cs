using BaseDeDatosEstudiantes1.Data;
using BaseDeDatosEstudiantes1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatosEstudiantes1.Repository
{
    class ClsRNotas : INotas

    {
        public void create(notas notas)
        {
            using (EstudiantessEntities conxionBD = new EstudiantessEntities())
            {

                try {

                    notas not = new notas();

                    not.estudiante= not.estudiante;
                    not.materia = not.materia;
                    not.nota = not.nota;

                    conxionBD.notas.Add(not);
                    conxionBD.SaveChanges();




                }
                catch (Exception ex)
                {


                    MessageBox.Show("Error en el ingreso a la base de datos" + ex);

                }



            }   


        }
    }
}
