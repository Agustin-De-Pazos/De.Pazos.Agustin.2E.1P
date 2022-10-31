using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De.Pazos.Agustin
{
    public partial class InscribirAlumnoAdmin : Form
    {
        public InscribirAlumnoAdmin()
        {
            InitializeComponent();         
        }

        private void btn_inscribirAlumno_Click(object sender, EventArgs e)
        {
            Alumno aux = DataBase.GetAlumnoStringNombreApellido((string)cmb_alumno.SelectedItem);
            string mensaje = Alumno.InscribirseMateria(aux, (string)cmb_materia.SelectedItem);
            MessageBox.Show(mensaje);
           
        }



        private void InscribirAlumnoAdmin_Load(object sender, EventArgs e)
        {
            DataBase.GetListAlumnos();
            Biblioteca.CargarListaAlumnosCmB(cmb_alumno, DataBase.GetListAlumnos());
            Biblioteca.CargarMaterias(cmb_materia);
        }
    }
}
