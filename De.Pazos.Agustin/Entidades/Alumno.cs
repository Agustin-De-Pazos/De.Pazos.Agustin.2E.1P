using System.Collections.Generic;

namespace Entidades
{
    public class Alumno : Usuario
    {
        private List<MateriaCursada> _materiasCursadas;
        private int _cantidadMateriasEncurso;



        public Alumno(string gmail, string nombre, string apellido, int dni, string pass) : base(gmail, nombre, apellido, dni, pass)
        {
            _materiasCursadas = new List<MateriaCursada>();
            _cantidadMateriasEncurso = 0;
        }
        public override EPermisos Permisos
        {
            get
            {
                return EPermisos.Alumno;
            }

        }

        public int CantidadMateriasEncurso { get => _cantidadMateriasEncurso; set => _cantidadMateriasEncurso = value; }
        public List<MateriaCursada> MateriasCursadas { get => _materiasCursadas; set => _materiasCursadas = value; }

        public static bool CambiarEstado(Alumno unAlumno, eRegularidad regularidad, string nombreMateria)
        {
            bool todoOk = false;
            foreach (MateriaCursada item in unAlumno._materiasCursadas)
            {
                if (item.Nombre == nombreMateria && item.Estado == eEstadoCursada.Cursando)
                {
                    todoOk = true;
                    item.Regularidad = regularidad;
                }
            }
            return todoOk;
        }


        public void HarcodearAlumnos(MateriaCursada m)
        {
            this._materiasCursadas.Add(m);
        }

        public List<MateriaCursada> GetMateriasCursada()
        {
            return _materiasCursadas;
        }

        public static string InscribirseMateria(Alumno unAlumno, string nombreMateria)
        {
            string mensaje = null;
            Materia unaMateria;
            unaMateria = DataBase.GetMateria(nombreMateria);
      
            if (nombreMateria is not null)
            {
                if (!(unaMateria == unAlumno))
                {
                    if (unaMateria.Correlativas != "No")
                    {
                        foreach (MateriaCursada item in unAlumno._materiasCursadas)
                        {
                            if (item.Estado == eEstadoCursada.Aprobo && item.Nombre == unaMateria.Nombre)
                            {
                                mensaje = $"Aprobo la materia con: {unaMateria.Profesor.Nombre}";
                            }
                            if (item.Estado == eEstadoCursada.Aprobo && item.Nombre == unaMateria.Correlativas)
                            {
                                if(AddMateriaListAlumnoAddMateriaCursando(unaMateria, unAlumno, nombreMateria))
                                {
                                    mensaje = "Materia inscripta";
                                }
                            }
                            else
                            {
                                mensaje = "No aprobo la correlativa";
                            }
                        }
                    }
                    else
                    {
                        if(!unAlumno.AproboMateria(nombreMateria))
                        {
                            if (AddMateriaListAlumnoAddMateriaCursando(unaMateria, unAlumno, nombreMateria))
                            {
                                mensaje = "Materia inscripta";
                            }
                            else
                            {
                                mensaje = "Ya tiene 2 materias simultaneas";
                            }
                        }
                        else
                        {
                            mensaje = "Aprobo Materia";
                        }
                    }
                }
                else
                {
                    mensaje = "Ya esta inscripto";
                }
            }
            return mensaje;
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            bool ok = false;
            if (a1.Gmail == a2.Gmail)
            {
                ok = true;
            }
            return ok;
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        public MateriaCursada GetMateriaCursada(string unaMateria)
        {
            MateriaCursada aux = null;
            if (unaMateria is not null)
            {
                foreach (MateriaCursada item in _materiasCursadas)
                {
                    if (item.Estado == eEstadoCursada.Cursando && item.Nombre == unaMateria)
                    {
                        aux = item;
                        break;
                    }
                }
            }
            return aux;
        }
        
        public List<MateriaCursada> GetListMateriasCursadas()
        {
            return _materiasCursadas;
        }
        public bool DarAsistencia(string nombreMateria)
        {
            bool todoOk = false;
            MateriaCursada materiaCursada;
            materiaCursada = GetMateriaCursada(nombreMateria);
            if (materiaCursada is not null)
            {
                materiaCursada.Asistencia = eAsistencia.Presente;
                todoOk = true;
            }
            return todoOk;
        }

        public static bool AddMateriaListAlumnoAddMateriaCursando(Materia unaMateria, Alumno unAlumno,  string nombreMateria)
        {
            MateriaCursada aux;
            bool todoOk = false;
            if (unaMateria + unAlumno)
            {
                aux = new(nombreMateria, eEstadoCursada.Cursando, eRegularidad.Regular);
                unAlumno._materiasCursadas.Add(aux);
                todoOk = true;
            }
            return todoOk;
        }

        public bool AproboMateria(string nombreMateria)
        {
            bool todoOk = false;
            foreach (MateriaCursada item in _materiasCursadas)
            {
                if (item.Estado == eEstadoCursada.Aprobo && item.Nombre == nombreMateria)
                {
                    todoOk = true;
                    break;
                }
            }
            return todoOk;
        }
    }

}

