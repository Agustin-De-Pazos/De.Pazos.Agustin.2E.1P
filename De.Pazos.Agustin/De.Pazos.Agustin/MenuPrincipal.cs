using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace De.Pazos.Agustin
{
    //MENU ADMIN TERMINADO
    //MENU ALUMNO FALTA DATA GRID
    //LOG IN TERMINADO
    public partial class MenuPrincipal : Form
    {
        public List<Usuario> usuarios;
        private Dictionary<string, Usuario> contraseña;//Al utilizar un dicionario no se pueden repetir 2 contraseñas
        public List<Materia> materias;
        public MenuPrincipal()
        {
            InitializeComponent();
            CargarDatos();
        }
    

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {    
            foreach (KeyValuePair<string,Usuario> item in contraseña)
            {
                if (item.Value.Gmail == txt_usuario.Text.ToString() && item.Key == txt_contraseña.Text.ToString())
                {
                    switch (item.Value.Permisos)
                    {
                        case EPermisos.Admin:
                            MenuAdmin admin = new MenuAdmin(materias,usuarios, item.Value, contraseña);
                            DialogResult resultadoadmin = admin.ShowDialog();
                            materias = admin.materias;
                            contraseña = admin.contraseña;
                            break;
                        case EPermisos.Alumno:
                            MenuAlumno alumno = new MenuAlumno(materias,(Alumno)item.Value);
                            materias = alumno.materias;

                            DialogResult resultaodAlumno = alumno.ShowDialog();
                            
                            break;
                        case EPermisos.Profesor:
                            MenuProfesor profesor = new MenuProfesor(materias,(Profesor)item.Value);
                            
                            DialogResult resultadoProfesor = profesor.ShowDialog();
                            break;
                    }
                    break;
                }  
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

        private void CargarDatos()
        {
            materias = new List<Materia>();
            Profesor prof1 = new Profesor("profesor@gmail.com", "Eustacio", "3", 1);
            Profesor prof2 = new Profesor("profesor2@gmail.com", "Enricke", "3", 1);
            Profesor prof3 = new Profesor("profesor3@gmail.com", "Soledad", "3", 1);
            Profesor prof4 = new Profesor("profesor4@gmail.com", "Esteban", "FAFA", 1);
            Admin admin = new Admin("admin@gmail.com", "admin1", "3", 1);
            Alumno alumno1 = new Alumno("alumno1@gmail.com", "ernesto", "3", 1);
            Alumno alumno2 = new Alumno("alumno2@gmail.com", "caballines", "3", 1);
            Alumno alumno3 = new Alumno("alumno3@gmail.com", "cesar", "oscuro", 1);
            Alumno alumno4 = new Alumno("alumno4@gmail.com", "Roberto", "Fev", 1);
            Alumno alumno5 = new Alumno("alumno5@gmail.com", "Pepe", "Bas", 1);
            contraseña = new Dictionary<string, Usuario>();
            usuarios = new List<Usuario>();
            contraseña.Add("profesor2", prof2);
            contraseña.Add("profesor3", prof3);
            contraseña.Add("profesor4", prof4);
            contraseña.Add("profesor", prof1);
            contraseña.Add("admin", admin);
            contraseña.Add("alumno1", alumno1);
            contraseña.Add("alumno2", alumno2);
            contraseña.Add("alumno3", alumno3);
            contraseña.Add("alumno4", alumno4);
            contraseña.Add("alumno5", alumno5);
            usuarios.Add(prof1);
            usuarios.Add(prof2);
            usuarios.Add(prof3);
            usuarios.Add(prof4);
            usuarios.Add(alumno1);
            usuarios.Add(alumno2);
            usuarios.Add(alumno3);
            usuarios.Add(alumno4);
            usuarios.Add(alumno5);

            Materia laboratorio1 = new Materia("Laboratorio 1", 1, prof2, "0", EStadoProfe.Ocupado);
            Materia laboratorio2 = new Materia("Laboratorio 2", 2, prof3, "Laboratorio 1", EStadoProfe.Ocupado);
            Materia ingles1 = new Materia("Ingles 1", 1, prof1, "0", EStadoProfe.Ocupado);
            Materia ingles2 = new Materia("Ingles 2", 2, prof2, "ingles 1", EStadoProfe.Ocupado);
            Materia matematica1 = new Materia("Matematica 1", 1, prof4, "0", EStadoProfe.Ocupado);
            Materia matematica2 = new Materia("Matematica 2", 2, prof4, "0", EStadoProfe.Ocupado);
            
            
            Materia MateriaTest = new Materia("Matematica 2", 2, prof4, "0", EStadoProfe.Ocupado);
            Materia MateriaTest1 = new Materia("Matematica 2", 2, prof4, "0", EStadoProfe.Ocupado);
            Materia MateriaTest2 = new Materia("Matematica 2", 2, prof4, "0", EStadoProfe.Ocupado);
            Materia materia1 = new Materia("PEPE5", 2, EStadoProfe.Libre);
            Materia materia2 = new Materia("PEPE5", 2, EStadoProfe.Ocupado);
            Materia materia3 = new Materia("PEPE5", 2, EStadoProfe.Libre);
            materias.Add(laboratorio1);
            materias.Add(laboratorio2);
            materias.Add(ingles1);
            materias.Add(ingles2);
            materias.Add(matematica1);
            materias.Add(matematica2);
            materias.Add(materia1);
            materias.Add(materia2);
            materias.Add(materia3);

            _ = matematica1 + alumno1;
            _ = matematica1 + alumno2;
            _ = matematica1 + alumno3;
            _ = matematica1 + alumno4;
            
        }
        
    }
}