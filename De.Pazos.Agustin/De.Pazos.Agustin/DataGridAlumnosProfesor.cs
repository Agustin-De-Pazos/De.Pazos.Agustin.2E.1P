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
    public partial class DataGridAlumnosProfesor : Form
    {
        BindingSource bindingSource;
        Profesor _profe;
        public DataGridAlumnosProfesor(Profesor unProfe)
        {
            InitializeComponent();
            _profe = unProfe;
            bindingSource = new BindingSource();
        }

        private void cmb_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string materiaCmb = (string)cmb_materia.SelectedItem;
            List<Materia> aux = DataBase.GetProfesorMaterias(_profe);
            
            foreach (Materia item in aux)
            {
                if(item.Nombre == materiaCmb)
                {
                    bindingSource.DataSource = item.Alumnos;
                    break;
                }
            }
            dgv_alumnosProfe.DataSource = bindingSource;
        }

        private void DataGridAlumnosProfesor_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarProfesorMatCmB(_profe, cmb_materia);
        }
    }
}
