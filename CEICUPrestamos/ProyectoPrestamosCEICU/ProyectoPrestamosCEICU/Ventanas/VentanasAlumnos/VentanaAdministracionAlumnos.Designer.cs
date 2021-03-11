
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
            this.NombreRb = new System.Windows.Forms.RadioButton();
            this.LegajoRb = new System.Windows.Forms.RadioButton();
            this.ParametroBusquedaTb = new System.Windows.Forms.TextBox();
            this.ListaAlumnosDGV = new System.Windows.Forms.DataGridView();
            this.HabilitarAlumnoBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AltaSecretario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlumnosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarAlumnoBtn
            // 
            this.AgregarAlumnoBtn.Location = new System.Drawing.Point(199, 10);
            this.AgregarAlumnoBtn.Name = "AgregarAlumnoBtn";
            this.AgregarAlumnoBtn.Size = new System.Drawing.Size(110, 25);
            this.AgregarAlumnoBtn.TabIndex = 0;
            this.AgregarAlumnoBtn.Text = "Agregar Alumno";
            this.AgregarAlumnoBtn.UseVisualStyleBackColor = true;
            this.AgregarAlumnoBtn.Click += new System.EventHandler(this.AgregarAlumnoBtn_Click);
            // 
            // ModificarAlumnoBtn
            // 
            this.ModificarAlumnoBtn.Location = new System.Drawing.Point(351, 10);
            this.ModificarAlumnoBtn.Name = "ModificarAlumnoBtn";
            this.ModificarAlumnoBtn.Size = new System.Drawing.Size(110, 25);
            this.ModificarAlumnoBtn.TabIndex = 1;
            this.ModificarAlumnoBtn.Text = "Modificar Alumno";
            this.ModificarAlumnoBtn.UseVisualStyleBackColor = true;
            this.ModificarAlumnoBtn.Click += new System.EventHandler(this.ModificarAlumnoBtn_Click);
            // 
            // NombreRb
            // 
            this.NombreRb.AutoSize = true;
            this.NombreRb.Location = new System.Drawing.Point(105, 13);
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
            this.LegajoRb.Location = new System.Drawing.Point(13, 13);
            this.LegajoRb.Name = "LegajoRb";
            this.LegajoRb.Size = new System.Drawing.Size(57, 17);
            this.LegajoRb.TabIndex = 5;
            this.LegajoRb.TabStop = true;
            this.LegajoRb.Text = "Legajo";
            this.LegajoRb.UseVisualStyleBackColor = true;
            // 
            // ParametroBusquedaTb
            // 
            this.ParametroBusquedaTb.Location = new System.Drawing.Point(14, 36);
            this.ParametroBusquedaTb.Name = "ParametroBusquedaTb";
            this.ParametroBusquedaTb.Size = new System.Drawing.Size(903, 20);
            this.ParametroBusquedaTb.TabIndex = 6;
            this.ParametroBusquedaTb.TextChanged += new System.EventHandler(this.ParametroBusquedaTb_TextChanged);
            // 
            // ListaAlumnosDGV
            // 
            this.ListaAlumnosDGV.AllowUserToOrderColumns = true;
            this.ListaAlumnosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAlumnosDGV.Location = new System.Drawing.Point(14, 62);
            this.ListaAlumnosDGV.MultiSelect = false;
            this.ListaAlumnosDGV.Name = "ListaAlumnosDGV";
            this.ListaAlumnosDGV.ReadOnly = true;
            this.ListaAlumnosDGV.RowHeadersVisible = false;
            this.ListaAlumnosDGV.RowTemplate.ReadOnly = true;
            this.ListaAlumnosDGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaAlumnosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaAlumnosDGV.Size = new System.Drawing.Size(903, 487);
            this.ListaAlumnosDGV.TabIndex = 7;
            // 
            // HabilitarAlumnoBtn
            // 
            this.HabilitarAlumnoBtn.Location = new System.Drawing.Point(503, 10);
            this.HabilitarAlumnoBtn.Name = "HabilitarAlumnoBtn";
            this.HabilitarAlumnoBtn.Size = new System.Drawing.Size(110, 25);
            this.HabilitarAlumnoBtn.TabIndex = 8;
            this.HabilitarAlumnoBtn.Text = "Habilitar Alumno";
            this.HabilitarAlumnoBtn.UseVisualStyleBackColor = true;
            this.HabilitarAlumnoBtn.Click += new System.EventHandler(this.HabilitarAlumnoBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Deshabilitar Alumno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AltaSecretario
            // 
            this.AltaSecretario.Location = new System.Drawing.Point(807, 10);
            this.AltaSecretario.Name = "AltaSecretario";
            this.AltaSecretario.Size = new System.Drawing.Size(110, 25);
            this.AltaSecretario.TabIndex = 10;
            this.AltaSecretario.Text = "Asignar Secretaria";
            this.AltaSecretario.UseVisualStyleBackColor = true;
            this.AltaSecretario.Click += new System.EventHandler(this.AltaSecretario_Click);
            // 
            // VentanaAdministracionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(931, 561);
            this.Controls.Add(this.AltaSecretario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HabilitarAlumnoBtn);
            this.Controls.Add(this.ListaAlumnosDGV);
            this.Controls.Add(this.ParametroBusquedaTb);
            this.Controls.Add(this.LegajoRb);
            this.Controls.Add(this.NombreRb);
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
        private System.Windows.Forms.RadioButton NombreRb;
        private System.Windows.Forms.RadioButton LegajoRb;
        private System.Windows.Forms.TextBox ParametroBusquedaTb;
        private System.Windows.Forms.DataGridView ListaAlumnosDGV;
        private FachadaCEICU fachada = new FachadaCEICU();
        private System.Windows.Forms.Button HabilitarAlumnoBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AltaSecretario;
    }
}