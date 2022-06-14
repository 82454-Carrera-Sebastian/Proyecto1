
namespace Proyecto1
{
    partial class Pantalla
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
            this.btnRegistrarIng = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.richTextBoxMotivo = new System.Windows.Forms.RichTextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.maskedTextBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.labelRT = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelActual = new System.Windows.Forms.Label();
            this.labelseleccion = new System.Windows.Forms.Label();
            this.dataGridViewRT = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarIng
            // 
            this.btnRegistrarIng.Location = new System.Drawing.Point(12, 33);
            this.btnRegistrarIng.Name = "btnRegistrarIng";
            this.btnRegistrarIng.Size = new System.Drawing.Size(146, 54);
            this.btnRegistrarIng.TabIndex = 0;
            this.btnRegistrarIng.Text = "Registrar ingreso Mantenimiento Correctivo";
            this.btnRegistrarIng.UseVisualStyleBackColor = true;
            this.btnRegistrarIng.Click += new System.EventHandler(this.btnRegistrarIng_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(13, 295);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(125, 13);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha fin mantenimiento:";
            this.lblfecha.Visible = false;
            // 
            // richTextBoxMotivo
            // 
            this.richTextBoxMotivo.Location = new System.Drawing.Point(167, 321);
            this.richTextBoxMotivo.Name = "richTextBoxMotivo";
            this.richTextBoxMotivo.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxMotivo.TabIndex = 4;
            this.richTextBoxMotivo.Text = "";
            this.richTextBoxMotivo.Visible = false;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(82, 324);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 5;
            this.lblMotivo.Text = "Motivo:";
            this.lblMotivo.Visible = false;
            // 
            // maskedTextBoxFecha
            // 
            this.maskedTextBoxFecha.Location = new System.Drawing.Point(167, 292);
            this.maskedTextBoxFecha.Mask = "00/00/0000 00:00";
            this.maskedTextBoxFecha.Name = "maskedTextBoxFecha";
            this.maskedTextBoxFecha.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxFecha.TabIndex = 7;
            this.maskedTextBoxFecha.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxFecha.Visible = false;
            // 
            // labelRT
            // 
            this.labelRT.AutoSize = true;
            this.labelRT.Location = new System.Drawing.Point(50, 267);
            this.labelRT.Name = "labelRT";
            this.labelRT.Size = new System.Drawing.Size(88, 13);
            this.labelRT.TabIndex = 9;
            this.labelRT.Text = "RTseleccionado:";
            this.labelRT.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(296, 321);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 39);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Visible = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(13, 14);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 10;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.Location = new System.Drawing.Point(65, 14);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(37, 13);
            this.labelActual.TabIndex = 11;
            this.labelActual.Text = "Actual";
            // 
            // labelseleccion
            // 
            this.labelseleccion.AutoSize = true;
            this.labelseleccion.Location = new System.Drawing.Point(167, 266);
            this.labelseleccion.Name = "labelseleccion";
            this.labelseleccion.Size = new System.Drawing.Size(52, 13);
            this.labelseleccion.TabIndex = 14;
            this.labelseleccion.Text = "seleccion";
            // 
            // dataGridViewRT
            // 
            this.dataGridViewRT.AllowUserToAddRows = false;
            this.dataGridViewRT.AllowUserToDeleteRows = false;
            this.dataGridViewRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRT.Location = new System.Drawing.Point(192, 33);
            this.dataGridViewRT.Name = "dataGridViewRT";
            this.dataGridViewRT.ReadOnly = true;
            this.dataGridViewRT.Size = new System.Drawing.Size(474, 176);
            this.dataGridViewRT.TabIndex = 12;
            this.dataGridViewRT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRT_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(426, 394);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 16;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 515);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelseleccion);
            this.Controls.Add(this.dataGridViewRT);
            this.Controls.Add(this.labelActual);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelRT);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.maskedTextBoxFecha);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.richTextBoxMotivo);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.btnRegistrarIng);
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pantalla_FormClosing);
            this.Load += new System.EventHandler(this.Pantalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarIng;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.RichTextBox richTextBoxMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFecha;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelRT;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.Label labelseleccion;
        public System.Windows.Forms.DataGridView dataGridViewRT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonConfirmar;
    }
}