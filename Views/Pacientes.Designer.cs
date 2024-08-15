namespace PruebaParcial1
{
    partial class Pacientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nombre_paciente_tx = new System.Windows.Forms.TextBox();
            this.Apellido_cliente_tx = new System.Windows.Forms.TextBox();
            this.telefono_paciente_tx = new System.Windows.Forms.TextBox();
            this.Fechas_paciente_date = new System.Windows.Forms.DateTimePicker();
            this.Agragar_bt = new System.Windows.Forms.Button();
            this.Modificar_bt = new System.Windows.Forms.Button();
            this.Lista_Pacientes = new System.Windows.Forms.ListBox();
            this.Eliminar_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso de pacientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // Nombre_paciente_tx
            // 
            this.Nombre_paciente_tx.Location = new System.Drawing.Point(575, 146);
            this.Nombre_paciente_tx.Name = "Nombre_paciente_tx";
            this.Nombre_paciente_tx.Size = new System.Drawing.Size(293, 26);
            this.Nombre_paciente_tx.TabIndex = 5;
            this.Nombre_paciente_tx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Apellido_cliente_tx
            // 
            this.Apellido_cliente_tx.Location = new System.Drawing.Point(575, 201);
            this.Apellido_cliente_tx.Name = "Apellido_cliente_tx";
            this.Apellido_cliente_tx.Size = new System.Drawing.Size(293, 26);
            this.Apellido_cliente_tx.TabIndex = 6;
            this.Apellido_cliente_tx.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // telefono_paciente_tx
            // 
            this.telefono_paciente_tx.Location = new System.Drawing.Point(575, 310);
            this.telefono_paciente_tx.Name = "telefono_paciente_tx";
            this.telefono_paciente_tx.Size = new System.Drawing.Size(293, 26);
            this.telefono_paciente_tx.TabIndex = 7;
            this.telefono_paciente_tx.TextChanged += new System.EventHandler(this.telefono_paciente_tx_TextChanged);
            // 
            // Fechas_paciente_date
            // 
            this.Fechas_paciente_date.Location = new System.Drawing.Point(575, 254);
            this.Fechas_paciente_date.Name = "Fechas_paciente_date";
            this.Fechas_paciente_date.Size = new System.Drawing.Size(293, 26);
            this.Fechas_paciente_date.TabIndex = 8;
            this.Fechas_paciente_date.ValueChanged += new System.EventHandler(this.Fechas_paciente_date_ValueChanged);
            // 
            // Agragar_bt
            // 
            this.Agragar_bt.Location = new System.Drawing.Point(244, 377);
            this.Agragar_bt.Name = "Agragar_bt";
            this.Agragar_bt.Size = new System.Drawing.Size(194, 49);
            this.Agragar_bt.TabIndex = 9;
            this.Agragar_bt.Text = "Agregar";
            this.Agragar_bt.UseVisualStyleBackColor = true;
            this.Agragar_bt.Click += new System.EventHandler(this.Agragar_bt_Click);
            // 
            // Modificar_bt
            // 
            this.Modificar_bt.Location = new System.Drawing.Point(835, 377);
            this.Modificar_bt.Name = "Modificar_bt";
            this.Modificar_bt.Size = new System.Drawing.Size(194, 49);
            this.Modificar_bt.TabIndex = 10;
            this.Modificar_bt.Text = "Modificar";
            this.Modificar_bt.UseVisualStyleBackColor = true;
            this.Modificar_bt.Click += new System.EventHandler(this.Modificar_bt_Click);
            // 
            // Lista_Pacientes
            // 
            this.Lista_Pacientes.FormattingEnabled = true;
            this.Lista_Pacientes.ItemHeight = 20;
            this.Lista_Pacientes.Location = new System.Drawing.Point(60, 486);
            this.Lista_Pacientes.Name = "Lista_Pacientes";
            this.Lista_Pacientes.Size = new System.Drawing.Size(1118, 224);
            this.Lista_Pacientes.TabIndex = 11;
            this.Lista_Pacientes.SelectedIndexChanged += new System.EventHandler(this.Lista_Pacientes_SelectedIndexChanged);
            // 
            // Eliminar_bt
            // 
            this.Eliminar_bt.Location = new System.Drawing.Point(540, 377);
            this.Eliminar_bt.Name = "Eliminar_bt";
            this.Eliminar_bt.Size = new System.Drawing.Size(194, 49);
            this.Eliminar_bt.TabIndex = 12;
            this.Eliminar_bt.Text = "Eliminar";
            this.Eliminar_bt.UseVisualStyleBackColor = true;
            this.Eliminar_bt.Click += new System.EventHandler(this.Eliminar_bt_Click);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 724);
            this.Controls.Add(this.Eliminar_bt);
            this.Controls.Add(this.Lista_Pacientes);
            this.Controls.Add(this.Modificar_bt);
            this.Controls.Add(this.Agragar_bt);
            this.Controls.Add(this.Fechas_paciente_date);
            this.Controls.Add(this.telefono_paciente_tx);
            this.Controls.Add(this.Apellido_cliente_tx);
            this.Controls.Add(this.Nombre_paciente_tx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nombre_paciente_tx;
        private System.Windows.Forms.TextBox Apellido_cliente_tx;
        private System.Windows.Forms.TextBox telefono_paciente_tx;
        private System.Windows.Forms.DateTimePicker Fechas_paciente_date;
        private System.Windows.Forms.Button Agragar_bt;
        private System.Windows.Forms.Button Modificar_bt;
        private System.Windows.Forms.ListBox Lista_Pacientes;
        private System.Windows.Forms.Button Eliminar_bt;
    }
}

