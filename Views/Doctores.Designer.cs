namespace PruebaParcial1.Views
{
    partial class Doctores
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
            this.telefono_Doc_tx = new System.Windows.Forms.TextBox();
            this.Apellido_Doc_tx = new System.Windows.Forms.TextBox();
            this.Nombre_Doc_tx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Especialiad_doc_tx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Eliminar_bt
            // 
            this.Eliminar_bt.Location = new System.Drawing.Point(612, 433);
            this.Eliminar_bt.Name = "Eliminar_bt";
            this.Eliminar_bt.Size = new System.Drawing.Size(194, 49);
            this.Eliminar_bt.TabIndex = 25;
            this.Eliminar_bt.Text = "Eliminar";
            this.Eliminar_bt.UseVisualStyleBackColor = true;
            this.Eliminar_bt.Click += new System.EventHandler(this.Eliminar_bt_Click);
            // 
            // Lista_Doctores
            // 
            this.Lista_Doctores.FormattingEnabled = true;
            this.Lista_Doctores.ItemHeight = 20;
            this.Lista_Doctores.Location = new System.Drawing.Point(132, 542);
            this.Lista_Doctores.Name = "Lista_Doctores";
            this.Lista_Doctores.Size = new System.Drawing.Size(1118, 224);
            this.Lista_Doctores.TabIndex = 24;
            this.Lista_Doctores.SelectedIndexChanged += new System.EventHandler(this.Lista_Doctores_SelectedIndexChanged);
            // 
            // Modificar_bt
            // 
            this.Modificar_bt.Location = new System.Drawing.Point(907, 433);
            this.Modificar_bt.Name = "Modificar_bt";
            this.Modificar_bt.Size = new System.Drawing.Size(194, 49);
            this.Modificar_bt.TabIndex = 23;
            this.Modificar_bt.Text = "Modificar";
            this.Modificar_bt.UseVisualStyleBackColor = true;
            this.Modificar_bt.Click += new System.EventHandler(this.Modificar_bt_Click);
            // 
            // Agragar_bt
            // 
            this.Agragar_bt.Location = new System.Drawing.Point(316, 433);
            this.Agragar_bt.Name = "Agragar_bt";
            this.Agragar_bt.Size = new System.Drawing.Size(194, 49);
            this.Agragar_bt.TabIndex = 22;
            this.Agragar_bt.Text = "Agregar";
            this.Agragar_bt.UseVisualStyleBackColor = true;
            this.Agragar_bt.Click += new System.EventHandler(this.Agragar_bt_Click);
            // 
            // telefono_Doc_tx
            // 
            this.telefono_Doc_tx.Location = new System.Drawing.Point(647, 366);
            this.telefono_Doc_tx.Name = "telefono_Doc_tx";
            this.telefono_Doc_tx.Size = new System.Drawing.Size(293, 26);
            this.telefono_Doc_tx.TabIndex = 20;
            this.telefono_Doc_tx.TextChanged += new System.EventHandler(this.telefono_Doc_tx_TextChanged);
            // 
            // Apellido_Doc_tx
            // 
            this.Apellido_Doc_tx.Location = new System.Drawing.Point(647, 257);
            this.Apellido_Doc_tx.Name = "Apellido_Doc_tx";
            this.Apellido_Doc_tx.Size = new System.Drawing.Size(293, 26);
            this.Apellido_Doc_tx.TabIndex = 19;
            this.Apellido_Doc_tx.TextChanged += new System.EventHandler(this.Apellido_Doc_tx_TextChanged);
            // 
            // Nombre_Doc_tx
            // 
            this.Nombre_Doc_tx.Location = new System.Drawing.Point(647, 202);
            this.Nombre_Doc_tx.Name = "Nombre_Doc_tx";
            this.Nombre_Doc_tx.Size = new System.Drawing.Size(293, 26);
            this.Nombre_Doc_tx.TabIndex = 18;
            this.Nombre_Doc_tx.TextChanged += new System.EventHandler(this.Nombre_Doc_tx_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(499, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingreso de Doctores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Especialiad_doc_tx
            // 
            this.Especialiad_doc_tx.Location = new System.Drawing.Point(647, 307);
            this.Especialiad_doc_tx.Name = "Especialiad_doc_tx";
            this.Especialiad_doc_tx.Size = new System.Drawing.Size(293, 26);
            this.Especialiad_doc_tx.TabIndex = 27;
            this.Especialiad_doc_tx.TextChanged += new System.EventHandler(this.Especialiad_doc_tx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Especialidad:";
            // 
            // Doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 768);
            this.Controls.Add(this.Especialiad_doc_tx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Eliminar_bt);
            this.Controls.Add(this.Lista_Doctores);
            this.Controls.Add(this.Modificar_bt);
            this.Controls.Add(this.Agragar_bt);
            this.Controls.Add(this.telefono_Doc_tx);
            this.Controls.Add(this.Apellido_Doc_tx);
            this.Controls.Add(this.Nombre_Doc_tx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Doctores";
            this.Text = "Doctores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminar_bt;
        private System.Windows.Forms.ListBox Lista_Doctores;
        private System.Windows.Forms.Button Modificar_bt;
        private System.Windows.Forms.Button Agragar_bt;
        private System.Windows.Forms.TextBox telefono_Doc_tx;
        private System.Windows.Forms.TextBox Apellido_Doc_tx;
        private System.Windows.Forms.TextBox Nombre_Doc_tx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Especialiad_doc_tx;
        private System.Windows.Forms.Label label4;
    }
}