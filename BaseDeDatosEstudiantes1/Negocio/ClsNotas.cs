using BaseDeDatosEstudiantes1.Data;
using BaseDeDatosEstudiantes1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosEstudiantes1.Negocio
{
    class ClsNotas :ClsRNotas
    {
        public void Guardar(notas notas)
        {

            create(notas);

        }

        
    }
}
