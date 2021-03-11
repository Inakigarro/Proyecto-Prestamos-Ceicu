
namespace ProyectoPrestamosCEICU.Ventanas.VentanasSecretarios
{
    partial class VentanaModificarSecretaria
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
            this.IdSecretariaLbl = new System.Windows.Forms.Label();
            this.NombreSecretariaLbl = new System.Windows.Forms.Label();
            this.IdSecretariaTb = new System.Windows.Forms.TextBox();
            this.NombreSecretariaTb = new System.Windows.Forms.TextBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdSecretariaLbl
            // 
            this.IdSecretariaLbl.AutoSize = true;
            this.IdSecretariaLbl.Location = new System.Drawing.Point(13, 13);
            this.IdSecretariaLbl.Name = "IdSecretariaLbl";
            this.IdSecretariaLbl.Size = new System.Drawing.Size(67, 13);
            this.IdSecretariaLbl.TabIndex = 0;
            this.IdSecretariaLbl.Text = "IdSecretaria:";
            // 
            // NombreSecretariaLbl
            // 
            this.NombreSecretariaLbl.AutoSize = true;
            this.NombreSecretariaLbl.Location = new System.Drawing.Point(33, 39);
            this.NombreSecretariaLbl.Name = "NombreSecretariaLbl";
            this.NombreSecretariaLbl.Size = new System.Drawing.Size(47, 13);
            this.NombreSecretariaLbl.TabIndex = 1;
            this.NombreSecretariaLbl.Text = "Nombre:";
            // 
            // IdSecretariaTb
            // 
            this.IdSecretariaTb.Location = new System.Drawing.Point(86, 9);
            this.IdSecretariaTb.Name = "IdSecretariaTb";
            this.IdSecretariaTb.Size = new System.Drawing.Size(185, 20);
            this.IdSecretariaTb.TabIndex = 2;
            // 
            // NombreSecretariaTb
            // 
            this.NombreSecretariaTb.Location = new System.Drawing.Point(86, 35);
            this.NombreSecretariaTb.Name = "NombreSecretariaTb";
            this.NombreSecretariaTb.Size = new System.Drawing.Size(185, 20);
            this.NombreSecretariaTb.TabIndex = 3;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(36, 85);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 5;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(169, 85);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 6;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // VentanaModificarSecretaria
            // 
            this.AcceptButton = this.AceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(283, 135);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.NombreSecretariaTb);
            this.Controls.Add(this.IdSecretariaTb);
            this.Controls.Add(this.NombreSecretariaLbl);
            this.Controls.Add(this.IdSecretariaLbl);
            this.Name = "VentanaModificarSecretaria";
            this.Text = "VentanaModificarSecretaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdSecretariaLbl;
        private System.Windows.Forms.Label NombreSecretariaLbl;
        private System.Windows.Forms.TextBox IdSecretariaTb;
        private System.Windows.Forms.TextBox NombreSecretariaTb;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
    }
}