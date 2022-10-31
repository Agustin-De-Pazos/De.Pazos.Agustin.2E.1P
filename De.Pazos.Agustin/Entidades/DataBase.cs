using System.Collections.Generic;

namespace Entidades
{
    public class DataBase
    {
        static Dictionary<string, Usuario> _usuarios;
        static Dictionary<string, Materia> _materias;

        static DataBase()
        {
            _usuarios = new Dictionary<string, Usuario>();
            _materias = new Dictionary<string, Materia>();
            HardcodearDatos();
        }

        public static void HardcodearDatos()
        {
            Profesor prof1 = new Profesor("profesor@gmail.com", "Eustacio", "3", 1, "profesor");
            Profesor prof2 = new Profesor("profesor2@gmail.com", "Enricke", "3", 1, "profesor2");
            Profesor prof3 = new Profesor("profesor3@gmail.com", "Soledad", "3", 1, "profesor3");
            Profesor prof4 = new Profesor("profesor4@gmail.com", "Esteban", "FAFA", 1, "profesor4");
            Admin admin = new Admin("admin@gmail.com", "admin1", "3", 1, "admin");
            Alumno alumno1 = new Alumno("alumno1@gmail.com", "ernesto", "3", 1, "alumno1");
            Alumno alumno2 = new Alumno("alumno2@gmail.com", "caballines", "3", 1, "alumno2");
            Alumno alumno3 = new Alumno("alumno3@gmail.com", "cesar", "oscuro", 1, "alumno3");
            Alumno alumno4 = new Alumno("alumno4@gmail.com", "Roberto", "Fev", 1, "alumno4");
            Alumno alumno5 = new Alumno("alumno5@gmail.com", "Pepe", "Bas", 1, "alumno5");
            _usuarios.Add("profesor@gmail.com", prof1);
            _usuarios.Add("profesor2@gmail.com", prof2);
            _usuarios.Add("profesor3@gmail.com", prof3);
            _usuarios.Add("profesor4@gmail.com", prof4);
            _usuarios.Add("admin@gmail.com", admin);
            _usuarios.Add("alumno1@gmail.com", alumno1);
            _usuarios.Add("alumno2@gmail.com", alumno2);
            _usuarios.Add("alumno3@gmail.com", alumno3);
            _usuarios.Add("alumno4@gmail.com", alumno4);
            _usuarios.Add("alumno5@gmail.com", alumno5);

            Materia laboratorio1 = new Materia("Laboratorio 1", ECuatrimestre.Primero, prof1, "No", EStadoProfe.Ocupado);
            Materia laboratorio2 = new Materia("Laboratorio 2", ECuatrimestre.Segundo, prof1, "Laboratorio 1", EStadoProfe.Ocupado);
            Materia ingles1 = new Materia("Ingles 1", ECuatrimestre.Primero, prof1, "No", EStadoProfe.Ocupado);
            Materia ingles2 = new Materia("Ingles 2", ECuatrimestre.Segundo, prof1, "Ingles 1", EStadoProfe.Ocupado);
            Materia matematica1 = new Materia("Matematica 1", ECuatrimestre.Primero, prof1, "No", EStadoProfe.Ocupado);
            Materia matematica2 = new Materia("Matematica 2", ECuatrimestre.Segundo, prof1, "Matematica 2", EStadoProfe.Ocupado);



            Materia materia1 = new Materia("testmat1", ECuatrimestre.Primero);
            Materia materia2 = new Materia("testmat2", ECuatrimestre.Primero);
            Materia materia3 = new Materia("testmat3", ECuatrimestre.Segundo);
            _materias.Add("laboratorio 1", laboratorio1);
            _materias.Add("laboratorio 2", laboratorio2);
            _materias.Add("Matematica 1", matematica1);
            _materias.Add("Matematica 2", matematica2);
            _materias.Add("Ingles 1", ingles1);
            _materias.Add("Ingles 2", ingles2);


            _materias.Add("testmat1", materia1);
            _materias.Add("testmat2", materia2);
            _materias.Add("testmat3", materia3);

            _ = matematica1 + alumno1;
            _ = matematica1 + alumno2;
            _ = matematica1 + alumno3;
            _ = matematica1 + alumno4;


            MateriaCursada m1 = new MateriaCursada("Matematica 1", eEstadoCursada.Cursando, eRegularidad.Regular);
            MateriaCursada m2 = new MateriaCursada("Matematica 1", eEstadoCursada.Cursando, eRegularidad.Regular);
            MateriaCursada m3 = new MateriaCursada("Matematica 1", eEstadoCursada.Cursando, eRegularidad.Regular);
            MateriaCursada m4 = new MateriaCursada("Matematica 1", eEstadoCursada.Cursando, eRegularidad.Regular);

            alumno1.HarcodearAlumnos(m1);
            alumno2.HarcodearAlumnos(m2);
            alumno3.HarcodearAlumnos(m3);
            alumno4.HarcodearAlumnos(m4);
        }


