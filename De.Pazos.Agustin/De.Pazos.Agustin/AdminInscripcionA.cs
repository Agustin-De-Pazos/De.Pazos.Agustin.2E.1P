using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace De.Pazos.Agustin
{
    public partial class AdminInscripcionA : Form
    {
        public List<Materia> materias;
        public List<Usuario> usuarios;
        public List<Alumno> alumnos;


        public AdminInscripcionA(List<Materia> materias, List<Usuario> usuarios)
        {
            InitializeComponent();
            this.materias = new List<Materia>();
            this.usuarios = new List<Usuario>();
            this.alumnos = new List<Alumno>();
            this.materias = materias;
            this.usuarios = usuarios;
            listaSoloAlumnos(this.usuarios, this.alumnos);
        }


        public void listaSoloAlumnos(List<Usuario> u, List<Alumno> a)// ESTA FUNCIO DEBERIA IR EN BIBLIOTECA ALUMNOS
        {
            foreach (Usuario item in u)
            {
                if (EPermisos.Alumno == item.Permisos)
                {
                    a.Add((Alumno)item);
                }
            }
        }



        private void AdminInscripcionA_Load(object sender, EventArgs e)
        {
            cargarCmBMaterias();
            cargarCmBAlumnos();
        }

        private void cargarCmBMaterias()
        {
            foreach (Materia item in materias)
            {
                cmb_materias.Items.Add(item.Nombre);
            }
        }

        private void cargarCmBAlumnos()
        {
            foreach (Alumno item in alumnos)
            {
                cmb_alumnos.Items.Add(item.Nombre);
            }
        }

        private void btn_Inscribirse_Click(object sender, EventArgs e)
        {
            int bandera = 0;
            foreach (Alumno item in alumnos)
            {
                if (bandera == 1)
                    break;
                    if (item.CantidadMateriasC < 2)
                    {
                        if (!Alumno.RetornaSiLaMateriaYaFueTerminada(item, (string)cmb_materias.SelectedItem))
                        {
                            foreach (Materia m in materias)
                            {
                                if (m.Nombre == (string)cmb_materias.SelectedItem)
                                {
                                    _ = m + item;
                                    MessageBox.Show("Inscripto correctamente");
                                    bandera = 1;
                                    break;   
                                }

                            }
                        }
                    }
            }
        }
    }
}
