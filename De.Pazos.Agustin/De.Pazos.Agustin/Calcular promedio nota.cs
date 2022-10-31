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
    public partial class Calcular_promedio_nota : Form
    {
        public Calcular_promedio_nota()
        {
            InitializeComponent();
        }

        private void btn_notaPromedio_Click(object sender, EventArgs e)
        {
            int acumulador = 0;
            int contador = 0;
            int promedio;
            Materia materia;

            List<Alumno> alumnos;
            if (cmb_materia.SelectedItem is not null)
            {
                materia = DataBase.GetMateria((string)cmb_materia.SelectedItem);
                alumnos = DataBase.GetListAlumnos();
                foreach (Alumno alumno in alumnos)
                {
                    foreach (MateriaCursada materiasCursadas in alumno.MateriasCursadas)
                    {
                        if(materiasCursadas.Nombre == (string)cmb_materia.SelectedItem && materiasCursadas.NotaFinal !=0)
                        {
                            acumulador += materiasCursadas.NotaFinal;
                            contador++;
                        }
                        
                    }
                }
                if(contador != 0)
                {
                    promedio =acumulador / contador;
                    MessageBox.Show($"El promedio es: {promedio}");
                }
                else
                {
                    MessageBox.Show("No hay notas registradas");
                }
            }
           
        }

        private void Calcular_promedio_nota_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarMaterias(cmb_materia);
        }
    }
}
