using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Admin : Usuario
    {
        public Admin(string gmail, string nombre, string apellido, int dni, string pass) : base(gmail, nombre, apellido, dni, pass)
        {

        }
        public Admin() :base()
        { }
        public override EPermisos Permisos
        {
            get
            {
                return EPermisos.Admin;
            }

        }
    }
}