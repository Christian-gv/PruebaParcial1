namespace PruebaParcial1.Views
{
    partial class General
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
            this.label1 = new System.Windows.Forms.Label();
            this.Agr_pacientes = new System.Windows.Forms.Button();
            this.Agr_Doctores = new System.Windows.Forms.Button();
            this.Crear_citas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Gestión de Hospitales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Agr_pacientes
            // 
            this.Agr_pacientes.Location = new System.Drawing.Point(264, 528);
            this.Agr_pacientes.Name = "Agr_pacientes";
            this.Agr_pacientes.Size = new System.Drawing.Size(181, 50);
            this.Agr_pacientes.TabIndex = 1;
            this.Agr_pacientes.Text = "Pacientes";
            this.Agr_pacientes.UseVisualStyleBackColor = true;
            this.Agr_pacientes.Click += new System.EventHandler(this.Agr_pacientes_Click);
            // 
            // Agr_Doctores
            // 
            this.Agr_Doctores.Location = new System.Drawing.Point(780, 530);
            this.Agr_Doctores.Name = "Agr_Doctores";
            this.Agr_Doctores.Size = new System.Drawing.Size(181, 50);
            this.Agr_Doctores.TabIndex = 2;
            this.Agr_Doctores.Text = "Doctores";
            this.Agr_Doctores.UseVisualStyleBackColor = true;
            this.Agr_Doctores.Click += new System.EventHandler(this.Agr_Doctores_Click);
            // 
            // Crear_citas
            // 
            this.Crear_citas.Location = new System.Drawing.Point(1303, 528);
            this.Crear_citas.Name = "Crear_citas";
            this.Crear_citas.Size = new System.Drawing.Size(181, 50);
            this.Crear_citas.TabIndex = 3;
            this.Crear_citas.Text = "Citas";
            this.Crear_citas.UseVisualStyleBackColor = true;
            this.Crear_citas.Click += new System.EventHandler(this.Crear_citas_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 761);
            this.Controls.Add(this.Crear_citas);
            this.Controls.Add(this.Agr_Doctores);
            this.Controls.Add(this.Agr_pacientes);
            this.Controls.Add(this.label1);
            this.Name = "General";
            this.Text = "General";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.General_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Agr_pacientes;
        private System.Windows.Forms.Button Agr_Doctores;
        private System.Windows.Forms.Button Crear_citas;
    }
}