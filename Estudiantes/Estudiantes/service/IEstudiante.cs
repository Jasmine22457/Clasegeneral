using Estudiantes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Repository
{
    interface IEstudiante
    {

        //CRUD

        //c 

        void Create(estudiante estudiante);


        //D

        void Delete(estudiante estudiante);
    }
}
