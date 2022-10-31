using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Examen
    {
        private DateTime _fecha;
        private string _nombre;
        private string _materia;

        public Examen(DateTime fecha, string nombre, string materia)
        {
            _fecha = fecha;
            _nombre = nombre;
            _materia = materia;
        }

        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Materia { get => _materia; set => _materia = value; }
    }
}
