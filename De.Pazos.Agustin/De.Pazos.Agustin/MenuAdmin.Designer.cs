
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
            this.btn_asignarMateriaMenu = new System.Windows.Forms.Button();
            this.lbl_bienvenidoAdmin = new System.Windows.Forms.Label();
            this.btn_cambiarEstadoMateriaA = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_formAgregarMateria = new System.Windows.Forms.Button();
            this.btn_altaUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_calcularPromedio = new System.Windows.Forms.Button();
            this.btn_calcularNotaPromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_asignarMateriaMenu
            // 
            this.btn_asignarMateriaMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_asignarMateriaMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_asignarMateriaMenu.Location = new System.Drawing.Point(42, 183);
            this.btn_asignarMateriaMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_asignarMateriaMenu.Name = "btn_asignarMateriaMenu";
            this.btn_asignarMateriaMenu.Size = new System.Drawing.Size(117, 59);
            this.btn_asignarMateriaMenu.TabIndex = 17;
            this.btn_asignarMateriaMenu.Text = "Asignar profesor a materia";
            this.btn_asignarMateriaMenu.UseVisualStyleBackColor = true;
            this.btn_asignarMateriaMenu.Click += new System.EventHandler(this.btn_altaProfesorMat_Click);
            // 
            // lbl_bienvenidoAdmin
            // 
            this.lbl_bienvenidoAdmin.AutoSize = true;
            this.lbl_bienvenidoAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bienvenidoAdmin.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_bienvenidoAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_bienvenidoAdmin.Location = new System.Drawing.Point(75, 19);
            this.lbl_bienvenidoAdmin.Name = "lbl_bienvenidoAdmin";
            this.lbl_bienvenidoAdmin.Size = new System.Drawing.Size(183, 32);
            this.lbl_bienvenidoAdmin.TabIndex = 23;
            this.lbl_bienvenidoAdmin.Text = "Bienvenido";
            // 
            // btn_cambiarEstadoMateriaA
            // 
            this.btn_cambiarEstadoMateriaA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cambiarEstadoMateriaA.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_cambiarEstadoMateriaA.Location = new System.Drawing.Point(204, 183);
            this.btn_cambiarEstadoMateriaA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cambiarEstadoMateriaA.Name = "btn_cambiarEstadoMateriaA";
            this.btn_cambiarEstadoMateriaA.Size = new System.Drawing.Size(148, 59);
            this.btn_cambiarEstadoMateriaA.TabIndex = 30;
            this.btn_cambiarEstadoMateriaA.Text = "Confirmar cambio de estado";
            this.btn_cambiarEstadoMateriaA.UseVisualStyleBackColor = true;
            this.btn_cambiarEstadoMateriaA.Click += new System.EventHandler(this.btn_cambiarEstadoMateriaA_Click);
            // 
            // btn_formAgregarMateria
            // 
            this.btn_formAgregarMateria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_formAgregarMateria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_formAgregarMateria.Location = new System.Drawing.Point(204, 81);
            this.btn_formAgregarMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_formAgregarMateria.Name = "btn_formAgregarMateria";
            this.btn_formAgregarMateria.Size = new System.Drawing.Size(148, 52);
            this.btn_formAgregarMateria.TabIndex = 36;
            this.btn_formAgregarMateria.Text = "Agregar Materia";
            this.btn_formAgregarMateria.UseVisualStyleBackColor = true;
            this.btn_formAgregarMateria.Click += new System.EventHandler(this.btn_formAgregarMateria_Click_1);
            // 
            // btn_altaUsuario
            // 
            this.btn_altaUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_altaUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_altaUsuario.Location = new System.Drawing.Point(42, 81);
            this.btn_altaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_altaUsuario.Name = "btn_altaUsuario";
            this.btn_altaUsuario.Size = new System.Drawing.Size(117, 52);
            this.btn_altaUsuario.TabIndex = 37;
            this.btn_altaUsuario.Text = "Alta usuario";
            this.btn_altaUsuario.UseVisualStyleBackColor = true;
            this.btn_altaUsuario.Click += new System.EventHandler(this.btn_altaUsuario_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(384, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 38;
            this.button1.Text = "Inscribir Alumno Materia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_calcularPromedio
            // 
            this.btn_calcularPromedio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_calcularPromedio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_calcularPromedio.Location = new System.Drawing.Point(384, 183);
            this.btn_calcularPromedio.Name = "btn_calcularPromedio";
            this.btn_calcularPromedio.Size = new System.Drawing.Size(124, 59);
            this.btn_calcularPromedio.TabIndex = 39;
            this.btn_calcularPromedio.Text = "Calcular Promedios";
            this.btn_calcularPromedio.UseVisualStyleBackColor = true;
            this.btn_calcularPromedio.Click += new System.EventHandler(this.btn_calcularPromedio_Click);
            // 
            // btn_calcularNotaPromedio
            // 
            this.btn_calcularNotaPromedio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_calcularNotaPromedio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_calcularNotaPromedio.Location = new System.Drawing.Point(68, 279);
            this.btn_calcularNotaPromedio.Name = "btn_calcularNotaPromedio";
            this.btn_calcularNotaPromedio.Size = new System.Drawing.Size(426, 23);
            this.btn_calcularNotaPromedio.TabIndex = 40;
            this.btn_calcularNotaPromedio.Text = "Calcular Promedio Nota";
            this.btn_calcularNotaPromedio.UseVisualStyleBackColor = true;
            this.btn_calcularNotaPromedio.Click += new System.EventHandler(this.btn_calcularNotaPromedio_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::De.Pazos.Agustin.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 305);
            this.Controls.Add(this.btn_calcularNotaPromedio);
            this.Controls.Add(this.btn_calcularPromedio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_altaUsuario);
            this.Controls.Add(this.btn_formAgregarMateria);
            this.Controls.Add(this.btn_cambiarEstadoMateriaA);
            this.Controls.Add(this.lbl_bienvenidoAdmin);
            this.Controls.Add(this.btn_asignarMateriaMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Admin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_asignarMateriaMenu;
        private System.Windows.Forms.Label lbl_bienvenidoAdmin;
        private System.Windows.Forms.Button btn_cambiarEstadoMateriaA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_formAgregarMateria;
        private System.Windows.Forms.Button btn_altaUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_calcularPromedio;
        private System.Windows.Forms.Button btn_calcularNotaPromedio;
    }
}