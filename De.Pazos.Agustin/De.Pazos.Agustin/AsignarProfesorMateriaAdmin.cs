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
    public partial class AsignarProfesorMateriaAdmin : Form
    {
        public AsignarProfesorMateriaAdmin()
        {
            InitializeComponent();
        }


        private void btn_altaProfesorMat_Click_1(object sender, EventArgs e)
        {
            Materia aux = null;
            if (this.cmb_profesorAltaMateria.SelectedItem is not null && this.cmb_profesorAlta.SelectedItem is not null)
            {
                aux = DataBase.GetMateria(cmb_profesorAltaMateria.SelectedItem.ToString());

                if (DataBase.AsignarProfeMateria(aux, this.cmb_profesorAlta.SelectedItem.ToString()) == 1)
                {
                    MessageBox.Show("Asignado correctamente");
                }
                else if (aux.Estado == EStadoProfe.Ocupado)
                {
                    MessageBox.Show("Ya hay un profesor asigando");
                }
                else
                {
                    MessageBox.Show("No existe la materia");
                }
            }
        }

        private void AsignarProfesorMateriaAdmin_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarProfesorCmB(cmb_profesorAlta);
            Biblioteca.CargarMaterias(cmb_profesorAltaMateria);
        }
        
        
    }
}
