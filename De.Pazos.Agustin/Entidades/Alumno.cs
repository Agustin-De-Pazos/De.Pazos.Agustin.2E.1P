using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Usuario
    {
        private int cantidadMateriasC;
        private int[] nota= {0,0};
        private EStadoAlumno[] estado;
        public Dictionary<string, int> materiasCulminadas;
        private int[] asistencia = {0,0};
        private string[] materiasCursadas = {"",""};


        public Alumno():base()
        {
        }
        //public Alumno(string gmail, string nombre, string apellido, int dni) : this(gmail, nombre, apellido, dni)
        //{ }

        public Alumno(string gmail, string nombre, string apellido, int dni) : base(gmail, nombre, apellido, dni)
        {
            this.cantidadMateriasC = 0;
            estado = new EStadoAlumno[2];
            materiasCulminadas = new Dictionary<string, int>();
        }
        public override EPermisos Permisos
        {
            get
            {
                return EPermisos.Alumno;
            }

        }

        public int[] Nota { get => nota; set => nota = value; }
        public string[] MateriasCursadas { get => materiasCursadas; set => materiasCursadas = value; }
        public int CantidadMateriasC { get => cantidadMateriasC; set => cantidadMateriasC = value; }
        public EStadoAlumno[] Estado { get => estado; set => estado = value; }
        public int[] Asistencia { get => asistencia; set => asistencia = value; }

        public static bool MateriasYmateriasRegistradas(Alumno alumno ,string texto)
        {
            bool todOk = false;
            foreach (string item in alumno.materiasCursadas)
            {
                if(item == texto)
                {
                    todOk = true;
                }
            }

            return todOk;
        }
        public static string RetornaMateriaIgualada(Alumno alumno, string texto)
        {
            string aux = "Null";
            foreach (string item in alumno.materiasCursadas)
            {
                if (item == texto)
                {
                    aux = item;
                }
            }
            return aux;
        }

        public static bool RetornaSiLaMateriaYaFueTerminada(Alumno a, string texto)
        {
            bool todOk = false;
            if(texto != null)
            {
                foreach (KeyValuePair<string,int> item in a.materiasCulminadas)
                {
                    if(texto == item.Key || item.Value < 6)
                    {
                        todOk = true;
                    }
                }
            }
            return todOk;
        }
    }
}

