using Estudiantes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Repository
{
    class ClsRMateria : IMateria
    {
        public void Create(materia materia)
        {

            using (EstudiantessEntities conxionBD = new EstudiantessEntities())
            {


                try
                {
                    materia mat = new materia();

                    mat.nombreMateria = materia.nombreMateria;

                    conxionBD.materia.Add(mat);
                    conxionBD.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error en el ingreso a la base de datos" + ex);




                }
            }



        }

        public void Delete(materia materia)
        {
           
        }
    }
}
