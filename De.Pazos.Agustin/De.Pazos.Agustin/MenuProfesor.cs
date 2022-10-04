using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace De.Pazos.Agustin
{
    public partial class MenuProfesor : Form
    {
        List<Materia> materias;
        Profesor profe;
        public MenuProfesor()
        {
            InitializeComponent();
        }
        public MenuProfesor(List<Materia> materias, Profesor unProfe)
        {
            InitializeComponent();
            this.materias = new List<Materia>();
            this.profe = new Profesor();
            this.materias = materias;
            this.profe = unProfe;
        }

        private void MenuProfesor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
