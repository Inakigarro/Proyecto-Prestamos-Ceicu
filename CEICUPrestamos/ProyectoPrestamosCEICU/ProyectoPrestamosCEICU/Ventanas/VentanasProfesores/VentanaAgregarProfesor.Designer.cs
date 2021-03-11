
using ProyectoPrestamosCEICU.Clases_de_Control;

namespace ProyectoPrestamosCEICU.Ventanas.VentanasProfesores
{
    partial class VentanaAgregarProfesor
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

        public VentanaAdministracionProfesores VentanaPadre
        {
            get { return ventanaPadre; }
            set { ventanaPadre = value; }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MateriaProfesorCb = new System.Windows.Forms.ComboBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.LegajoProfesorTb = new System.Windows.Forms.TextBox();
            this.CorreoProfesorTb = new System.Windows.Forms.TextBox();
            this.TelefonoProfesorTb = new System.Windows.Forms.TextBox();
            this.DireccionProfesorTb = new System.Windows.Forms.TextBox();
            this.CiudadProfesorTb = new System.Windows.Forms.TextBox();
            this.ApellidoProfesorTb = new System.Windows.Forms.TextBox();
            this.NombreProfesorTb = new System.Windows.Forms.TextBox();
            this.MateriaLbl = new System.Windows.Forms.Label();
            this.LegajoLbl = new System.Windows.Forms.Label();
            this.CorreoLbl = new System.Windows.Forms.Label();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.DireccionLbl = new System.Windows.Forms.Label();
            this.CiudadLbl = new System.Windows.Forms.Label();
            this.ApellidoLbl = new System.Windows.Forms.Label();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MateriaProfesorCb
            // 
            this.MateriaProfesorCb.FormattingEnabled = true;
            this.MateriaProfesorCb.Location = new System.Drawing.Point(352, 113);
            this.MateriaProfesorCb.Name = "MateriaProfesorCb";
            this.MateriaProfesorCb.Size = new System.Drawing.Size(183, 21);
            this.MateriaProfesorCb.TabIndex = 36;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(352, 153);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 35;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(197, 153);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 34;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // LegajoProfesorTb
            // 
            this.LegajoProfesorTb.Location = new System.Drawing.Point(352, 87);
            this.LegajoProfesorTb.Name = "LegajoProfesorTb";
            this.LegajoProfesorTb.Size = new System.Drawing.Size(183, 20);
            this.LegajoProfesorTb.TabIndex = 33;
            // 
            // CorreoProfesorTb
            // 
            this.CorreoProfesorTb.Location = new System.Drawing.Point(352, 61);
            this.CorreoProfesorTb.Name = "CorreoProfesorTb";
            this.CorreoProfesorTb.Size = new System.Drawing.Size(183, 20);
            this.CorreoProfesorTb.TabIndex = 32;
            // 
            // TelefonoProfesorTb
            // 
            this.TelefonoProfesorTb.Location = new System.Drawing.Point(352, 35);
            this.TelefonoProfesorTb.Name = "TelefonoProfesorTb";
            this.TelefonoProfesorTb.Size = new System.Drawing.Size(183, 20);
            this.TelefonoProfesorTb.TabIndex = 31;
            // 
            // DireccionProfesorTb
            // 
            this.DireccionProfesorTb.Location = new System.Drawing.Point(89, 113);
            this.DireccionProfesorTb.Name = "DireccionProfesorTb";
            this.DireccionProfesorTb.Size = new System.Drawing.Size(183, 20);
            this.DireccionProfesorTb.TabIndex = 30;
            // 
            // CiudadProfesorTb
            // 
            this.CiudadProfesorTb.Location = new System.Drawing.Point(89, 87);
            this.CiudadProfesorTb.Name = "CiudadProfesorTb";
            this.CiudadProfesorTb.Size = new System.Drawing.Size(183, 20);
            this.CiudadProfesorTb.TabIndex = 29;
            // 
            // ApellidoProfesorTb
            // 
            this.ApellidoProfesorTb.Location = new System.Drawing.Point(89, 61);
            this.ApellidoProfesorTb.Name = "ApellidoProfesorTb";
            this.ApellidoProfesorTb.Size = new System.Drawing.Size(183, 20);
            this.ApellidoProfesorTb.TabIndex = 28;
            // 
            // NombreProfesorTb
            // 
            this.NombreProfesorTb.Location = new System.Drawing.Point(89, 35);
            this.NombreProfesorTb.Name = "NombreProfesorTb";
            this.NombreProfesorTb.Size = new System.Drawing.Size(183, 20);
            this.NombreProfesorTb.TabIndex = 27;
            // 
            // MateriaLbl
            // 
            this.MateriaLbl.AutoSize = true;
            this.MateriaLbl.Location = new System.Drawing.Point(305, 116);
            this.MateriaLbl.Name = "MateriaLbl";
            this.MateriaLbl.Size = new System.Drawing.Size(42, 13);
            this.MateriaLbl.TabIndex = 26;
            this.MateriaLbl.Text = "Materia";
            // 
            // LegajoLbl
            // 
            this.LegajoLbl.AutoSize = true;
            this.LegajoLbl.Location = new System.Drawing.Point(307, 90);
            this.LegajoLbl.Name = "LegajoLbl";
            this.LegajoLbl.Size = new System.Drawing.Size(39, 13);
            this.LegajoLbl.TabIndex = 25;
            this.LegajoLbl.Text = "Legajo";
            // 
            // CorreoLbl
            // 
            this.CorreoLbl.AutoSize = true;
            this.CorreoLbl.Location = new System.Drawing.Point(308, 64);
            this.CorreoLbl.Name = "CorreoLbl";
            this.CorreoLbl.Size = new System.Drawing.Size(38, 13);
            this.CorreoLbl.TabIndex = 24;
            this.CorreoLbl.Text = "Correo";
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.AutoSize = true;
            this.TelefonoLbl.Location = new System.Drawing.Point(297, 38);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(49, 13);
            this.TelefonoLbl.TabIndex = 23;
            this.TelefonoLbl.Text = "Telefono";
            // 
            // DireccionLbl
            // 
            this.DireccionLbl.AutoSize = true;
            this.DireccionLbl.Location = new System.Drawing.Point(31, 116);
            this.DireccionLbl.Name = "DireccionLbl";
            this.DireccionLbl.Size = new System.Drawing.Size(52, 13);
            this.DireccionLbl.TabIndex = 22;
            this.DireccionLbl.Text = "Direccion";
            // 
            // CiudadLbl
            // 
            this.CiudadLbl.AutoSize = true;
            this.CiudadLbl.Location = new System.Drawing.Point(43, 90);
            this.CiudadLbl.Name = "CiudadLbl";
            this.CiudadLbl.Size = new System.Drawing.Size(40, 13);
            this.CiudadLbl.TabIndex = 21;
            this.CiudadLbl.Text = "Ciudad";
            // 
            // ApellidoLbl
            // 
            this.ApellidoLbl.AutoSize = true;
            this.ApellidoLbl.Location = new System.Drawing.Point(39, 64);
            this.ApellidoLbl.Name = "ApellidoLbl";
            this.ApellidoLbl.Size = new System.Drawing.Size(44, 13);
            this.ApellidoLbl.TabIndex = 20;
            this.ApellidoLbl.Text = "Apellido";
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(39, 38);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(44, 13);
            this.NombreLbl.TabIndex = 19;
            this.NombreLbl.Text = "Nombre";
            // 
            // VentanaAgregarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 210);
            this.Controls.Add(this.MateriaProfesorCb);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.LegajoProfesorTb);
            this.Controls.Add(this.CorreoProfesorTb);
            this.Controls.Add(this.TelefonoProfesorTb);
            this.Controls.Add(this.DireccionProfesorTb);
            this.Controls.Add(this.CiudadProfesorTb);
            this.Controls.Add(this.ApellidoProfesorTb);
            this.Controls.Add(this.NombreProfesorTb);
            this.Controls.Add(this.MateriaLbl);
            this.Controls.Add(this.LegajoLbl);
            this.Controls.Add(this.CorreoLbl);
            this.Controls.Add(this.TelefonoLbl);
            this.Controls.Add(this.DireccionLbl);
            this.Controls.Add(this.CiudadLbl);
            this.Controls.Add(this.ApellidoLbl);
            this.Controls.Add(this.NombreLbl);
            this.Name = "VentanaAgregarProfesor";
            this.Text = "VentanaAgregarProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MateriaProfesorCb;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.TextBox LegajoProfesorTb;
        private System.Windows.Forms.TextBox CorreoProfesorTb;
        private System.Windows.Forms.TextBox TelefonoProfesorTb;
        private System.Windows.Forms.TextBox DireccionProfesorTb;
        private System.Windows.Forms.TextBox CiudadProfesorTb;
        private System.Windows.Forms.TextBox ApellidoProfesorTb;
        private System.Windows.Forms.TextBox NombreProfesorTb;
        private System.Windows.Forms.Label MateriaLbl;
        private System.Windows.Forms.Label LegajoLbl;
        private System.Windows.Forms.Label CorreoLbl;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.Label DireccionLbl;
        private System.Windows.Forms.Label CiudadLbl;
        private System.Windows.Forms.Label ApellidoLbl;
        private System.Windows.Forms.Label NombreLbl;
        private VentanaAdministracionProfesores ventanaPadre;
        private FachadaCEICU fachada = new FachadaCEICU();
    }
}