
namespace ProyectoPrestamosCEICU.Ventanas.VentanasAlumnos
{
    partial class VentanaAgregarCarrera
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
            this.CodigoLbl = new System.Windows.Forms.Label();
            this.NombreLbl = new System.Windows.Forms.Label();
            this.CodigoCarreraTb = new System.Windows.Forms.TextBox();
            this.NombreCarreraTb = new System.Windows.Forms.TextBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(24, 29);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(43, 13);
            this.CodigoLbl.TabIndex = 0;
            this.CodigoLbl.Text = "Codigo:";
            // 
            // NombreLbl
            // 
            this.NombreLbl.AutoSize = true;
            this.NombreLbl.Location = new System.Drawing.Point(20, 55);
            this.NombreLbl.Name = "NombreLbl";
            this.NombreLbl.Size = new System.Drawing.Size(47, 13);
            this.NombreLbl.TabIndex = 1;
            this.NombreLbl.Text = "Nombre:";
            // 
            // CodigoCarreraTb
            // 
            this.CodigoCarreraTb.Location = new System.Drawing.Point(73, 26);
            this.CodigoCarreraTb.Name = "CodigoCarreraTb";
            this.CodigoCarreraTb.Size = new System.Drawing.Size(193, 20);
            this.CodigoCarreraTb.TabIndex = 2;
            // 
            // NombreCarreraTb
            // 
            this.NombreCarreraTb.Location = new System.Drawing.Point(73, 52);
            this.NombreCarreraTb.Name = "NombreCarreraTb";
            this.NombreCarreraTb.Size = new System.Drawing.Size(193, 20);
            this.NombreCarreraTb.TabIndex = 3;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(38, 100);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 4;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(160, 100);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 5;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // VentanaAgregarCarrera
            // 
            this.AcceptButton = this.AceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(283, 135);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.NombreCarreraTb);
            this.Controls.Add(this.CodigoCarreraTb);
            this.Controls.Add(this.NombreLbl);
            this.Controls.Add(this.CodigoLbl);
            this.Name = "VentanaAgregarCarrera";
            this.Text = "VentanaAgregarCarrera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodigoLbl;
        private System.Windows.Forms.Label NombreLbl;
        private System.Windows.Forms.TextBox CodigoCarreraTb;
        private System.Windows.Forms.TextBox NombreCarreraTb;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}