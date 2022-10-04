using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace De.Pazos.Agustin
{
    public partial class MenuAdmin : Form
    {
        public List<Materia> materias;
        public List<Usuario> usuarios;
        public Dictionary<string, Usuario> contraseña;
        public Usuario unAdmin;
        //public Materia materia;




        public MenuAdmin(List<Materia> materias, List<Usuario> usuarios, Usuario unAdmin, Dictionary<string, Usuario> contraseña)
        {
            InitializeComponent();
            this.materias = new List<Materia>();
            this.usuarios = new List<Usuario>();
            this.contraseña = new Dictionary<string, Usuario>();
            this.unAdmin = new Admin();
            this.materias = materias;
            this.usuarios = usuarios;
            this.unAdmin = unAdmin;
            this.contraseña = contraseña;
            

        }
        private void btn_formInscribir_Click(object sender, EventArgs e)
        {
            AdminInscripcionA adminInscripcion = new AdminInscripcionA(this.materias, this.usuarios);
            DialogResult resultadoadmin = adminInscripcion.ShowDialog();

        }

        private void btn_agregarMateria_Click(object sender, EventArgs e)
        {
            string auxStr;
            int auxInt;
            string aux = txt_materiaAlta.Text;
            if (Materia.Verificar(materias, aux) && cmb_altaCuatrimestre.SelectedItem is not null)
            {
                auxStr = (string)this.cmb_altaCuatrimestre.SelectedItem;
                auxInt = int.Parse(auxStr);

                Materia materia = new Materia(aux, auxInt, EStadoProfe.Libre);
                materias.Add(materia);
                cmb_profesorAltaMateria.Items.Add(materia.Nombre);
                MessageBox.Show("Materia agregada");
            }
            else
            {
                MessageBox.Show("YA existe");
            }
        }

        private void btn_altaProfesorMat_Click(object sender, EventArgs e)
        {
            if (this.cmb_profesorAltaMateria.SelectedItem is not null && this.cmb_profesorAlta.SelectedItem is not null)
            {
                foreach (Materia item in materias)
                {
                    if (item.Estado == EStadoProfe.Libre)
                    {
                        foreach (Usuario profe in usuarios)
                        {
                            if (profe.Nombre + profe.Apellido == this.cmb_profesorAlta.SelectedItem.ToString())
                            {
                                item.Profesor = (Profesor)profe;
                                item.Estado = EStadoProfe.Ocupado;
                                cmb_materia.Items.Add(item.Nombre);
                                MessageBox.Show("Registrado");
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay materias para asignar o profesor");
            }
        }
        public void CargarProfesorMateria(List<Materia> m)
        {
            foreach (Materia item in m)
            {
                if (item.Estado == EStadoProfe.Libre)
                {
                    cmb_profesorAltaMateria.Items.Add(item.Nombre);
                }
            }
        }

        public void CargarProfesorCmB(List<Usuario> u)
        {
            if (u is not null)
            {
                foreach (Usuario item in u)
                {
                    if (item.Permisos == EPermisos.Profesor)
                    {
                        cmb_profesorAlta.Items.Add($"{item.Nombre} {item.Apellido}");
                    }
                }
            }
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            CargarProfesorCmB(usuarios);
            CargarProfesorMateria(materias);
            lbl_bienvenidoAdmin.Text = $"Bienvenido: {unAdmin.Nombre}";
            MateriasOcupadas(materias);
        }


        private void btn_alta_Click(object sender, EventArgs e)
        {
            int aux;
            if (ValidoIngresoAlta())
            {
                aux = int.Parse(txt_altaDni.Text);

                if (ContraseñasNoIguales(contraseña,txt_contraseñaAtla.Text)&& Usuario.VerificarDni(usuarios,txt_GmailAlta.Text) && Usuario.VerificarDni(usuarios,txt_altaDni.Text))
                {
                    switch ((string)cmb_usuarioALTA.SelectedItem)
                    {
                        case "Admin":
                            Admin NuevoAdmin = new Admin(txt_GmailAlta.Text, txt_altaNombre.Text, txt_altaApellido.Text, aux);
                            usuarios.Add(NuevoAdmin);
                            contraseña.Add(txt_contraseñaAtla.Text, NuevoAdmin);
                            break;
                        case "Profesor":
                            Profesor NuevoProfesor = new Profesor(txt_GmailAlta.Text, txt_altaNombre.Text, txt_altaApellido.Text, aux);
                            usuarios.Add(NuevoProfesor);
                            contraseña.Add(txt_contraseñaAtla.Text, NuevoProfesor);
                            break;
                        case "Alumno":
                            Alumno NuevoAlumno = new Alumno(txt_GmailAlta.Text, txt_altaNombre.Text, txt_altaApellido.Text, aux);
                            usuarios.Add(NuevoAlumno);
                            contraseña.Add(txt_contraseñaAtla.Text, NuevoAlumno);
                            break;
                        default:
                            break;
                    }

                    MessageBox.Show("Usuario creado");
                }
                else
                {
                    MessageBox.Show("Ya Existe");
                }

            }

        }

        private bool ValidoIngresoAlta()
        {
            bool todOk = false;
            if (Validacion.SoloLetrasMinusculaNoNull(txt_altaApellido.Text) &&
                Validacion.SoloLetrasMinusculaNoNull(txt_altaNombre.Text) &&
                txt_GmailAlta.Text is not null && txt_contraseñaAtla.Text is not null &&
                cmb_usuarioALTA.SelectedItem is not null && Validacion.SoloNumeros(txt_altaDni.Text))
            {
                todOk = true;
            }
            return todOk;
        }
        public bool ContraseñasNoIguales(Dictionary<string, Usuario> contraseña, string texto)
        {
            bool todOk = true;

            foreach (KeyValuePair<string, Usuario> item in contraseña)
            {
                if (item.Key == texto)
                {
                    todOk = false;
                    break;
                }
            }
            return todOk;
        }
        private void btn_cambiarEstadoMateriaA_Click(object sender, EventArgs e)
        {
            if(cmb_materia.SelectedItem is not null && cmb_elegirAlumno.SelectedItem is not null && cmb_cambiarEstadoRyL.SelectedItem is not null)
            {
                foreach (Usuario item in usuarios)
                {
                    if(EPermisos.Alumno == item.Permisos)
                    {
                        if(Alumno.MateriasYmateriasRegistradas((Alumno)item, (string)cmb_materia.SelectedItem) &&
                            (string)cmb_elegirAlumno.SelectedItem == $"{item.Nombre}   {item.Dni}")
                        {
                            for (int i = 0; i < ((Alumno)item).MateriasCursadas.Length; i++)
                            {
                                if(((Alumno)item).MateriasCursadas[i] == (string)cmb_materia.SelectedItem)
                                {
                                    if((string)cmb_cambiarEstadoRyL.SelectedItem == "Libre")
                                    {
                                        ((Alumno)item).Estado[0] = EStadoAlumno.Libre;
                                        MessageBox.Show("Estado del alumno cambiado");
                                    }
                                    else
                                    {
                                        ((Alumno)item).Estado[0] = EStadoAlumno.Regular;
                                        MessageBox.Show("Estado del alumno cambiado");
                                    }
                                    
                                }
                            }
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay materias asignadas");
            }
        }

        public bool MateriasOcupadas(List<Materia> materias)
        {
            bool todOk = false;
            foreach (Materia item in materias)
            {
                if (EStadoProfe.Ocupado == item.Estado)
                {
                    cmb_materia.Items.Add(item.Nombre);
                    todOk = true;
                }
            }

            return todOk;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.cmb_elegirAlumno.Items.Clear();
            foreach (Usuario item in usuarios)
            {
                if (EPermisos.Alumno == item.Permisos)
                {
                    if (cmb_materia.SelectedItem is not null)
                    {
                        if (Alumno.MateriasYmateriasRegistradas((Alumno)item, (string)cmb_materia.SelectedItem))
                        {
                            cmb_elegirAlumno.Items.Add($"{item.Nombre}   {item.Dni}");
                        }
                    }
                }
            }
        }


    }
}
