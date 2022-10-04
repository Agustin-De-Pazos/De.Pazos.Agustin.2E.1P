using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace De.Pazos.Agustin
{
    public partial class MenuAlumno : Form
    {
        public List<Materia> materias;
        public Alumno alumno;


        public MenuAlumno(List<Materia> materias, Alumno alumno)
        {
            InitializeComponent();
            this.materias = new List<Materia>();
            this.alumno = new Alumno();
            this.materias = materias;
            this.alumno = alumno;
        }

        private void MenuAlumno_Load(object sender, EventArgs e)
        {
            cargarCmBInscripccion();
            cargarCmBasistencia();
        }

        private void btn_Inscribirse_Click(object sender, EventArgs e)
        {
            if (alumno.CantidadMateriasC < 2)
            {
                if (!Alumno.RetornaSiLaMateriaYaFueTerminada(alumno, (string)cmb_incripcionMateria.SelectedItem))
                {
                    foreach (Materia item in materias)
                    {
                        if (item.Nombre == (string)cmb_incripcionMateria.SelectedItem)
                        {
                            _ = item + alumno;
                            MessageBox.Show("Inscripto correctamente");
                            break;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Maximo de materias asignadas");
            }
        }

        private void btn_asistencia_Click(object sender, EventArgs e)
        {
            if (cmb_asistencia.SelectedItem is not null)
            {
                for (int i = 0; i < alumno.MateriasCursadas.Length; i++)
                {
                    if ((string)cmb_asistencia.SelectedItem == alumno.MateriasCursadas[i])
                    {
                        alumno.Asistencia[i]++;
                        MessageBox.Show("Asistencia correcta");
                        break;
                    }
                    else if (i == 1)
                    {
                        MessageBox.Show("No esta inscripto");
                    }
                }
            }
        }
        private void cargarCmBInscripccion()
        {
            foreach (Materia item in materias)
            {
                cmb_incripcionMateria.Items.Add(item.Nombre);
            }
        }
        private void cargarCmBasistencia()
        {
            foreach (Materia item in materias)
            {
                cmb_asistencia.Items.Add(item.Nombre);
            }
        }
    }
}
