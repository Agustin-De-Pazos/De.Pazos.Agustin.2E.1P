using System;
using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public class Profesor : Usuario
    {
        private List<Examen> _examenes;

        public Profesor(string gmail, string nombre, string apellido, int dni, string pass) : base(gmail, nombre, apellido, dni, pass)
        {
            _examenes = new List<Examen>();
        }

        public override EPermisos Permisos
        {
            get
            {
                return EPermisos.Profesor;
            }

        }
        public bool NuevoExamen(DateTime fecha, string nombre, string Unamateria)
        {
            bool todoOk = false;
            if (fecha >= DateTime.Now && nombre is not null && Unamateria is not null)
            {
                Examen nuevoExamen = new Examen(fecha, nombre, Unamateria);
                _examenes.Add(nuevoExamen);
                todoOk = true;
            }
            return todoOk;
        }
        public List<Examen> ListaExamen()
        {
            return _examenes.ToList();
        }
        public static string CierreDeNotas(string nombreMateria, string nombreAlumno, int primerNota, int segundaNota)
        {
            string mensaje = null;
            Alumno unAlumno;
            Materia unaMateria;
            MateriaCursada materiaEnCurso;
            if (nombreMateria is not null && nombreAlumno is not null)
            {
                List<Alumno> alumnoList = DataBase.GetListAlumnos();
                unaMateria = DataBase.GetUnaMateria(nombreMateria);

                unAlumno = DataBase.GetAlumnoStringNombreApellido(alumnoList, nombreAlumno);

                if (unAlumno is not null)
                {
                    materiaEnCurso = unAlumno.GetMateriaCursada(nombreMateria);

                    if (materiaEnCurso.Regularidad == eRegularidad.Regular)
                    {
                        if (materiaEnCurso.Asistencia == eAsistencia.Presente)
                        {
                            if (primerNota > 6 && segundaNota > 6)
                            {
                                _ = unaMateria - unAlumno;
                                materiaEnCurso.Estado = eEstadoCursada.Aprobo;
                                materiaEnCurso.NotaPrimerParcial = primerNota;
                                materiaEnCurso.NotaSegundoParcial = segundaNota;
                                mensaje = "Calificado exitosamente (Aprobo)";
                                materiaEnCurso.NotaFinal = CalcularPromedio(primerNota, segundaNota);

                            }
                            else
                            {
                                _ = unaMateria - unAlumno;
                                materiaEnCurso.Estado = eEstadoCursada.Desaprobo;
                                materiaEnCurso.NotaPrimerParcial = primerNota;
                                materiaEnCurso.NotaSegundoParcial = segundaNota;
                                mensaje = "Calificado exitosamente (Desaprobo)";
                                materiaEnCurso.NotaFinal = CalcularPromedio(primerNota, segundaNota);
                            }
                        }
                        else
                        {
                            _ = unaMateria - unAlumno;
                            materiaEnCurso.Estado = eEstadoCursada.Desaprobo;
                            materiaEnCurso.Regularidad = eRegularidad.Libre;
                            materiaEnCurso.NotaPrimerParcial = primerNota;
                            materiaEnCurso.NotaSegundoParcial = segundaNota;
                            mensaje = "Desaprobo: quedo libre";
                            materiaEnCurso.NotaFinal = CalcularPromedio(primerNota, segundaNota);
                        }

                    }
                    else
                    {
                        _ = unaMateria - unAlumno;
                        materiaEnCurso.Estado = eEstadoCursada.Desaprobo;
                        materiaEnCurso.NotaPrimerParcial = primerNota;
                        materiaEnCurso.NotaSegundoParcial = segundaNota;
                        mensaje = "Desaprobo: quedo libre";
                        materiaEnCurso.NotaFinal = CalcularPromedio(primerNota, segundaNota);
                    }
                }

            }
            else
            {
                mensaje = "Datos mal ingresados";
            }
            return mensaje;
        }
            


        public override string ToString()
        {
            return Nombre;
        }
        public static int CalcularPromedio(int n1,int n2)
        {
            int promedio = 0;
            int total;
            total = n1 + n2;
            if(total != 0)
            {
                promedio = total /2;
            }
            return promedio;
        }
    }
}
