using Estudiantes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Repository
{
    interface INotas
    {
        void Create(notas notas);


        void Delete(notas notas);

    }
}
