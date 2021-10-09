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
    class ClsREstudiante : IEstudiantes
    {
        public void create(estudiante estudiante)
        {
           
            using (EstudiantessEntities  conxionBD = new EstudiantessEntities())
            {
                
                try {

                    estudiante est = new estudiante();
                    est.nombresEstudiante = estudiante.nombresEstudiante;
                    est.apellidos = estudiante.apellidos;
                    est.usuario = estudiante.usuario;
                    est.contrasenia = estudiante.contrasenia;

                    conxionBD.estudiante.Add(est);
                    conxionBD.SaveChanges();


                } catch(Exception ex)
                {
                    MessageBox.Show("Error en el ingreso a la base de datos" + ex);
                }


            }
        }

        public void Delete(estudiante estudiante)
        {
           
        }
    }
}
