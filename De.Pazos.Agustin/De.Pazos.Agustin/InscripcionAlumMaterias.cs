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
    public partial class InscripcionAlumMaterias : Form
    {
        Alumno _alumno;
        public InscripcionAlumMaterias(Alumno alumno)
        {
            InitializeComponent();
            _alumno = alumno;
        }

        private void btn_inscripcion_Click(object sender, EventArgs e)
        {
            string mensaje = Alumno.InscribirseMateria(_alumno, (string)cmb_materias.SelectedItem);
            MessageBox.Show(mensaje);
            this.Close();
        }

        private void InscripcionAlumMaterias_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarMaterias(cmb_materias);
            if(cmb_materias.Items is not null)
            {
                cmb_materias.SelectedIndex = 0;
            }
        }
    }
}
