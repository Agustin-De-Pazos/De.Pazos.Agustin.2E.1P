﻿using Entidades;
using System;
using System.Windows.Forms;

namespace De.Pazos.Agustin
{
    public partial class MenuAdmin : Form
    {
        private Usuario unAdmin;
        public MenuAdmin(Usuario unAdmin)
        {
            InitializeComponent();
            this.unAdmin = unAdmin;
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

            lbl_bienvenidoAdmin.Text = $"Bienvenido: {unAdmin.Nombre}";
        }

        private void btn_formAgregarMateria_Click(object sender, EventArgs e)
        {
            AgregarMateriaAdmin agregarMateria = new AgregarMateriaAdmin();
            agregarMateria.ShowDialog();
        }

        private void btn_altaUsuario_Click_1(object sender, EventArgs e)
        {
            AgregarUsuarioAdmin agregarUsuario = new AgregarUsuarioAdmin();
            agregarUsuario.ShowDialog();
        }

        private void btn_altaProfesorMat_Click(object sender, EventArgs e)
        {
            AsignarProfesorMateriaAdmin asignarProfesorMateria = new AsignarProfesorMateriaAdmin();
            asignarProfesorMateria.ShowDialog();
        }
        private void btn_formAgregarMateria_Click_1(object sender, EventArgs e)
        {
            AgregarMateriaAdmin agregarMateriaAdmin = new AgregarMateriaAdmin();
            agregarMateriaAdmin.ShowDialog();
        }
        private void btn_cambiarEstadoMateriaA_Click(object sender, EventArgs e)
        {
            CambiarRegularidadAlumnoAdmin cambiarRegularidadAlumnoAdmin = new CambiarRegularidadAlumnoAdmin();
            cambiarRegularidadAlumnoAdmin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InscribirAlumnoAdmin inscribirAlumnoAdmin = new InscribirAlumnoAdmin();
            inscribirAlumnoAdmin.ShowDialog();
        }

        private void btn_calcularPromedio_Click(object sender, EventArgs e)
        {
            CalcularPromedioMateria calcularPromedioMateria = new CalcularPromedioMateria();
            calcularPromedioMateria.ShowDialog();
        }

        private void btn_calcularNotaPromedio_Click(object sender, EventArgs e)
        {
            Calcular_promedio_nota calcular_Promedio_Nota = new Calcular_promedio_nota();
            calcular_Promedio_Nota.ShowDialog();
        }
    }
}
