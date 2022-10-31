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
    public partial class AgregarMateriaAdmin : Form
    {
        public AgregarMateriaAdmin()
        {
            InitializeComponent();
        }

        private void btn_agregarMateria_Click(object sender, EventArgs e)
        {
            if(txt_materiaAlta.Text != "")
            {
                if (DataBase.NewMateria(txt_materiaAlta.Text, DataBase.StringAECUastrimestre((string)cmb_altaCuatrimestre.SelectedItem)))
                {
                    MessageBox.Show("Materia agregada");
                }
                else
                {
                    MessageBox.Show("YA existe");
                }
            }
            else
            {
                MessageBox.Show("Ingrese nombre de la materia");
            }
            
        }

        private void AgregarMateriaAdmin_Load(object sender, EventArgs e)
        {
            cmb_altaCuatrimestre.SelectedIndex = 0;
        }
    }
}
