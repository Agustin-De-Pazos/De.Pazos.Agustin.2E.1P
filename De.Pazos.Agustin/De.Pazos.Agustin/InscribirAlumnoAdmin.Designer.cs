namespace De.Pazos.Agustin
{
    partial class InscribirAlumnoAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_alumno = new System.Windows.Forms.ComboBox();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.btn_inscribirAlumno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(139, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos:";
            // 
            // cmb_alumno
            // 
            this.cmb_alumno.FormattingEnabled = true;
            this.cmb_alumno.Location = new System.Drawing.Point(108, 78);
            this.cmb_alumno.Name = "cmb_alumno";
            this.cmb_alumno.Size = new System.Drawing.Size(121, 23);
            this.cmb_alumno.TabIndex = 1;
            // 
            // cmb_materia
            // 
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(108, 158);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(121, 23);
            this.cmb_materia.TabIndex = 2;
            // 
            // btn_inscribirAlumno
            // 
            this.btn_inscribirAlumno.Location = new System.Drawing.Point(108, 210);
            this.btn_inscribirAlumno.Name = "btn_inscribirAlumno";
            this.btn_inscribirAlumno.Size = new System.Drawing.Size(121, 41);
            this.btn_inscribirAlumno.TabIndex = 3;
            this.btn_inscribirAlumno.Text = "Inscribir Alumno";
            this.btn_inscribirAlumno.UseVisualStyleBackColor = true;
            this.btn_inscribirAlumno.Click += new System.EventHandler(this.btn_inscribirAlumno_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(139, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Materias:";
            // 
            // InscribirAlumnoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::De.Pazos.Agustin.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(342, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_inscribirAlumno);
            this.Controls.Add(this.cmb_materia);
            this.Controls.Add(this.cmb_alumno);
            this.Controls.Add(this.label1);
            this.Name = "InscribirAlumnoAdmin";
            this.Text = "InscribirAlumnoAdmin";
            this.Load += new System.EventHandler(this.InscribirAlumnoAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_alumno;
        private System.Windows.Forms.ComboBox cmb_materia;
        private System.Windows.Forms.Button btn_inscribirAlumno;
        private System.Windows.Forms.Label label2;
    }
}