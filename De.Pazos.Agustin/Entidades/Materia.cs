using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Materia
    {
        private string nombre;
        private ECuatrimestre cuatrimestre;
        private Profesor profesor;
        private List<Alumno> alumnos;
        private string correlativas;
        private EStadoProfe estado;



        public Materia()
        {
            alumnos = new List<Alumno>();
        }
        public Materia(string nombre, ECuatrimestre cuatrimestre) : this()
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            this.estado = EStadoProfe.Libre;
            this.correlativas = "No";
        }

        public Materia(string nombre, ECuatrimestre cuatrimestre, Profesor profesor, string correlativas, EStadoProfe estado) : this()
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            this.profesor = profesor;
            this.correlativas = correlativas;
            this.estado = estado;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public ECuatrimestre Cuatrimestre { get => cuatrimestre; set => cuatrimestre = value; }
        public Profesor Profesor { get => profesor; set => profesor = value; }

        public string Correlativas { get => correlativas; set => correlativas = value; }
        public EStadoProfe Estado { get => estado; set => estado = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }

        //public Materia(string nombre, ECuatrimestre cuatrimestre,EStadoProfe estado):this()
        //{
        //    this.nombre = nombre;
        //    this.cuatrimestre = cuatrimestre;
        //    this.estado = estado;
        //} 
       



        public static bool operator +(Materia m, Alumno a)
        {
            bool todOk = false;
            if (!(m == a) && a.CantidadMateriasEncurso < 2)
            {
                m.alumnos.Add(a);
                a.CantidadMateriasEncurso++;
                todOk = true;
            }
            return todOk;
        }
        public static bool operator -(Materia m, Alumno a)
        {
            bool todOk = false;
            if (m == a && a.CantidadMateriasEncurso > 0)
            {
                m.alumnos.Remove(a);
                a.CantidadMateriasEncurso--;
                todOk = true;
            }
            return todOk;
        }

        public static bool operator ==(Materia m, Alumno a)
        {
            bool ok = false;
            foreach (Alumno item in m.alumnos)
            {
                if (item == a)
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }
        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }

        public static List<Alumno> GetListaAlumno(Materia unaMateria)
        {
            List<Alumno> listaAlumno = new List<Alumno>();
            if (unaMateria.alumnos is not null)
            {
                listaAlumno = unaMateria.alumnos.ToList();
            }
            return listaAlumno;
        }
    }
}
