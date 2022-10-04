
namespace De.Pazos.Agustin
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.lbl_inicioSesion = new System.Windows.Forms.Label();
            this.btn_logIn = new System.Windows.Forms.Button();
            this.btn_adminH = new System.Windows.Forms.Button();
            this.btn_profesorH = new System.Windows.Forms.Button();
            this.btn_alumnoH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(60, 111);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(59, 20);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Location = new System.Drawing.Point(60, 184);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(83, 20);
            this.lbl_contrasena.TabIndex = 1;
            this.lbl_contrasena.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_usuario.Location = new System.Drawing.Point(166, 101);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(242, 34);
            this.txt_usuario.TabIndex = 2;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_contraseña.Location = new System.Drawing.Point(166, 174);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(242, 34);
            this.txt_contraseña.TabIndex = 3;
            this.txt_contraseña.Tag = "";
            // 
            // lbl_inicioSesion
            // 
            this.lbl_inicioSesion.AutoSize = true;
            this.lbl_inicioSesion.Location = new System.Drawing.Point(220, 33);
            this.lbl_inicioSesion.Name = "lbl_inicioSesion";
            this.lbl_inicioSesion.Size = new System.Drawing.Size(113, 20);
            this.lbl_inicioSesion.TabIndex = 4;
            this.lbl_inicioSesion.Text = "Inicio de Sesion";
            // 
            // btn_logIn
            // 
            this.btn_logIn.Location = new System.Drawing.Point(60, 256);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(348, 29);
            this.btn_logIn.TabIndex = 5;
            this.btn_logIn.Text = "Aceptar";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // btn_adminH
            // 
            this.btn_adminH.Location = new System.Drawing.Point(12, 368);
            this.btn_adminH.Name = "btn_adminH";
            this.btn_adminH.Size = new System.Drawing.Size(154, 29);
            this.btn_adminH.TabIndex = 6;
            this.btn_adminH.Text = "Admin harcodeado";
            this.btn_adminH.UseVisualStyleBackColor = true;
            this.btn_adminH.Click += new System.EventHandler(this.btn_adminH_Click);
            // 
            // btn_profesorH
            // 
            this.btn_profesorH.Location = new System.Drawing.Point(166, 368);
            this.btn_profesorH.Name = "btn_profesorH";
            this.btn_profesorH.Size = new System.Drawing.Size(167, 29);
            this.btn_profesorH.TabIndex = 7;
            this.btn_profesorH.Text = "Profesor harcodeado";
            this.btn_profesorH.UseVisualStyleBackColor = true;
            this.btn_profesorH.Click += new System.EventHandler(this.btn_profesorH_Click);
            // 
            // btn_alumnoH
            // 
            this.btn_alumnoH.Location = new System.Drawing.Point(339, 368);
            this.btn_alumnoH.Name = "btn_alumnoH";
            this.btn_alumnoH.Size = new System.Drawing.Size(167, 29);
            this.btn_alumnoH.TabIndex = 8;
            this.btn_alumnoH.Text = "Alumno harcodeado";
            this.btn_alumnoH.UseVisualStyleBackColor = true;
            this.btn_alumnoH.Click += new System.EventHandler(this.btn_alumnoH_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 446);
            this.Controls.Add(this.btn_alumnoH);
            this.Controls.Add(this.btn_profesorH);
            this.Controls.Add(this.btn_adminH);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.lbl_inicioSesion);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.lbl_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label lbl_inicioSesion;
        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.Button btn_adminH;
        private System.Windows.Forms.Button btn_profesorH;
        private System.Windows.Forms.Button btn_alumnoH;
    }
}