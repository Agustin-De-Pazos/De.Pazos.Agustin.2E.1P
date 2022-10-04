
namespace De.Pazos.Agustin
{
    partial class AdminInscripcionA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInscripcionA));
            this.lbl_inscripcionMateria = new System.Windows.Forms.Label();
            this.cmb_alumnos = new System.Windows.Forms.ComboBox();
            this.btn_Inscribirse = new System.Windows.Forms.Button();
            this.cmb_materias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_inscripcionMateria
            // 
            this.lbl_inscripcionMateria.AutoSize = true;
            this.lbl_inscripcionMateria.Location = new System.Drawing.Point(102, 46);
            this.lbl_inscripcionMateria.Name = "lbl_inscripcionMateria";
            this.lbl_inscripcionMateria.Size = new System.Drawing.Size(80, 20);
            this.lbl_inscripcionMateria.TabIndex = 9;
            this.lbl_inscripcionMateria.Text = "Inscripcion";
            // 
            // cmb_alumnos
            // 
            this.cmb_alumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_alumnos.FormattingEnabled = true;
            this.cmb_alumnos.Location = new System.Drawing.Point(69, 82);
            this.cmb_alumnos.Name = "cmb_alumnos";
            this.cmb_alumnos.Size = new System.Drawing.Size(151, 28);
            this.cmb_alumnos.TabIndex = 8;
            // 
            // btn_Inscribirse
            // 
            this.btn_Inscribirse.Location = new System.Drawing.Point(69, 238);
            this.btn_Inscribirse.Name = "btn_Inscribirse";
            this.btn_Inscribirse.Size = new System.Drawing.Size(151, 91);
            this.btn_Inscribirse.TabIndex = 7;
            this.btn_Inscribirse.Text = "Inscripcion de materias";
            this.btn_Inscribirse.UseVisualStyleBackColor = true;
            this.btn_Inscribirse.Click += new System.EventHandler(this.btn_Inscribirse_Click);
            // 
            // cmb_materias
            // 
            this.cmb_materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materias.FormattingEnabled = true;
            this.cmb_materias.Location = new System.Drawing.Point(69, 173);
            this.cmb_materias.Name = "cmb_materias";
            this.cmb_materias.Size = new System.Drawing.Size(151, 28);
            this.cmb_materias.TabIndex = 10;
            // 
            // AdminInscripcionA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(309, 397);
            this.Controls.Add(this.cmb_materias);
            this.Controls.Add(this.lbl_inscripcionMateria);
            this.Controls.Add(this.cmb_alumnos);
            this.Controls.Add(this.btn_Inscribirse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminInscripcionA";
            this.Text = "AdminInscripcionA";
            this.Load += new System.EventHandler(this.AdminInscripcionA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inscripcionMateria;
        private System.Windows.Forms.ComboBox cmb_alumnos;
        private System.Windows.Forms.Button btn_Inscribirse;
        private System.Windows.Forms.ComboBox cmb_materias;
    }
}