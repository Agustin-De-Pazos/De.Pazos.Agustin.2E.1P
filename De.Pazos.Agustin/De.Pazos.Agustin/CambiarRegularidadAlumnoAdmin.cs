using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De.Pazos.Agustin
{
    public partial class CambiarRegularidadAlumnoAdmin : Form
    {
        public CambiarRegularidadAlumnoAdmin()
        {
            InitializeComponent();
        }

        private void btn_cambiarEstadoMateriaA_Click(object sender, EventArgs e)
        {
            if (cmb_materia.SelectedItem is not null && cmb_elegirAlumno.SelectedItem is not null && (string)cmb_cambiarEstadoRyL.SelectedItem is not null)
            {
                if (DataBase.RegularidadAdmin(MateriaCursada.StringRegularidad((string)cmb_cambiarEstadoRyL.SelectedItem), (string)cmb_elegirAlumno.SelectedItem, (string)cmb_materia.SelectedItem))
                {
                    MessageBox.Show("Canbiado correctamente");
                }
                else
                {
                    MessageBox.Show("EROR");
                }
            }
        }
        public void CargarAlumnosCmB()
        {
            List<Alumno> aux;
            aux = DataBase.GetListAlumnos();
            if (aux is not null)
            {
                foreach (Alumno item in aux)
                {

                    if (item is not null)
                    {
                        cmb_elegirAlumno.Items.Add($"{item.Nombre} {item.Apellido}");
                    }
                }
            }
        }

        private void CambiarRegularidadAlumnoAdmin_Load(object sender, EventArgs e)
        {
            //CargarAlumnosCmB();
            Biblioteca.CargarMaterias(cmb_materia);
            if(cmb_materia.Items is not null)
            cmb_materia.SelectedIndex = 0;
        }

        private void cmb_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Biblioteca.FiltrarAlumnosCursandoMateriaCmb(cmb_materia, cmb_elegirAlumno, lbl_hayAlumnos);
        }
    }
}
