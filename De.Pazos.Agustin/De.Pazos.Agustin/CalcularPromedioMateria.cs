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
    public partial class CalcularPromedioMateria : Form
    {
        public CalcularPromedioMateria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Alumno> alumnos = null;
            int acumulador = 0;
            int contador;
            int promedio =-1;


            alumnos = DataBase.GetListAlumnos();
            Materia materia = DataBase.GetMateria((string)cmb_materia.SelectedItem);
            if (alumnos is not null)
            {
                foreach (Alumno item in alumnos)
                {
                    acumulador += item.CantidadMateriasEncurso;
                }
            }

            contador = materia.Alumnos.Count();
            

            if (contador != 0)
            {
                promedio = acumulador / contador;
                MessageBox.Show($"Promedio: {promedio}");
            }
            else
            {
                MessageBox.Show("No hay alumnos inscriptos");
            }
        }

        private void CalcularPromedioMateria_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarMaterias(cmb_materia);
        }
    }
}