        public static Usuario ValidarUsuario(string usuario, string pass)
        {
            Usuario aux = null;
            if (usuario is not null && pass is not null)
            {
                if (_usuarios.TryGetValue(usuario, out aux))
                {
                    if (!(aux.VerificarPass(pass)))
                    {
                        aux = null;
                    }
                }
            }
            return aux;
        }


        public static bool DniNoExisteString(string dni)
        {
            bool todOk = true;
            int aux;
            if (int.TryParse(dni, out aux))
            {
                if (DniNoExistente(aux))
                {
                    return false;
                }
            }
            return todOk;
        }

        public static bool DniNoExistente(int dni)
        {
            bool todOk = true;
            foreach (KeyValuePair<string, Usuario> item in _usuarios)
            {
                if (item.Value.Dni == dni)
                {
                    todOk = false;
                    break;
                }
            }
            return todOk;
        }

        public static bool GmailNoExiste(string texto)
        {
            bool todOk = true;
            foreach (KeyValuePair<string, Usuario> item in _usuarios)
            {
                if (item.Value.Gmail == texto)
                {
                    todOk = false;
                    break;
                }
            }
            return todOk;
        }
        public static bool UsuariosAdminAdd(string permisos, string nombre, string gmail, int dni, string pass, string apellido)
        {
            bool todOk = true;
            switch (permisos)
            {
                case "Admin":
                    Admin NuevoAdmin = new Admin(gmail, nombre, apellido, dni, pass);
                    _usuarios.Add(gmail, NuevoAdmin);
                    break;
                case "Profesor":
                    Profesor NuevoProfesor = new Profesor(gmail, nombre, apellido, dni, pass);
                    _usuarios.Add(gmail, NuevoProfesor);
                    break;
                case "Alumno":
                    Alumno NuevoAlumno = new Alumno(gmail, nombre, apellido, dni, pass);
                    _usuarios.Add(gmail, NuevoAlumno);
                    break;
                default:
                    todOk = false;
                    break;

            }
            return todOk;
        }
        public static bool AddMateria(Materia materia)
        {
            bool todoOk = false;
            if (materia != null)
            {
                _materias.Add(materia.Nombre, materia);
                todoOk = true;
            }
            return todoOk;
        }

        public static bool NewMateria(string nombre, ECuatrimestre cuatrimestre)
        {
            bool todoOk = false;
            if (nombre is not null)
            {
                if (!_materias.ContainsKey(nombre))
                {
                    Materia materia = new Materia(nombre, cuatrimestre);
                    _materias.Add(nombre, materia);
                    todoOk = true;
                }
            }
            return todoOk;
        }
        public static ECuatrimestre StringAECUastrimestre(string cuatrimestre)
        {
            ECuatrimestre tipoCuatrimestre = ECuatrimestre.Segundo;
            if (cuatrimestre == "Primero")
            {
                tipoCuatrimestre = ECuatrimestre.Primero;
            }
            return tipoCuatrimestre;
        }

        public static Materia GetMateria(string nombre)
        {
            Materia unaMateria = null;
            if (nombre != null)
            {
                foreach (KeyValuePair<string, Materia> item in _materias)
                {
                    if (item.Value.Nombre == nombre)
                    {
                        unaMateria = item.Value;
                    }
                }
            }
            return unaMateria;
        }

