
using ProyectoPrestamosCEICU.Clases_de_Control;

namespace ProyectoPrestamosCEICU.Ventanas
{
    partial class VentanaAdministracionAlumnos
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
            this.AgregarAlumnoBtn = new System.Windows.Forms.Button();
            this.ModificarAlumnoBtn = new System.Windows.Forms.Button();
            this.EliminarAlumnoBtn = new System.Windows.Forms.Button();
            this.BuscarAlumnoBtn = new System.Windows.Forms.Button();
            this.NombreRb = new System.Windows.Forms.RadioButton();
            this.LegajoRb = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListaAlumnosDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlumnosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarAlumnoBtn
            // 
            this.AgregarAlumnoBtn.Location = new System.Drawing.Point(244, 12);
            this.AgregarAlumnoBtn.Name = "AgregarAlumnoBtn";
            this.AgregarAlumnoBtn.Size = new System.Drawing.Size(100, 25);
            this.AgregarAlumnoBtn.TabIndex = 0;
            this.AgregarAlumnoBtn.Text = "Agregar Alumno";
            this.AgregarAlumnoBtn.UseVisualStyleBackColor = true;
            this.AgregarAlumnoBtn.Click += new System.EventHandler(this.AgregarAlumnoBtn_Click);
            // 
            // ModificarAlumnoBtn
            // 
            this.ModificarAlumnoBtn.Location = new System.Drawing.Point(350, 12);
            this.ModificarAlumnoBtn.Name = "ModificarAlumnoBtn";
            this.ModificarAlumnoBtn.Size = new System.Drawing.Size(100, 25);
            this.ModificarAlumnoBtn.TabIndex = 1;
            this.ModificarAlumnoBtn.Text = "Modificar Alumno";
            this.ModificarAlumnoBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarAlumnoBtn
            // 
            this.EliminarAlumnoBtn.Location = new System.Drawing.Point(456, 12);
            this.EliminarAlumnoBtn.Name = "EliminarAlumnoBtn";
            this.EliminarAlumnoBtn.Size = new System.Drawing.Size(100, 25);
            this.EliminarAlumnoBtn.TabIndex = 2;
            this.EliminarAlumnoBtn.Text = "Eliminar Alumno";
            this.EliminarAlumnoBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarAlumnoBtn
            // 
            this.BuscarAlumnoBtn.Location = new System.Drawing.Point(138, 12);
            this.BuscarAlumnoBtn.Name = "BuscarAlumnoBtn";
            this.BuscarAlumnoBtn.Size = new System.Drawing.Size(100, 25);
            this.BuscarAlumnoBtn.TabIndex = 3;
            this.BuscarAlumnoBtn.Text = "Buscar Alumno";
            this.BuscarAlumnoBtn.UseVisualStyleBackColor = true;
            // 
            // NombreRb
            // 
            this.NombreRb.AutoSize = true;
            this.NombreRb.Location = new System.Drawing.Point(70, 16);
            this.NombreRb.Name = "NombreRb";
            this.NombreRb.Size = new System.Drawing.Size(62, 17);
            this.NombreRb.TabIndex = 4;
            this.NombreRb.TabStop = true;
            this.NombreRb.Text = "Nombre";
            this.NombreRb.UseVisualStyleBackColor = true;
            // 
            // LegajoRb
            // 
            this.LegajoRb.AutoSize = true;
            this.LegajoRb.Location = new System.Drawing.Point(7, 16);
            this.LegajoRb.Name = "LegajoRb";
            this.LegajoRb.Size = new System.Drawing.Size(57, 17);
            this.LegajoRb.TabIndex = 5;
            this.LegajoRb.TabStop = true;
            this.LegajoRb.Text = "Legajo";
            this.LegajoRb.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(549, 20);
            this.textBox1.TabIndex = 6;
            // 
            // ListaAlumnosDGV
            // 
            this.ListaAlumnosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAlumnosDGV.Location = new System.Drawing.Point(10, 68);
            this.ListaAlumnosDGV.Name = "ListaAlumnosDGV";
            this.ListaAlumnosDGV.Size = new System.Drawing.Size(545, 372);
            this.ListaAlumnosDGV.TabIndex = 7;
            // 
            // VentanaAdministracionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.ListaAlumnosDGV);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LegajoRb);
            this.Controls.Add(this.NombreRb);
            this.Controls.Add(this.BuscarAlumnoBtn);
            this.Controls.Add(this.EliminarAlumnoBtn);
            this.Controls.Add(this.ModificarAlumnoBtn);
            this.Controls.Add(this.AgregarAlumnoBtn);
            this.Name = "VentanaAdministracionAlumnos";
            this.Text = "Administracion Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlumnosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarAlumnoBtn;
        private System.Windows.Forms.Button ModificarAlumnoBtn;
        private System.Windows.Forms.Button EliminarAlumnoBtn;
        private System.Windows.Forms.Button BuscarAlumnoBtn;
        private System.Windows.Forms.RadioButton NombreRb;
        private System.Windows.Forms.RadioButton LegajoRb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView ListaAlumnosDGV;
        private FachadaCEICU fachada = new FachadaCEICU();
    }
}