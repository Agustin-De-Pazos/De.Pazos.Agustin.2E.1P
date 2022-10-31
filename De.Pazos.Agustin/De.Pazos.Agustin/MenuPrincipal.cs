using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace De.Pazos.Agustin
{
    //MENU ADMIN TERMINADO
    //MENU ALUMNO FALTA DATA GRID
    //LOG IN TERMINADO
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            Usuario aux;
            aux = DataBase.ValidarUsuario(txt_usuario.Text, txt_contraseña.Text);
            if(aux is not null)
            {
                switch (aux.Permisos)
                {
                    case EPermisos.Admin:
                        MenuAdmin admin = new MenuAdmin((Admin)aux);
                        admin.ShowDialog();
                        break;
                    case EPermisos.Alumno:
                        MenuAlumno alumno = new MenuAlumno((Alumno)aux);
                        alumno.ShowDialog();


                        break;
                    case EPermisos.Profesor:
                        MenuProfesor profesor = new MenuProfesor((Profesor)aux);

                        profesor.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("No Existe");
            }
        }
        private void btn_adminH_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "admin@gmail.com";
            txt_contraseña.Text = "admin";
        }

        private void btn_profesorH_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "profesor@gmail.com";
            txt_contraseña.Text = "profesor";
        }

        private void btn_alumnoH_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "alumno1@gmail.com";
            txt_contraseña.Text = "alumno1";
        }

        
    }
}