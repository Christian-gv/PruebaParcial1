namespace PruebaParcial1.Views
{
    partial class Cita_medica
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
            this.Eliminar_bt = new System.Windows.Forms.Button();
            this.Lista_Doctores = new System.Windows.Forms.ListBox();
            this.Modificar_bt = new System.Windows.Forms.Button();
            this.Agragar_bt = new System.Windows.Forms.Button();
            this.Apellido_Doc_tx = new System.Windows.Forms.TextBox();
            this.Nombre_Pac_tx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lista_Pacientes = new System.Windows.Forms.ListBox();
            this.Motivo_cita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fecha_cita = new System.Windows.Forms.DateTimePicker();
            this.Lista_citas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Eliminar_bt
            // 
            this.Eliminar_bt.Location = new System.Drawing.Point(554, 315);
            this.Eliminar_bt.Name = "Eliminar_bt";
            this.Eliminar_bt.Size = new System.Drawing.Size(194, 49);
            this.Eliminar_bt.TabIndex = 38;
            this.Eliminar_bt.Text = "Eliminar";
            this.Eliminar_bt.UseVisualStyleBackColor = true;
            this.Eliminar_bt.Click += new System.EventHandler(this.Eliminar_bt_Click);
            // 
            // Lista_Doctores
            // 
            this.Lista_Doctores.FormattingEnabled = true;
            this.Lista_Doctores.ItemHeight = 20;
            this.Lista_Doctores.Location = new System.Drawing.Point(2, 379);
            this.Lista_Doctores.Name = "Lista_Doctores";
            this.Lista_Doctores.Size = new System.Drawing.Size(250, 384);
            this.Lista_Doctores.TabIndex = 37;
            this.Lista_Doctores.SelectedIndexChanged += new System.EventHandler(this.Lista_Doctores_SelectedIndexChanged);
            // 
            // Modificar_bt
            // 
            this.Modificar_bt.Location = new System.Drawing.Point(789, 315);
            this.Modificar_bt.Name = "Modificar_bt";
            this.Modificar_bt.Size = new System.Drawing.Size(194, 49);
            this.Modificar_bt.TabIndex = 36;
            this.Modificar_bt.Text = "Modificar";
            this.Modificar_bt.UseVisualStyleBackColor = true;
            this.Modificar_bt.Click += new System.EventHandler(this.Modificar_bt_Click);
            // 
            // Agragar_bt
            // 
            this.Agragar_bt.Location = new System.Drawing.Point(344, 315);
            this.Agragar_bt.Name = "Agragar_bt";
            this.Agragar_bt.Size = new System.Drawing.Size(194, 49);
            this.Agragar_bt.TabIndex = 35;
            this.Agragar_bt.Text = "Agregar";
            this.Agragar_bt.UseVisualStyleBackColor = true;
            this.Agragar_bt.Click += new System.EventHandler(this.Agragar_bt_Click);
            // 
            // Apellido_Doc_tx
            // 
            this.Apellido_Doc_tx.Location = new System.Drawing.Point(574, 171);
            this.Apellido_Doc_tx.Name = "Apellido_Doc_tx";
            this.Apellido_Doc_tx.Size = new System.Drawing.Size(293, 26);
            this.Apellido_Doc_tx.TabIndex = 33;
            this.Apellido_Doc_tx.TextChanged += new System.EventHandler(this.Apellido_Doc_tx_TextChanged);
            // 
            // Nombre_Pac_tx
            // 
            this.Nombre_Pac_tx.Location = new System.Drawing.Point(574, 116);
            this.Nombre_Pac_tx.Name = "Nombre_Pac_tx";
            this.Nombre_Pac_tx.Size = new System.Drawing.Size(293, 26);
            this.Nombre_Pac_tx.TabIndex = 32;
            this.Nombre_Pac_tx.TextChanged += new System.EventHandler(this.Nombre_Doc_tx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Paciente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 55);
            this.label1.TabIndex = 28;
            this.label1.Text = "Agendar Cita";
            // 
            // Lista_Pacientes
            // 
            this.Lista_Pacientes.FormattingEnabled = true;
            this.Lista_Pacientes.ItemHeight = 20;
            this.Lista_Pacientes.Location = new System.Drawing.Point(288, 379);
            this.Lista_Pacientes.Name = "Lista_Pacientes";
            this.Lista_Pacientes.Size = new System.Drawing.Size(250, 384);
            this.Lista_Pacientes.TabIndex = 39;
            this.Lista_Pacientes.SelectedIndexChanged += new System.EventHandler(this.Lista_Pacientes_SelectedIndexChanged);
            // 
            // Motivo_cita
            // 
            this.Motivo_cita.Location = new System.Drawing.Point(574, 273);
            this.Motivo_cita.Name = "Motivo_cita";
            this.Motivo_cita.Size = new System.Drawing.Size(293, 26);
            this.Motivo_cita.TabIndex = 41;
            this.Motivo_cita.TextChanged += new System.EventHandler(this.Motivo_cita_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Motivo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fecha:";
            // 
            // Fecha_cita
            // 
            this.Fecha_cita.Location = new System.Drawing.Point(574, 223);
            this.Fecha_cita.Name = "Fecha_cita";
            this.Fecha_cita.Size = new System.Drawing.Size(293, 26);
            this.Fecha_cita.TabIndex = 43;
            this.Fecha_cita.ValueChanged += new System.EventHandler(this.Fecha_cita_ValueChanged);
            // 
            // Lista_citas
            // 
            this.Lista_citas.FormattingEnabled = true;
            this.Lista_citas.ItemHeight = 20;
            this.Lista_citas.Location = new System.Drawing.Point(617, 379);
            this.Lista_citas.Name = "Lista_citas";
            this.Lista_citas.Size = new System.Drawing.Size(633, 384);
            this.Lista_citas.TabIndex = 44;
            this.Lista_citas.SelectedIndexChanged += new System.EventHandler(this.Lista_citas_SelectedIndexChanged);
            // 
            // Cita_medica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 765);
            this.Controls.Add(this.Lista_citas);
            this.Controls.Add(this.Fecha_cita);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Motivo_cita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lista_Pacientes);
            this.Controls.Add(this.Eliminar_bt);
            this.Controls.Add(this.Lista_Doctores);
            this.Controls.Add(this.Modificar_bt);
            this.Controls.Add(this.Agragar_bt);
            this.Controls.Add(this.Apellido_Doc_tx);
            this.Controls.Add(this.Nombre_Pac_tx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cita_medica";
            this.Text = "Cita_medica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Eliminar_bt;
        private System.Windows.Forms.ListBox Lista_Doctores;
        private System.Windows.Forms.Button Modificar_bt;
        private System.Windows.Forms.Button Agragar_bt;
        private System.Windows.Forms.TextBox Apellido_Doc_tx;
        private System.Windows.Forms.TextBox Nombre_Pac_tx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lista_Pacientes;
        private System.Windows.Forms.TextBox Motivo_cita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Fecha_cita;
        private System.Windows.Forms.ListBox Lista_citas;
    }
}