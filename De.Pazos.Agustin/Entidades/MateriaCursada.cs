using System.Collections.Generic;
using System.Data.Common;

namespace Entidades
{
    public class MateriaCursada
    {
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private int _notaFinal;
        private eAsistencia _asistencia;
        private eEstadoCursada _estado;
        private eRegularidad _regularidad;

        public MateriaCursada(string nombre, int notaPrimerParcial, int notaSegundoParcial,  eAsistencia asistencia, eEstadoCursada estado, eRegularidad regularidad)
                              : this(nombre, estado, eRegularidad.Regular)
        {
            _notaPrimerParcial = notaPrimerParcial;
            _notaSegundoParcial = notaSegundoParcial;;
            _asistencia = asistencia;
        }

        public MateriaCursada(string nombre, eEstadoCursada estado, eRegularidad regularidad)
        {
            _nombre = nombre;
            _estado = estado;
            _regularidad = regularidad;
            _asistencia = eAsistencia.Ausente;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int NotaPrimerParcial { get => _notaPrimerParcial; set => _notaPrimerParcial = value; }
        public int NotaSegundoParcial { get => _notaSegundoParcial; set => _notaSegundoParcial = value; }
        public eAsistencia Asistencia { get => _asistencia; set => _asistencia = value; }
        public eEstadoCursada Estado { get => _estado; set => _estado = value; }
        public eRegularidad Regularidad { get => _regularidad; set => _regularidad = value; }
        public int NotaFinal { get => _notaFinal; set => _notaFinal = value; }

        public static eRegularidad StringRegularidad(string regularidad)
        {
            eRegularidad tipoCuatrimestre = eRegularidad.Regular;
            if (regularidad == "Libre")
            {
                tipoCuatrimestre = eRegularidad.Libre;
            }
            return tipoCuatrimestre;
        }

    }
}
