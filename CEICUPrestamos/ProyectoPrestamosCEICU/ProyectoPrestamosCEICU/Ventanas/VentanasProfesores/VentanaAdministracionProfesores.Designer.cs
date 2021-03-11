
using ProyectoPrestamosCEICU.Clases_de_Control;

namespace ProyectoPrestamosCEICU.Ventanas.VentanasProfesores
{
    partial class VentanaAdministracionProfesores
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
            this.ListaProfesoresDGV = new System.Windows.Forms.DataGridView();
            this.LegajoRb = new System.Windows.Forms.RadioButton();
            this.NombreRB = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AgregarAlumnoBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProfesoresDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaProfesoresDGV
            // 
            this.ListaProfesoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProfesoresDGV.Location = new System.Drawing.Point(13, 62);
            this.ListaProfesoresDGV.Name = "ListaProfesoresDGV";
            this.ListaProfesoresDGV.Size = new System.Drawing.Size(757, 487);
            this.ListaProfesoresDGV.TabIndex = 0;
            // 
            // LegajoRb
            // 
            this.LegajoRb.AutoSize = true;
            this.LegajoRb.Location = new System.Drawing.Point(13, 13);
            this.LegajoRb.Name = "LegajoRb";
            this.LegajoRb.Size = new System.Drawing.Size(57, 17);
            this.LegajoRb.TabIndex = 1;
            this.LegajoRb.TabStop = true;
            this.LegajoRb.Text = "Legajo";
            this.LegajoRb.UseVisualStyleBackColor = true;
            // 
            // NombreRB
            // 
            this.NombreRB.AutoSize = true;
            this.NombreRB.Location = new System.Drawing.Point(105, 13);
            this.NombreRB.Name = "NombreRB";
            this.NombreRB.Size = new System.Drawing.Size(62, 17);
            this.NombreRB.TabIndex = 2;
            this.NombreRB.TabStop = true;
            this.NombreRB.Text = "Nombre";
            this.NombreRB.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(757, 20);
            this.textBox1.TabIndex = 3;
            // 
            // AgregarAlumnoBtn
            // 
            this.AgregarAlumnoBtn.Location = new System.Drawing.Point(196, 10);
            this.AgregarAlumnoBtn.Name = "AgregarAlumnoBtn";
            this.AgregarAlumnoBtn.Size = new System.Drawing.Size(110, 25);
            this.AgregarAlumnoBtn.TabIndex = 4;
            this.AgregarAlumnoBtn.Text = "Agregar Alumno";
            this.AgregarAlumnoBtn.UseVisualStyleBackColor = true;
            this.AgregarAlumnoBtn.Click += new System.EventHandler(this.AgregarAlumnoBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(506, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(660, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 25);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // VentanaAdministracionProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AgregarAlumnoBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NombreRB);
            this.Controls.Add(this.LegajoRb);
            this.Controls.Add(this.ListaProfesoresDGV);
            this.Name = "VentanaAdministracionProfesores";
            this.Text = "VentanaAdministracionProfesores";
            ((System.ComponentModel.ISupportInitialize)(this.ListaProfesoresDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaProfesoresDGV;
        private System.Windows.Forms.RadioButton LegajoRb;
        private System.Windows.Forms.RadioButton NombreRB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AgregarAlumnoBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private FachadaCEICU fachada = new FachadaCEICU();
    }
}