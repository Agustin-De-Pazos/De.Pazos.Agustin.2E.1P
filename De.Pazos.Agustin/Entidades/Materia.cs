using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        private string nombre;
        private int cuatrimestre;
        private Profesor profesor;
        private List<Alumno> alumnos;
        private string correlativas;
        private EStadoProfe estado;

        public Materia()
        {
            alumnos = new List<Alumno>();
        }

        public Materia(string nombre, int cuatrimestre, Profesor profesor, string correlativas, EStadoProfe estado) :this()
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            this.profesor = profesor;
            this.correlativas = correlativas;
            this.estado = estado;
        }


        public Materia(string nombre, int cuatrimestre,EStadoProfe estado):this()
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            this.estado = estado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public EStadoProfe Estado { get => estado; set => estado = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }

        public static bool operator +(Materia m, Alumno a)
        {
            bool todOk = false;
            if(!(m == a) || a.CantidadMateriasC < 2)
            {
                m.alumnos.Add(a);
                a.MateriasCursadas[a.CantidadMateriasC] = m.Nombre.ToString();
                a.CantidadMateriasC++;
                todOk = true;
            }
            return todOk;
        }

        public static bool operator ==(Materia m, Alumno a)
        {
            bool ok = false;

            foreach (var item in m.alumnos)
            {
                if(item.Gmail == a.Gmail)
                {
                    ok = true;
                }
            }
            return ok;
        }

        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }

        public static bool Verificar(List<Materia> m, string texto)
        {
            bool todOk = true;
            foreach (Materia item in m)
            {
                if(item.Nombre == texto)
                {
                    todOk = false;
                }
            }
            return todOk;
        }

        public override string ToString()
        {
            return ToString();
        }

    }
}
