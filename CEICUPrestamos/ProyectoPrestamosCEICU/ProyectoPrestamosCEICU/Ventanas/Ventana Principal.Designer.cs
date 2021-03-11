
namespace ProyectoPrestamosCEICU
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.AdministracionAlumnosMI = new System.Windows.Forms.MenuItem();
            this.AdministracionProfesoresMI = new System.Windows.Forms.MenuItem();
            this.AdministracionMaterialesMI = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.AdministracionAlumnosMI,
            this.AdministracionProfesoresMI,
            this.AdministracionMaterialesMI});
            // 
            // AdministracionAlumnosMI
            // 
            this.AdministracionAlumnosMI.Index = 0;
            this.AdministracionAlumnosMI.Text = "Administracion Alumnos";
            this.AdministracionAlumnosMI.Click += new System.EventHandler(this.AdministracionAlumnosMI_Click);
            // 
            // AdministracionProfesoresMI
            // 
            this.AdministracionProfesoresMI.Index = 1;
            this.AdministracionProfesoresMI.Text = "Administracion Profesores";
            this.AdministracionProfesoresMI.Click += new System.EventHandler(this.AdministracionProfesoresMI_Click);
            // 
            // AdministracionMaterialesMI
            // 
            this.AdministracionMaterialesMI.Index = 2;
            this.AdministracionMaterialesMI.Text = "Administracion Materiales";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 540);
            this.Menu = this.mainMenu1;
            this.Name = "VentanaPrincipal";
            this.Text = "Ventana Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem AdministracionAlumnosMI;
        private System.Windows.Forms.MenuItem AdministracionProfesoresMI;
        private System.Windows.Forms.MenuItem AdministracionMaterialesMI;
    }
}

