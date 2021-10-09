using BaseDeDatosEstudiantes1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatosEstudiantes1.Service
{
    interface IEstudiantes
    {

        //CRUD

        //C
        void create(estudiante estudiante);

        //D
        void Delete(estudiante estudiante);
    
    }
}
