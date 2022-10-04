using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Usuario
    {
        private Dictionary<string, DateTime> examen;

        public Profesor(string gmail, string nombre, string apellido, int dni) : base(gmail, nombre, apellido, dni)
        {
            this.examen = new Dictionary<string, DateTime>();
        }
        public Profesor():base()
        { }
        public override EPermisos Permisos
        {
            get
            {
                return EPermisos.Profesor;
            }

        }
    }
}
