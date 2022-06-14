
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
            this.labelbuscar = new System.Windows.Forms.Label();
            this.labelConfirmar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarIng
            // 
            this.btnRegistrarIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarIng.Location = new System.Drawing.Point(157, 21);
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
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(59, 144);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(166, 17);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha fin mantenimiento:";
            this.lblfecha.Visible = false;
            // 
            // richTextBoxMotivo
            // 
            this.richTextBoxMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMotivo.Location = new System.Drawing.Point(253, 182);
            this.richTextBoxMotivo.Name = "richTextBoxMotivo";
            this.richTextBoxMotivo.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxMotivo.TabIndex = 4;
            this.richTextBoxMotivo.Text = "";
            this.richTextBoxMotivo.Visible = false;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(172, 182);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(53, 17);
            this.lblMotivo.TabIndex = 5;
            this.lblMotivo.Text = "Motivo:";
            this.lblMotivo.Visible = false;
            // 
            // maskedTextBoxFecha
            // 
            this.maskedTextBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxFecha.Location = new System.Drawing.Point(235, 141);
            this.maskedTextBoxFecha.Mask = "00/00/0000 00:00";
            this.maskedTextBoxFecha.Name = "maskedTextBoxFecha";
            this.maskedTextBoxFecha.Size = new System.Drawing.Size(118, 23);
            this.maskedTextBoxFecha.TabIndex = 7;
            this.maskedTextBoxFecha.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxFecha.Visible = false;
            // 
            // labelRT
            // 
            this.labelRT.AutoSize = true;
            this.labelRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRT.Location = new System.Drawing.Point(58, 103);
            this.labelRT.Name = "labelRT";
            this.labelRT.Size = new System.Drawing.Size(114, 17);
            this.labelRT.TabIndex = 9;
            this.labelRT.Text = "RTseleccionado:";
            this.labelRT.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(253, 303);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(107, 57);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Visible = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(12, 35);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(61, 17);
            this.labelUsuario.TabIndex = 10;
            this.labelUsuario.Text = "Usuario:";
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActual.Location = new System.Drawing.Point(79, 35);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(47, 17);
            this.labelActual.TabIndex = 11;
            this.labelActual.Text = "Actual";
            // 
            // labelseleccion
            // 
            this.labelseleccion.AutoSize = true;
            this.labelseleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseleccion.Location = new System.Drawing.Point(203, 103);
            this.labelseleccion.Name = "labelseleccion";
            this.labelseleccion.Size = new System.Drawing.Size(67, 17);
            this.labelseleccion.TabIndex = 14;
            this.labelseleccion.Text = "seleccion";
            this.labelseleccion.Visible = false;
            // 
            // dataGridViewRT
            // 
            this.dataGridViewRT.AllowUserToAddRows = false;
            this.dataGridViewRT.AllowUserToDeleteRows = false;
            this.dataGridViewRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRT.Location = new System.Drawing.Point(42, 33);
            this.dataGridViewRT.Name = "dataGridViewRT";
            this.dataGridViewRT.ReadOnly = true;
            this.dataGridViewRT.Size = new System.Drawing.Size(474, 176);
            this.dataGridViewRT.TabIndex = 12;
            this.dataGridViewRT.Visible = false;
            this.dataGridViewRT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRT_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(474, 176);
            this.dataGridView1.TabIndex = 15;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(253, 395);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(107, 52);
            this.buttonConfirmar.TabIndex = 16;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Visible = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // labelbuscar
            // 
            this.labelbuscar.AutoSize = true;
            this.labelbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbuscar.Location = new System.Drawing.Point(59, 323);
            this.labelbuscar.Name = "labelbuscar";
            this.labelbuscar.Size = new System.Drawing.Size(186, 17);
            this.labelbuscar.TabIndex = 17;
            this.labelbuscar.Text = "Buscar Turnos Cancelables:";
            this.labelbuscar.Visible = false;
            // 
            // labelConfirmar
            // 
            this.labelConfirmar.AutoSize = true;
            this.labelConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmar.Location = new System.Drawing.Point(59, 413);
            this.labelConfirmar.Name = "labelConfirmar";
            this.labelConfirmar.Size = new System.Drawing.Size(169, 17);
            this.labelConfirmar.TabIndex = 18;
            this.labelConfirmar.Text = "Confirmar Mantenimiento:";
            this.labelConfirmar.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewRT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(435, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 241);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recursos Tecnologicos a cargo";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(437, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 231);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turnos Cancelables";
            this.groupBox2.Visible = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(322, 33);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(107, 31);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(988, 516);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelConfirmar);
            this.Controls.Add(this.labelbuscar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.labelseleccion);
            this.Controls.Add(this.labelActual);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelRT);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.maskedTextBoxFecha);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.richTextBoxMotivo);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.btnRegistrarIng);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pantalla_FormClosing);
            this.Load += new System.EventHandler(this.Pantalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label labelbuscar;
        private System.Windows.Forms.Label labelConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCancelar;
    }
}