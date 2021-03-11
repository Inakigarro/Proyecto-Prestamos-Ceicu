
using ProyectoPrestamosCEICU.Clases_de_Control;

namespace ProyectoPrestamosCEICU.Ventanas
{
    partial class VentanaModificarAlumno
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
            this.CarreraAlumboCb = new System.Windows.Forms.ComboBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.LegajoAlumnoTb = new System.Windows.Forms.TextBox();
            this.CorreoAlumnoTb = new System.Windows.Forms.TextBox();
            this.TelefonoAlumnoTb = new System.Windows.Forms.TextBox();
            this.DireccionAlumnoTb = new System.Windows.Forms.TextBox();
            this.CiudadAlumnoTb = new System.Windows.Forms.TextBox();
            this.ApellidoAlumnoTb = new System.Windows.Forms.TextBox();
            this.NombreAlumnoTb = new System.Windows.Forms.TextBox();
            this.CarreraLbl = new System.Windows.Forms.Label();
            this.LegajoLbl = new System.Windows.Forms.Label();
            this.CorreoLbl = new System.Windows.Forms.Label();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.DireccionLbl = new System.Windows.Forms.Label();
            this.CiudadLbl = new System.Windows.Forms.Label();
            this.ApellidoLbl = new System.Windows.Forms.Label();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.AgregarCarreraBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarreraAlumboCb
            // 
            this.CarreraAlumboCb.FormattingEnabled = true;
            this.CarreraAlumboCb.Location = new System.Drawing.Point(324, 111);
            this.CarreraAlumboCb.Name = "CarreraAlumboCb";
            this.CarreraAlumboCb.Size = new System.Drawing.Size(183, 21);
            this.CarreraAlumboCb.TabIndex = 36;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(324, 163);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 35;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(176, 163);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 34;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // LegajoAlumnoTb
            // 
            this.LegajoAlumnoTb.Location = new System.Drawing.Point(324, 85);
            this.LegajoAlumnoTb.Name = "LegajoAlumnoTb";
            this.LegajoAlumnoTb.Size = new System.Drawing.Size(183, 20);
            this.LegajoAlumnoTb.TabIndex = 33;
            // 
            // CorreoAlumnoTb
            // 
            this.CorreoAlumnoTb.Location = new System.Drawing.Point(324, 59);
            this.CorreoAlumnoTb.Name = "CorreoAlumnoTb";
            this.CorreoAlumnoTb.Size = new System.Drawing.Size(183, 20);
            this.CorreoAlumnoTb.TabIndex = 32;
            // 
            // TelefonoAlumnoTb
            // 
            this.TelefonoAlumnoTb.Location = new System.Drawing.Point(324, 33);
            this.TelefonoAlumnoTb.Name = "TelefonoAlumnoTb";
            this.TelefonoAlumnoTb.Size = new System.Drawing.Size(183, 20);
            this.TelefonoAlumnoTb.TabIndex = 31;
            // 
            // DireccionAlumnoTb
            // 
            this.DireccionAlumnoTb.Location = new System.Drawing.Point(68, 111);
            this.DireccionAlumnoTb.Name = "DireccionAlumnoTb";
            this.DireccionAlumnoTb.Size = new System.Drawing.Size(183, 20);
            this.DireccionAlumnoTb.TabIndex = 30;
            // 
            // CiudadAlumnoTb
            // 
            this.CiudadAlumnoTb.Location = new System.Drawing.Point(68, 85);
            this.CiudadAlumnoTb.Name = "CiudadAlumnoTb";
            this.CiudadAlumnoTb.Size = new System.Drawing.Size(183, 20);
            this.CiudadAlumnoTb.TabIndex = 29;
            // 
            // ApellidoAlumnoTb
            // 
            this.ApellidoAlumnoTb.Location = new System.Drawing.Point(68, 59);
            this.ApellidoAlumnoTb.Name = "ApellidoAlumnoTb";
            this.ApellidoAlumnoTb.Size = new System.Drawing.Size(183, 20);
            this.ApellidoAlumnoTb.TabIndex = 28;
            // 
            // NombreAlumnoTb
            // 
            this.NombreAlumnoTb.Location = new System.Drawing.Point(68, 33);
            this.NombreAlumnoTb.Name = "NombreAlumnoTb";
            this.NombreAlumnoTb.Size = new System.Drawing.Size(183, 20);
            this.NombreAlumnoTb.TabIndex = 27;
            // 
            // CarreraLbl
            // 
            this.CarreraLbl.AutoSize = true;
            this.CarreraLbl.Location = new System.Drawing.Point(277, 114);
            this.CarreraLbl.Name = "CarreraLbl";
            this.CarreraLbl.Size = new System.Drawing.Size(41, 13);
            this.CarreraLbl.TabIndex = 26;
            this.CarreraLbl.Text = "Carrera";
            // 
            // LegajoLbl
            // 
            this.LegajoLbl.AutoSize = true;
            this.LegajoLbl.Location = new System.Drawing.Point(279, 88);
            this.LegajoLbl.Name = "LegajoLbl";
            this.LegajoLbl.Size = new System.Drawing.Size(39, 13);
            this.LegajoLbl.TabIndex = 25;
            this.LegajoLbl.Text = "Legajo";
            // 
            // CorreoLbl
            // 
            this.CorreoLbl.AutoSize = true;
            this.CorreoLbl.Location = new System.Drawing.Point(280, 62);
            this.CorreoLbl.Name = "CorreoLbl";
            this.CorreoLbl.Size = new System.Drawing.Size(38, 13);
            this.CorreoLbl.TabIndex = 24;
            this.CorreoLbl.Text = "Correo";
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.AutoSize = true;
            this.TelefonoLbl.Location = new System.Drawing.Point(269, 36);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(49, 13);
            this.TelefonoLbl.TabIndex = 23;
            this.TelefonoLbl.Text = "Telefono";
            // 
            // DireccionLbl
            // 
            this.DireccionLbl.AutoSize = true;
            this.DireccionLbl.Location = new System.Drawing.Point(10, 114);
            this.DireccionLbl.Name = "DireccionLbl";
            this.DireccionLbl.Size = new System.Drawing.Size(52, 13);
            this.DireccionLbl.TabIndex = 22;
            this.DireccionLbl.Text = "Direccion";
            // 
            // CiudadLbl
            // 
            this.CiudadLbl.AutoSize = true;
            this.CiudadLbl.Location = new System.Drawing.Point(22, 88);
            this.CiudadLbl.Name = "CiudadLbl";
            this.CiudadLbl.Size = new System.Drawing.Size(40, 13);
            this.CiudadLbl.TabIndex = 21;
            this.CiudadLbl.Text = "Ciudad";
            // 
            // ApellidoLbl
            // 
            this.ApellidoLbl.AutoSize = true;
            this.ApellidoLbl.Location = new System.Drawing.Point(18, 62);
            this.ApellidoLbl.Name = "ApellidoLbl";
            this.ApellidoLbl.Size = new System.Drawing.Size(44, 13);
            this.ApellidoLbl.TabIndex = 20;
            this.ApellidoLbl.Text = "Apellido";
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(18, 36);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(44, 13);
            this.NombreLbl.TabIndex = 19;
            this.NombreLbl.Text = "Nombre";
            // 
            // AgregarCarreraBtn
            // 
            this.AgregarCarreraBtn.Location = new System.Drawing.Point(513, 110);
            this.AgregarCarreraBtn.Name = "AgregarCarreraBtn";
            this.AgregarCarreraBtn.Size = new System.Drawing.Size(24, 20);
            this.AgregarCarreraBtn.TabIndex = 37;
            this.AgregarCarreraBtn.Text = "+";
            this.AgregarCarreraBtn.UseVisualStyleBackColor = true;
            this.AgregarCarreraBtn.Click += new System.EventHandler(this.AgregarCarreraBtn_Click);
            // 
            // VentanaModificarAlumno
            // 
            this.AcceptButton = this.AceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(566, 210);
            this.Controls.Add(this.AgregarCarreraBtn);
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
            this.Name = "VentanaModificarAlumno";
            this.Text = "VentanaModificarAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CarreraAlumboCb;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.TextBox LegajoAlumnoTb;
        private System.Windows.Forms.TextBox CorreoAlumnoTb;
        private System.Windows.Forms.TextBox TelefonoAlumnoTb;
        private System.Windows.Forms.TextBox DireccionAlumnoTb;
        private System.Windows.Forms.TextBox CiudadAlumnoTb;
        private System.Windows.Forms.TextBox ApellidoAlumnoTb;
        private System.Windows.Forms.TextBox NombreAlumnoTb;
        private System.Windows.Forms.Label CarreraLbl;
        private System.Windows.Forms.Label LegajoLbl;
        private System.Windows.Forms.Label CorreoLbl;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.Label DireccionLbl;
        private System.Windows.Forms.Label CiudadLbl;
        private System.Windows.Forms.Label ApellidoLbl;
        private System.Windows.Forms.Label NombreLbl;
        private FachadaCEICU fachada = new FachadaCEICU();
        private System.Windows.Forms.Button AgregarCarreraBtn;
    }
}