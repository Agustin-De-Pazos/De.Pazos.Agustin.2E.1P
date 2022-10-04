
namespace De.Pazos.Agustin
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.btn_alta = new System.Windows.Forms.Button();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.lbl_altaNombre = new System.Windows.Forms.Label();
            this.txt_GmailAlta = new System.Windows.Forms.TextBox();
            this.txt_contraseñaAtla = new System.Windows.Forms.TextBox();
            this.cmb_usuarioALTA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_materiasAlta = new System.Windows.Forms.Label();
            this.lbl_cuatrimestreAlta = new System.Windows.Forms.Label();
            this.txt_materiaAlta = new System.Windows.Forms.TextBox();
            this.btn_agregarMateria = new System.Windows.Forms.Button();
            this.cmb_profesorAlta = new System.Windows.Forms.ComboBox();
            this.cmb_profesorAltaMateria = new System.Windows.Forms.ComboBox();
            this.lbl_profesorAlta = new System.Windows.Forms.Label();
            this.lbl_profesorAltaMateria = new System.Windows.Forms.Label();
            this.btn_altaProfesorMat = new System.Windows.Forms.Button();
            this.cmb_altaCuatrimestre = new System.Windows.Forms.ComboBox();
            this.txt_apellidoAlta = new System.Windows.Forms.Label();
            this.txt_altaApellido = new System.Windows.Forms.TextBox();
            this.txt_altaNombre = new System.Windows.Forms.TextBox();
            this.lbl_altaGmail = new System.Windows.Forms.Label();
            this.lbl_bienvenidoAdmin = new System.Windows.Forms.Label();
            this.txt_altaDni = new System.Windows.Forms.TextBox();
            this.lbl_altaDni = new System.Windows.Forms.Label();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.cmb_elegirAlumno = new System.Windows.Forms.ComboBox();
            this.btn_cambiarEstadoMateriaA = new System.Windows.Forms.Button();
            this.lbl_alumnoElegir = new System.Windows.Forms.Label();
            this.cmb_cambiarEstadoRyL = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(1, 233);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(544, 79);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "ALTA";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(285, 111);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(83, 20);
            this.lbl_contraseña.TabIndex = 1;
            this.lbl_contraseña.Text = "Contraseña";
            // 
            // lbl_altaNombre
            // 
            this.lbl_altaNombre.AutoSize = true;
            this.lbl_altaNombre.Location = new System.Drawing.Point(47, 63);
            this.lbl_altaNombre.Name = "lbl_altaNombre";
            this.lbl_altaNombre.Size = new System.Drawing.Size(64, 20);
            this.lbl_altaNombre.TabIndex = 2;
            this.lbl_altaNombre.Text = "Nombre";
            // 
            // txt_GmailAlta
            // 
            this.txt_GmailAlta.Location = new System.Drawing.Point(391, 159);
            this.txt_GmailAlta.Name = "txt_GmailAlta";
            this.txt_GmailAlta.Size = new System.Drawing.Size(154, 27);
            this.txt_GmailAlta.TabIndex = 3;
            // 
            // txt_contraseñaAtla
            // 
            this.txt_contraseñaAtla.Location = new System.Drawing.Point(391, 108);
            this.txt_contraseñaAtla.Name = "txt_contraseñaAtla";
            this.txt_contraseñaAtla.Size = new System.Drawing.Size(154, 27);
            this.txt_contraseñaAtla.TabIndex = 4;
            // 
            // cmb_usuarioALTA
            // 
            this.cmb_usuarioALTA.FormattingEnabled = true;
            this.cmb_usuarioALTA.Items.AddRange(new object[] {
            "Admin",
            "Profesor",
            "Alumno"});
            this.cmb_usuarioALTA.Location = new System.Drawing.Point(136, 163);
            this.cmb_usuarioALTA.Name = "cmb_usuarioALTA";
            this.cmb_usuarioALTA.Size = new System.Drawing.Size(125, 28);
            this.cmb_usuarioALTA.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo de usuario";
            // 
            // lbl_materiasAlta
            // 
            this.lbl_materiasAlta.AutoSize = true;
            this.lbl_materiasAlta.Location = new System.Drawing.Point(588, 111);
            this.lbl_materiasAlta.Name = "lbl_materiasAlta";
            this.lbl_materiasAlta.Size = new System.Drawing.Size(122, 20);
            this.lbl_materiasAlta.TabIndex = 7;
            this.lbl_materiasAlta.Text = "Nombre materia:";
            // 
            // lbl_cuatrimestreAlta
            // 
            this.lbl_cuatrimestreAlta.AutoSize = true;
            this.lbl_cuatrimestreAlta.Location = new System.Drawing.Point(614, 169);
            this.lbl_cuatrimestreAlta.Name = "lbl_cuatrimestreAlta";
            this.lbl_cuatrimestreAlta.Size = new System.Drawing.Size(96, 20);
            this.lbl_cuatrimestreAlta.TabIndex = 8;
            this.lbl_cuatrimestreAlta.Text = "Cuatrimestre:";
            // 
            // txt_materiaAlta
            // 
            this.txt_materiaAlta.Location = new System.Drawing.Point(727, 108);
            this.txt_materiaAlta.Name = "txt_materiaAlta";
            this.txt_materiaAlta.Size = new System.Drawing.Size(151, 27);
            this.txt_materiaAlta.TabIndex = 9;
            // 
            // btn_agregarMateria
            // 
            this.btn_agregarMateria.Location = new System.Drawing.Point(588, 233);
            this.btn_agregarMateria.Name = "btn_agregarMateria";
            this.btn_agregarMateria.Size = new System.Drawing.Size(302, 79);
            this.btn_agregarMateria.TabIndex = 11;
            this.btn_agregarMateria.Text = "Agregar materia";
            this.btn_agregarMateria.UseVisualStyleBackColor = true;
            this.btn_agregarMateria.Click += new System.EventHandler(this.btn_agregarMateria_Click);
            // 
            // cmb_profesorAlta
            // 
            this.cmb_profesorAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_profesorAlta.FormattingEnabled = true;
            this.cmb_profesorAlta.Location = new System.Drawing.Point(1020, 111);
            this.cmb_profesorAlta.Name = "cmb_profesorAlta";
            this.cmb_profesorAlta.Size = new System.Drawing.Size(151, 28);
            this.cmb_profesorAlta.TabIndex = 12;
            // 
            // cmb_profesorAltaMateria
            // 
            this.cmb_profesorAltaMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_profesorAltaMateria.FormattingEnabled = true;
            this.cmb_profesorAltaMateria.Location = new System.Drawing.Point(1020, 169);
            this.cmb_profesorAltaMateria.Name = "cmb_profesorAltaMateria";
            this.cmb_profesorAltaMateria.Size = new System.Drawing.Size(151, 28);
            this.cmb_profesorAltaMateria.TabIndex = 13;
            // 
            // lbl_profesorAlta
            // 
            this.lbl_profesorAlta.AutoSize = true;
            this.lbl_profesorAlta.Location = new System.Drawing.Point(931, 115);
            this.lbl_profesorAlta.Name = "lbl_profesorAlta";
            this.lbl_profesorAlta.Size = new System.Drawing.Size(67, 20);
            this.lbl_profesorAlta.TabIndex = 14;
            this.lbl_profesorAlta.Text = "Profesor:";
            // 
            // lbl_profesorAltaMateria
            // 
            this.lbl_profesorAltaMateria.AutoSize = true;
            this.lbl_profesorAltaMateria.Location = new System.Drawing.Point(935, 177);
            this.lbl_profesorAltaMateria.Name = "lbl_profesorAltaMateria";
            this.lbl_profesorAltaMateria.Size = new System.Drawing.Size(63, 20);
            this.lbl_profesorAltaMateria.TabIndex = 15;
            this.lbl_profesorAltaMateria.Text = "Materia:";
            // 
            // btn_altaProfesorMat
            // 
            this.btn_altaProfesorMat.Location = new System.Drawing.Point(918, 233);
            this.btn_altaProfesorMat.Name = "btn_altaProfesorMat";
            this.btn_altaProfesorMat.Size = new System.Drawing.Size(261, 79);
            this.btn_altaProfesorMat.TabIndex = 17;
            this.btn_altaProfesorMat.Text = "Asignar profesor a materia";
            this.btn_altaProfesorMat.UseVisualStyleBackColor = true;
            this.btn_altaProfesorMat.Click += new System.EventHandler(this.btn_altaProfesorMat_Click);
            // 
            // cmb_altaCuatrimestre
            // 
            this.cmb_altaCuatrimestre.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_altaCuatrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_altaCuatrimestre.FormattingEnabled = true;
            this.cmb_altaCuatrimestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmb_altaCuatrimestre.Location = new System.Drawing.Point(727, 163);
            this.cmb_altaCuatrimestre.Name = "cmb_altaCuatrimestre";
            this.cmb_altaCuatrimestre.Size = new System.Drawing.Size(151, 28);
            this.cmb_altaCuatrimestre.TabIndex = 18;
            // 
            // txt_apellidoAlta
            // 
            this.txt_apellidoAlta.AutoSize = true;
            this.txt_apellidoAlta.Location = new System.Drawing.Point(47, 114);
            this.txt_apellidoAlta.Name = "txt_apellidoAlta";
            this.txt_apellidoAlta.Size = new System.Drawing.Size(66, 20);
            this.txt_apellidoAlta.TabIndex = 19;
            this.txt_apellidoAlta.Text = "Apellido";
            // 
            // txt_altaApellido
            // 
            this.txt_altaApellido.Location = new System.Drawing.Point(136, 112);
            this.txt_altaApellido.Name = "txt_altaApellido";
            this.txt_altaApellido.Size = new System.Drawing.Size(125, 27);
            this.txt_altaApellido.TabIndex = 20;
            // 
            // txt_altaNombre
            // 
            this.txt_altaNombre.Location = new System.Drawing.Point(136, 56);
            this.txt_altaNombre.Name = "txt_altaNombre";
            this.txt_altaNombre.Size = new System.Drawing.Size(125, 27);
            this.txt_altaNombre.TabIndex = 21;
            // 
            // lbl_altaGmail
            // 
            this.lbl_altaGmail.AutoSize = true;
            this.lbl_altaGmail.Location = new System.Drawing.Point(320, 162);
            this.lbl_altaGmail.Name = "lbl_altaGmail";
            this.lbl_altaGmail.Size = new System.Drawing.Size(48, 20);
            this.lbl_altaGmail.TabIndex = 22;
            this.lbl_altaGmail.Text = "Gmail";
            // 
            // lbl_bienvenidoAdmin
            // 
            this.lbl_bienvenidoAdmin.AutoSize = true;
            this.lbl_bienvenidoAdmin.Location = new System.Drawing.Point(711, 28);
            this.lbl_bienvenidoAdmin.Name = "lbl_bienvenidoAdmin";
            this.lbl_bienvenidoAdmin.Size = new System.Drawing.Size(83, 20);
            this.lbl_bienvenidoAdmin.TabIndex = 23;
            this.lbl_bienvenidoAdmin.Text = "Bienvenido";
            // 
            // txt_altaDni
            // 
            this.txt_altaDni.Location = new System.Drawing.Point(391, 60);
            this.txt_altaDni.Name = "txt_altaDni";
            this.txt_altaDni.Size = new System.Drawing.Size(154, 27);
            this.txt_altaDni.TabIndex = 24;
            // 
            // lbl_altaDni
            // 
            this.lbl_altaDni.AutoSize = true;
            this.lbl_altaDni.Location = new System.Drawing.Point(318, 63);
            this.lbl_altaDni.Name = "lbl_altaDni";
            this.lbl_altaDni.Size = new System.Drawing.Size(35, 20);
            this.lbl_altaDni.TabIndex = 25;
            this.lbl_altaDni.Text = "DNI";
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Location = new System.Drawing.Point(1241, 72);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(63, 20);
            this.lbl_materia.TabIndex = 26;
            this.lbl_materia.Text = "Materia:";
            // 
            // cmb_materia
            // 
            this.cmb_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(1340, 64);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(151, 28);
            this.cmb_materia.TabIndex = 27;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(1209, 169);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(120, 40);
            this.lbl_estado.TabIndex = 28;
            this.lbl_estado.Text = "Cambiar cursada\r\nAlumno";
            // 
            // cmb_elegirAlumno
            // 
            this.cmb_elegirAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_elegirAlumno.FormattingEnabled = true;
            this.cmb_elegirAlumno.Location = new System.Drawing.Point(1340, 115);
            this.cmb_elegirAlumno.Name = "cmb_elegirAlumno";
            this.cmb_elegirAlumno.Size = new System.Drawing.Size(151, 28);
            this.cmb_elegirAlumno.TabIndex = 29;
            // 
            // btn_cambiarEstadoMateriaA
            // 
            this.btn_cambiarEstadoMateriaA.Location = new System.Drawing.Point(1209, 233);
            this.btn_cambiarEstadoMateriaA.Name = "btn_cambiarEstadoMateriaA";
            this.btn_cambiarEstadoMateriaA.Size = new System.Drawing.Size(294, 79);
            this.btn_cambiarEstadoMateriaA.TabIndex = 30;
            this.btn_cambiarEstadoMateriaA.Text = "Confirmar cambio de estado";
            this.btn_cambiarEstadoMateriaA.UseVisualStyleBackColor = true;
            this.btn_cambiarEstadoMateriaA.Click += new System.EventHandler(this.btn_cambiarEstadoMateriaA_Click);
            // 
            // lbl_alumnoElegir
            // 
            this.lbl_alumnoElegir.AutoSize = true;
            this.lbl_alumnoElegir.Location = new System.Drawing.Point(1200, 123);
            this.lbl_alumnoElegir.Name = "lbl_alumnoElegir";
            this.lbl_alumnoElegir.Size = new System.Drawing.Size(104, 20);
            this.lbl_alumnoElegir.TabIndex = 31;
            this.lbl_alumnoElegir.Text = "Elegir alumno:";
            // 
            // cmb_cambiarEstadoRyL
            // 
            this.cmb_cambiarEstadoRyL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cambiarEstadoRyL.FormattingEnabled = true;
            this.cmb_cambiarEstadoRyL.Items.AddRange(new object[] {
            "Regular",
            "Libre"});
            this.cmb_cambiarEstadoRyL.Location = new System.Drawing.Point(1335, 177);
            this.cmb_cambiarEstadoRyL.Name = "cmb_cambiarEstadoRyL";
            this.cmb_cambiarEstadoRyL.Size = new System.Drawing.Size(151, 28);
            this.cmb_cambiarEstadoRyL.TabIndex = 32;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(1209, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(261, 29);
            this.btn_refresh.TabIndex = 33;
            this.btn_refresh.Text = "Actualizar alumnos al elegir materia";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1020, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Matematica 1 harcodeado";
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1539, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cmb_cambiarEstadoRyL);
            this.Controls.Add(this.lbl_alumnoElegir);
            this.Controls.Add(this.btn_cambiarEstadoMateriaA);
            this.Controls.Add(this.cmb_elegirAlumno);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.cmb_materia);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.lbl_altaDni);
            this.Controls.Add(this.txt_altaDni);
            this.Controls.Add(this.lbl_bienvenidoAdmin);
            this.Controls.Add(this.lbl_altaGmail);
            this.Controls.Add(this.txt_altaNombre);
            this.Controls.Add(this.txt_altaApellido);
            this.Controls.Add(this.txt_apellidoAlta);
            this.Controls.Add(this.cmb_altaCuatrimestre);
            this.Controls.Add(this.btn_altaProfesorMat);
            this.Controls.Add(this.lbl_profesorAltaMateria);
            this.Controls.Add(this.lbl_profesorAlta);
            this.Controls.Add(this.cmb_profesorAltaMateria);
            this.Controls.Add(this.cmb_profesorAlta);
            this.Controls.Add(this.btn_agregarMateria);
            this.Controls.Add(this.txt_materiaAlta);
            this.Controls.Add(this.lbl_cuatrimestreAlta);
            this.Controls.Add(this.lbl_materiasAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_usuarioALTA);
            this.Controls.Add(this.txt_contraseñaAtla);
            this.Controls.Add(this.txt_GmailAlta);
            this.Controls.Add(this.lbl_altaNombre);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.btn_alta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdmin";
            this.Text = "Menu Admin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.Label lbl_altaNombre;
        private System.Windows.Forms.TextBox txt_GmailAlta;
        private System.Windows.Forms.TextBox txt_contraseñaAtla;
        private System.Windows.Forms.ComboBox cmb_usuarioALTA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_materiasAlta;
        private System.Windows.Forms.Label lbl_cuatrimestreAlta;
        private System.Windows.Forms.TextBox txt_materiaAlta;
        private System.Windows.Forms.Button btn_agregarMateria;
        private System.Windows.Forms.ComboBox cmb_profesorAlta;
        private System.Windows.Forms.ComboBox cmb_profesorAltaMateria;
        private System.Windows.Forms.Label lbl_profesorAlta;
        private System.Windows.Forms.Label lbl_profesorAltaMateria;
        private System.Windows.Forms.Button btn_altaProfesorMat;
        private System.Windows.Forms.ComboBox cmb_altaCuatrimestre;
        private System.Windows.Forms.Label txt_apellidoAlta;
        private System.Windows.Forms.TextBox txt_altaApellido;
        private System.Windows.Forms.TextBox txt_altaNombre;
        private System.Windows.Forms.Label lbl_altaGmail;
        private System.Windows.Forms.Label lbl_bienvenidoAdmin;
        private System.Windows.Forms.TextBox txt_altaDni;
        private System.Windows.Forms.Label lbl_altaDni;
        private System.Windows.Forms.Label lbl_materia;
        private System.Windows.Forms.ComboBox cmb_materia;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.ComboBox cmb_elegirAlumno;
        private System.Windows.Forms.Button btn_cambiarEstadoMateriaA;
        private System.Windows.Forms.Label lbl_alumnoElegir;
        private System.Windows.Forms.ComboBox cmb_cambiarEstadoRyL;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label2;
    }
}