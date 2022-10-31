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
    public partial class AgregarUsuarioAdmin : Form
    {
        public AgregarUsuarioAdmin()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            int aux;
            if (ValidoIngresoAlta())
            {
                aux = int.Parse(txt_altaDni.Text);

                if (DataBase.GmailNoExiste(txt_GmailAlta.Text) && DataBase.DniNoExistente(aux))
                {
                    if (DataBase.UsuariosAdminAdd((string)cmb_usuarioALTA.SelectedItem, txt_altaNombre.Text
                      , txt_GmailAlta.Text, aux, txt_contraseñaAtla.Text, txt_altaApellido.Text))
                    {
                        MessageBox.Show("Usuario creado");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe");
                }
            }
            else
            {
                MessageBox.Show("Campos mal ingresados");
            }
        }

        private bool ValidoIngresoAlta()
        {
            bool todOk = false;
            if (Validacion.SoloLetrasMinusculaNoNull(txt_altaApellido.Text) &&
                Validacion.SoloLetrasMinusculaNoNull(txt_altaNombre.Text) &&
                txt_GmailAlta.Text is not null && txt_contraseñaAtla.Text is not null &&
                Validacion.SoloNumeros(txt_altaDni.Text))
            {
                todOk = true;
            }
            return todOk;
        }

        private void AgregarUsuarioAdmin_Load(object sender, EventArgs e)
        {
            cmb_usuarioALTA.SelectedIndex = 0;
        }
    }
}
