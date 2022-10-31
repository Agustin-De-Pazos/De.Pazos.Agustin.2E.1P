using Entidades;
using System;
using System.Windows.Forms;

namespace De.Pazos.Agustin
{
    public partial class MenuAlumno : Form
    {
        private Alumno _alumno;
        BindingSource bindingSource;
        public MenuAlumno(Alumno alumno)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            _alumno = alumno;
        }

        private void MenuAlumno_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = _alumno.GetMateriasCursada();
            dgv_alumno.DataSource = bindingSource;
        }



        private void btn_asistencia_Click(object sender, EventArgs e)
        {
                AsistenciaAlumno asistencia = new AsistenciaAlumno(_alumno);
                asistencia.ShowDialog();
                 this.Close();
        }

        private void btn_Inscribirse_Click(object sender, EventArgs e)
        {
            InscripcionAlumMaterias inscripcionMateriaAlumno = new InscripcionAlumMaterias(_alumno);
            inscripcionMateriaAlumno.ShowDialog();
            this.Close();
        }
    }
}
