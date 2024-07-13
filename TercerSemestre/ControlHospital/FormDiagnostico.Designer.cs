namespace ControlHospital
{
    partial class FormDiagnostico
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEnfermedad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxDiagnostico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxTratamiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.boxMedico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(459, 70);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1257, 539);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(839, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista de pacientes ingresados";
            // 
            // comboEnfermedad
            // 
            this.comboEnfermedad.FormattingEnabled = true;
            this.comboEnfermedad.Location = new System.Drawing.Point(123, 199);
            this.comboEnfermedad.Name = "comboEnfermedad";
            this.comboEnfermedad.Size = new System.Drawing.Size(269, 24);
            this.comboEnfermedad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Paciente:";
            // 
            // boxPaciente
            // 
            this.boxPaciente.Location = new System.Drawing.Point(123, 156);
            this.boxPaciente.Name = "boxPaciente";
            this.boxPaciente.Size = new System.Drawing.Size(269, 22);
            this.boxPaciente.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enfermedad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Medico:";
            // 
            // boxDiagnostico
            // 
            this.boxDiagnostico.Location = new System.Drawing.Point(123, 252);
            this.boxDiagnostico.Name = "boxDiagnostico";
            this.boxDiagnostico.Size = new System.Drawing.Size(269, 22);
            this.boxDiagnostico.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Diagnostico:";
            // 
            // boxTratamiento
            // 
            this.boxTratamiento.Location = new System.Drawing.Point(121, 303);
            this.boxTratamiento.Name = "boxTratamiento";
            this.boxTratamiento.Size = new System.Drawing.Size(271, 22);
            this.boxTratamiento.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tratamiento:";
            // 
            // boxCodigo
            // 
            this.boxCodigo.Location = new System.Drawing.Point(123, 68);
            this.boxCodigo.Name = "boxCodigo";
            this.boxCodigo.Size = new System.Drawing.Size(269, 22);
            this.boxCodigo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Codigo ingreso:";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::ControlHospital.Properties.Resources.salvar;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(278, 385);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 44);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // boxMedico
            // 
            this.boxMedico.Location = new System.Drawing.Point(121, 119);
            this.boxMedico.Name = "boxMedico";
            this.boxMedico.Size = new System.Drawing.Size(269, 22);
            this.boxMedico.TabIndex = 31;
            // 
            // FormDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 639);
            this.Controls.Add(this.boxMedico);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.boxCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxTratamiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxDiagnostico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxPaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEnfermedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid);
            this.Name = "FormDiagnostico";
            this.Text = "FormDiagnostico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDiagnostico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEnfermedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxDiagnostico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxTratamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox boxMedico;
    }
}