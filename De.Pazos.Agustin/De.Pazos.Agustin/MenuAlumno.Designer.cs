
namespace De.Pazos.Agustin
{
    partial class MenuAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAlumno));
            this.btn_Inscribirse = new System.Windows.Forms.Button();
            this.btn_asistencia = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_asistencia = new System.Windows.Forms.Label();
            this.cmb_asistencia = new System.Windows.Forms.ComboBox();
            this.cmb_incripcionMateria = new System.Windows.Forms.ComboBox();
            this.lbl_inscripcionMateria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Inscribirse
            // 
            this.btn_Inscribirse.Location = new System.Drawing.Point(830, 362);
            this.btn_Inscribirse.Name = "btn_Inscribirse";
            this.btn_Inscribirse.Size = new System.Drawing.Size(151, 91);
            this.btn_Inscribirse.TabIndex = 0;
            this.btn_Inscribirse.Text = "Inscripcion de materias";
            this.btn_Inscribirse.UseVisualStyleBackColor = true;
            this.btn_Inscribirse.Click += new System.EventHandler(this.btn_Inscribirse_Click);
            // 
            // btn_asistencia
            // 
            this.btn_asistencia.Location = new System.Drawing.Point(830, 12);
            this.btn_asistencia.Name = "btn_asistencia";
            this.btn_asistencia.Size = new System.Drawing.Size(151, 91);
            this.btn_asistencia.TabIndex = 1;
            this.btn_asistencia.Text = "Asistencia";
            this.btn_asistencia.UseVisualStyleBackColor = true;
            this.btn_asistencia.Click += new System.EventHandler(this.btn_asistencia_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(745, 441);
            this.dataGridView1.TabIndex = 2;
            // 
            // lbl_asistencia
            // 
            this.lbl_asistencia.AutoSize = true;
            this.lbl_asistencia.Location = new System.Drawing.Point(873, 184);
            this.lbl_asistencia.Name = "lbl_asistencia";
            this.lbl_asistencia.Size = new System.Drawing.Size(66, 20);
            this.lbl_asistencia.TabIndex = 3;
            this.lbl_asistencia.Text = "Materias";
            // 
            // cmb_asistencia
            // 
            this.cmb_asistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_asistencia.FormattingEnabled = true;
            this.cmb_asistencia.Location = new System.Drawing.Point(830, 140);
            this.cmb_asistencia.Name = "cmb_asistencia";
            this.cmb_asistencia.Size = new System.Drawing.Size(151, 28);
            this.cmb_asistencia.TabIndex = 4;
            // 
            // cmb_incripcionMateria
            // 
            this.cmb_incripcionMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_incripcionMateria.FormattingEnabled = true;
            this.cmb_incripcionMateria.Location = new System.Drawing.Point(830, 296);
            this.cmb_incripcionMateria.Name = "cmb_incripcionMateria";
            this.cmb_incripcionMateria.Size = new System.Drawing.Size(151, 28);
            this.cmb_incripcionMateria.TabIndex = 5;
            // 
            // lbl_inscripcionMateria
            // 
            this.lbl_inscripcionMateria.AutoSize = true;
            this.lbl_inscripcionMateria.Location = new System.Drawing.Point(859, 258);
            this.lbl_inscripcionMateria.Name = "lbl_inscripcionMateria";
            this.lbl_inscripcionMateria.Size = new System.Drawing.Size(80, 20);
            this.lbl_inscripcionMateria.TabIndex = 6;
            this.lbl_inscripcionMateria.Text = "Inscripcipn";
            // 
            // MenuAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 465);
            this.Controls.Add(this.lbl_inscripcionMateria);
            this.Controls.Add(this.cmb_incripcionMateria);
            this.Controls.Add(this.cmb_asistencia);
            this.Controls.Add(this.lbl_asistencia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_asistencia);
            this.Controls.Add(this.btn_Inscribirse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAlumno";
            this.Text = "Menu Alumno";
            this.Load += new System.EventHandler(this.MenuAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Inscribirse;
        private System.Windows.Forms.Button btn_asistencia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_asistencia;
        private System.Windows.Forms.ComboBox cmb_asistencia;
        private System.Windows.Forms.ComboBox cmb_incripcionMateria;
        private System.Windows.Forms.Label lbl_inscripcionMateria;
    }
}