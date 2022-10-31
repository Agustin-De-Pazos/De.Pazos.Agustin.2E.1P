using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De.Pazos.Agustin
{
    public static class Biblioteca
    {
        public static void FiltrarAlumnosCursandoMateriaCmb(ComboBox materiaElegida, ComboBox cargarCmbAlumno, Label hayAlumnos)
        {
            bool todoOk = false;
            Materia unaMateria;
            cargarCmbAlumno.Items.Clear();
            unaMateria = DataBase.GetMateria((string)materiaElegida.SelectedItem);
            List<Alumno> listaAlumnos = Materia.GetListaAlumno(unaMateria);
            if (listaAlumnos is not null)
            {
                foreach (Alumno item in listaAlumnos)
                {
                    cargarCmbAlumno.Items.Add($"{item.Nombre} {item.Apellido}");
                    todoOk = true;
                }
            }
            if (todoOk == false)
            {
                if (cargarCmbAlumno.SelectedItem is not null)
                {
                    cargarCmbAlumno.SelectedIndex = 0;
                }
                cargarCmbAlumno.Visible = false;
                hayAlumnos.Visible = true;
            }
            else
            {
                cargarCmbAlumno.Visible = true;
                hayAlumnos.Visible = false;
            }
        }
        public static bool CargarMateriasDelAlumnoCursando(Alumno unAlumno, ComboBox cmb_materia)
        {
            bool todoOk = false;
            List<MateriaCursada> listaMateriasCursada;
            listaMateriasCursada = unAlumno.GetMateriasCursada();
            foreach (MateriaCursada item in listaMateriasCursada)
            {
                if (item.Estado == eEstadoCursada.Cursando)
                {
                    cmb_materia.Items.Add(item.Nombre);
                }
            }
            return todoOk;
        }
        public static void cargarMateriasProfesor(ComboBox cmb, Profesor unProfe)
        {
            List<Materia> materias;
            materias = DataBase.GetListaMaterias();
            foreach (Materia item in materias)
            {
                if (item.Profesor is not null)
                {
                    if (item.Profesor.Gmail == unProfe.Gmail)
                    {
                        cmb.Items.Add(item.Nombre);
                    }
                }
            }
        }
        public static void CargarMaterias(ComboBox cmb)
        {
            List<Materia> aux;
            aux = DataBase.GetListaMaterias();
            if (aux != null)
            {
                foreach (Materia item in aux)
                {
                    cmb.Items.Add(item.Nombre);
                }
            }
        }
        public static void CargarProfesorCmB(ComboBox cmb)
        {
            List<Profesor> aux;
            aux = DataBase.GetListaProfes();
            if (aux is not null)
            {
                foreach (Profesor item in aux)
                {
                    cmb.Items.Add($"{item.Nombre} {item.Apellido}");
                }
            }
        }
        public static void CargarProfesorMatCmB(Profesor unProfe, ComboBox cmb)
        {
            List<Materia> materiaList;
            materiaList = DataBase.GetProfesorMaterias(unProfe);
            foreach (Materia item in materiaList)
            {
                if(item.Profesor.Nombre == unProfe.Nombre)
                {
                    cmb.Items.Add(item.Nombre);
                }
            }
        }
    }
}
