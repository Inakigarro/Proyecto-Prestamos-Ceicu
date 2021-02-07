
using ProyectoPrestamosCEICU.Clases_de_Control;

namespace ProyectoPrestamosCEICU.Ventanas
{
    partial class VentanaAgregarAlumno
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
        public VentanaAdministracionAlumnos VAAlumnos 
        {
            set { ventanaAdministracionAlumnos = value; }
            get { return ventanaAdministracionAlumnos; }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NombreLbl = new System.Windows.Forms.Label();
            this.ApellidoLbl = new System.Windows.Forms.Label();
            this.CiudadLbl = new System.Windows.Forms.Label();
            this.DireccionLbl = new System.Windows.Forms.Label();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.CorreoLbl = new System.Windows.Forms.Label();
            this.LegajoLbl = new System.Windows.Forms.Label();
            this.CarreraLbl = new System.Windows.Forms.Label();
            this.NombreAlumnoTb = new System.Windows.Forms.TextBox();
            this.ApellidoAlumnoTb = new System.Windows.Forms.TextBox();
            this.CiudadAlumnoTb = new System.Windows.Forms.TextBox();
            this.DireccionAlumnoTb = new System.Windows.Forms.TextBox();
            this.TelefonoAlumnoTb = new System.Windows.Forms.TextBox();
            this.CorreoAlumnoTb = new System.Windows.Forms.TextBox();
            this.LegajoAlumnoTb = new System.Windows.Forms.TextBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.CarreraAlumboCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(28, 39);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(44, 13);
            this.NombreLbl.TabIndex = 0;
            this.NombreLbl.Text = "Nombre";
            // 
            // ApellidoLbl
            // 
            this.ApellidoLbl.AutoSize = true;
            this.ApellidoLbl.Location = new System.Drawing.Point(28, 65);
            this.ApellidoLbl.Name = "ApellidoLbl";
            this.ApellidoLbl.Size = new System.Drawing.Size(44, 13);
            this.ApellidoLbl.TabIndex = 1;
            this.ApellidoLbl.Text = "Apellido";
            // 
            // CiudadLbl
            // 
            this.CiudadLbl.AutoSize = true;
            this.CiudadLbl.Location = new System.Drawing.Point(32, 91);
            this.CiudadLbl.Name = "CiudadLbl";
            this.CiudadLbl.Size = new System.Drawing.Size(40, 13);
            this.CiudadLbl.TabIndex = 2;
            this.CiudadLbl.Text = "Ciudad";
            // 
            // DireccionLbl
            // 
            this.DireccionLbl.AutoSize = true;
            this.DireccionLbl.Location = new System.Drawing.Point(20, 117);
            this.DireccionLbl.Name = "DireccionLbl";
            this.DireccionLbl.Size = new System.Drawing.Size(52, 13);
            this.DireccionLbl.TabIndex = 3;
            this.DireccionLbl.Text = "Direccion";
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.AutoSize = true;
            this.TelefonoLbl.Location = new System.Drawing.Point(184, 39);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(49, 13);
            this.TelefonoLbl.TabIndex = 4;
            this.TelefonoLbl.Text = "Telefono";
            // 
            // CorreoLbl
            // 
            this.CorreoLbl.AutoSize = true;
            this.CorreoLbl.Location = new System.Drawing.Point(195, 65);
            this.CorreoLbl.Name = "CorreoLbl";
            this.CorreoLbl.Size = new System.Drawing.Size(38, 13);
            this.CorreoLbl.TabIndex = 5;
            this.CorreoLbl.Text = "Correo";
            // 
            // LegajoLbl
            // 
            this.LegajoLbl.AutoSize = true;
            this.LegajoLbl.Location = new System.Drawing.Point(194, 91);
            this.LegajoLbl.Name = "LegajoLbl";
            this.LegajoLbl.Size = new System.Drawing.Size(39, 13);
            this.LegajoLbl.TabIndex = 6;
            this.LegajoLbl.Text = "Legajo";
            // 
            // CarreraLbl
            // 
            this.CarreraLbl.AutoSize = true;
            this.CarreraLbl.Location = new System.Drawing.Point(192, 117);
            this.CarreraLbl.Name = "CarreraLbl";
            this.CarreraLbl.Size = new System.Drawing.Size(41, 13);
            this.CarreraLbl.TabIndex = 7;
            this.CarreraLbl.Text = "Carrera";
            // 
            // NombreAlumnoTb
            // 
            this.NombreAlumnoTb.Location = new System.Drawing.Point(78, 36);
            this.NombreAlumnoTb.Name = "NombreAlumnoTb";
            this.NombreAlumnoTb.Size = new System.Drawing.Size(100, 20);
            this.NombreAlumnoTb.TabIndex = 8;
            // 
            // ApellidoAlumnoTb
            // 
            this.ApellidoAlumnoTb.Location = new System.Drawing.Point(78, 62);
            this.ApellidoAlumnoTb.Name = "ApellidoAlumnoTb";
            this.ApellidoAlumnoTb.Size = new System.Drawing.Size(100, 20);
            this.ApellidoAlumnoTb.TabIndex = 9;
            // 
            // CiudadAlumnoTb
            // 
            this.CiudadAlumnoTb.Location = new System.Drawing.Point(78, 88);
            this.CiudadAlumnoTb.Name = "CiudadAlumnoTb";
            this.CiudadAlumnoTb.Size = new System.Drawing.Size(100, 20);
            this.CiudadAlumnoTb.TabIndex = 10;
            // 
            // DireccionAlumnoTb
            // 
            this.DireccionAlumnoTb.Location = new System.Drawing.Point(78, 114);
            this.DireccionAlumnoTb.Name = "DireccionAlumnoTb";
            this.DireccionAlumnoTb.Size = new System.Drawing.Size(100, 20);
            this.DireccionAlumnoTb.TabIndex = 11;
            // 
            // TelefonoAlumnoTb
            // 
            this.TelefonoAlumnoTb.Location = new System.Drawing.Point(239, 36);
            this.TelefonoAlumnoTb.Name = "TelefonoAlumnoTb";
            this.TelefonoAlumnoTb.Size = new System.Drawing.Size(100, 20);
            this.TelefonoAlumnoTb.TabIndex = 12;
            // 
            // CorreoAlumnoTb
            // 
            this.CorreoAlumnoTb.Location = new System.Drawing.Point(239, 62);
            this.CorreoAlumnoTb.Name = "CorreoAlumnoTb";
            this.CorreoAlumnoTb.Size = new System.Drawing.Size(100, 20);
            this.CorreoAlumnoTb.TabIndex = 13;
            // 
            // LegajoAlumnoTb
            // 
            this.LegajoAlumnoTb.Location = new System.Drawing.Point(239, 88);
            this.LegajoAlumnoTb.Name = "LegajoAlumnoTb";
            this.LegajoAlumnoTb.Size = new System.Drawing.Size(100, 20);
            this.LegajoAlumnoTb.TabIndex = 14;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(89, 154);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 16;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(252, 154);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 17;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // CarreraAlumboCb
            // 
            this.CarreraAlumboCb.FormattingEnabled = true;
            this.CarreraAlumboCb.Location = new System.Drawing.Point(239, 114);
            this.CarreraAlumboCb.Name = "CarreraAlumboCb";
            this.CarreraAlumboCb.Size = new System.Drawing.Size(100, 21);
            this.CarreraAlumboCb.TabIndex = 18;
            // 
            // VentanaAgregarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 210);
            this.Controls.Add(this.CarreraAlumboCb);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.LegajoAlumnoTb);
            this.Controls.Add(this.CorreoAlumnoTb);
            this.Controls.Add(this.TelefonoAlumnoTb);
            this.Controls.Add(this.DireccionAlumnoTb);
            this.Controls.Add(this.CiudadAlumnoTb);
            this.Controls.Add(this.ApellidoAlumnoTb);
            this.Controls.Add(this.NombreAlumnoTb);
            this.Controls.Add(this.CarreraLbl);
            this.Controls.Add(this.LegajoLbl);
            this.Controls.Add(this.CorreoLbl);
            this.Controls.Add(this.TelefonoLbl);
            this.Controls.Add(this.DireccionLbl);
            this.Controls.Add(this.CiudadLbl);
            this.Controls.Add(this.ApellidoLbl);
            this.Controls.Add(this.NombreLbl);
            this.Name = "VentanaAgregarAlumno";
            this.Text = "VentanaAgregarAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.Label ApellidoLbl;
        private System.Windows.Forms.Label CiudadLbl;
        private System.Windows.Forms.Label DireccionLbl;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.Label CorreoLbl;
        private System.Windows.Forms.Label LegajoLbl;
        private System.Windows.Forms.Label CarreraLbl;
        private System.Windows.Forms.TextBox NombreAlumnoTb;
        private System.Windows.Forms.TextBox ApellidoAlumnoTb;
        private System.Windows.Forms.TextBox CiudadAlumnoTb;
        private System.Windows.Forms.TextBox DireccionAlumnoTb;
        private System.Windows.Forms.TextBox TelefonoAlumnoTb;
        private System.Windows.Forms.TextBox CorreoAlumnoTb;
        private System.Windows.Forms.TextBox LegajoAlumnoTb;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private FachadaCEICU fachada = new FachadaCEICU();
        private System.Windows.Forms.ComboBox CarreraAlumboCb;
        private VentanaAdministracionAlumnos ventanaAdministracionAlumnos;
    }
}