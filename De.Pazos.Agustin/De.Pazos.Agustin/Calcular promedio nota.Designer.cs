namespace De.Pazos.Agustin
{
    partial class Calcular_promedio_nota
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
            this.btn_notaPromedio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_materia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_notaPromedio
            // 
            this.btn_notaPromedio.Location = new System.Drawing.Point(182, 97);
            this.btn_notaPromedio.Name = "btn_notaPromedio";
            this.btn_notaPromedio.Size = new System.Drawing.Size(105, 88);
            this.btn_notaPromedio.TabIndex = 0;
            this.btn_notaPromedio.Text = "Calcular la nota promedio";
            this.btn_notaPromedio.UseVisualStyleBackColor = true;
            this.btn_notaPromedio.Click += new System.EventHandler(this.btn_notaPromedio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(112, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materia:";
            // 
            // cmb_materia
            // 
            this.cmb_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materia.FormattingEnabled = true;
            this.cmb_materia.Location = new System.Drawing.Point(182, 41);
            this.cmb_materia.Name = "cmb_materia";
            this.cmb_materia.Size = new System.Drawing.Size(121, 23);
            this.cmb_materia.TabIndex = 2;
            // 
            // Calcular_promedio_nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::De.Pazos.Agustin.Properties.Resources.imagen1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 208);
            this.Controls.Add(this.cmb_materia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_notaPromedio);
            this.Name = "Calcular_promedio_nota";
            this.Text = "Calcular_promedio_nota";
            this.Load += new System.EventHandler(this.Calcular_promedio_nota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_notaPromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_materia;
    }
}