        public static int AsignarProfeMateria(Materia unaMateria, string nombreMasApellido)
        {
            int todoOk = 0;
            List<Profesor> listaProfesores = GetListaProfes();
            Profesor aux = null;
            if (unaMateria.Estado == EStadoProfe.Libre)
            {
                aux = (Profesor)GetProfesorStringNombreApellido(listaProfesores, nombreMasApellido);
                if (aux is not null)
                {
                    _materias[unaMateria.Nombre].Estado = EStadoProfe.Ocupado;
                    _materias[unaMateria.Nombre].Profesor = aux;
                    todoOk = 1;
                }
            }
            else
            {
                todoOk = -1;
            }
            return todoOk;
        }

        public static List<Profesor> GetListaProfes()
        {
            List<Profesor> profesorList = new List<Profesor>();
            foreach (KeyValuePair<string, Usuario> item in _usuarios)
            {
                if (item.Value.Permisos == EPermisos.Profesor)
                {
                    profesorList.Add((Profesor)item.Value);
                }
            }
            return profesorList;
        }
        public static List<Materia> GetListaMaterias()
        {
            List<Materia> materiasList = new List<Materia>();
            foreach (KeyValuePair<string, Materia> item in _materias)
            {
                materiasList.Add(item.Value);
            }
            return materiasList;
        }
        public static List<Alumno> GetListAlumnos()
        {
            List<Alumno> profesorList = new List<Alumno>();
            foreach (KeyValuePair<string, Usuario> item in _usuarios)
            {
                if (item.Value.Permisos == EPermisos.Alumno)
                {
                    profesorList.Add((Alumno)item.Value);
                }
            }
            return profesorList;
        }
        public static List<Materia> GetListaMateriaEstadoLibreP()
        {
            List<Materia> listaMaterias = new List<Materia>();
            foreach (KeyValuePair<string, Materia> item in _materias)
            {
                if (item.Value.Estado == EStadoProfe.Libre)
                {
                    listaMaterias.Add(item.Value);
                }
            }
            return listaMaterias;
        }
        public static Materia GetUnaMateria(string materia)
        {
            Materia unaMateria;
            _materias.TryGetValue(materia, out unaMateria);
            return unaMateria;
        }
        public static Profesor GetProfesorStringNombreApellido(List<Profesor> profesor, string nombreCompleto)
        {
            Profesor aux = null;
            if (profesor != null)
            {
                foreach (Profesor item in profesor)
                {
                    if ($"{item.Nombre} {item.Apellido}" == nombreCompleto)
                    {
                        aux = item;
                        break;
                    }
                }
            }
            return aux;
        }
        public static Alumno GetAlumnoStringNombreApellido(List<Alumno> alumnos, string nombreCompleto)
        {
            Alumno aux = null;
            if (alumnos != null)
            {
                foreach (Alumno item in alumnos)
                {
                    if ($"{item.Nombre} {item.Apellido}" == nombreCompleto)
                    {
                        aux = item;
                        break;
                    }
                }
            }
            return aux;
        }
        public static Alumno GetAlumnoStringNombreApellido(string nombreCompleto)
        {
            List<Alumno> listaAlumno = new List<Alumno>();
            listaAlumno = GetListAlumnos();
            Alumno aux = null;
            if (listaAlumno is not null)
            {
                foreach (Alumno item in listaAlumno)
                {
                    if ($"{item.Nombre} {item.Apellido}" == nombreCompleto)
                    {
                        aux = item;
                        break;
                    }
                }
            }
            return aux;
        }



        public static bool RegularidadAdmin(eRegularidad regularidad, string nombreCompleto, string nombreMateria)
        {
            bool todoOk = false;
            List<Alumno> listaAlumnos = GetListAlumnos();
            Alumno unAlumno = null;
            unAlumno = GetAlumnoStringNombreApellido(listaAlumnos, nombreCompleto);
            if (unAlumno is not null)
            {
                if (Alumno.CambiarEstado((Alumno)_usuarios[unAlumno.Gmail], regularidad, nombreMateria))
                {
                    todoOk = true;
                }
            }
            return todoOk;
        }

        public static List<Materia> GetProfesorMaterias(Profesor unProfe)
        {
            List<Materia> listaMateriasProfesor = new List<Materia>();
            foreach (KeyValuePair<string, Materia> item in _materias)
            {
                if(item.Value.Profesor is not null)
                {
                    if (item.Value.Profesor.Permisos == EPermisos.Profesor && item.Value.Profesor == unProfe)
                    {
                        listaMateriasProfesor.Add(item.Value);
                    }
                }

            }
            return listaMateriasProfesor;
        }
    }
}
