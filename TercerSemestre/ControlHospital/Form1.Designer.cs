namespace ControlHospital
{
    partial class Form1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.pacienetesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIstaDocotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCamasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDePacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienetesToolStripMenuItem,
            this.doctoresToolStripMenuItem,
            this.movimientosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(903, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // pacienetesToolStripMenuItem
            // 
            this.pacienetesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaPacientesToolStripMenuItem,
            this.ingresoPacienteToolStripMenuItem});
            this.pacienetesToolStripMenuItem.Name = "pacienetesToolStripMenuItem";
            this.pacienetesToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.pacienetesToolStripMenuItem.Text = "Pacienetes";
            // 
            // listaPacientesToolStripMenuItem
            // 
            this.listaPacientesToolStripMenuItem.Name = "listaPacientesToolStripMenuItem";
            this.listaPacientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaPacientesToolStripMenuItem.Text = "Lista pacientes";
            this.listaPacientesToolStripMenuItem.Click += new System.EventHandler(this.listaPacientesToolStripMenuItem_Click);
            // 
            // ingresoPacienteToolStripMenuItem
            // 
            this.ingresoPacienteToolStripMenuItem.Name = "ingresoPacienteToolStripMenuItem";
            this.ingresoPacienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ingresoPacienteToolStripMenuItem.Text = "Ingreso paciente";
            this.ingresoPacienteToolStripMenuItem.Click += new System.EventHandler(this.ingresoPacienteToolStripMenuItem_Click);
            // 
            // doctoresToolStripMenuItem
            // 
            this.doctoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIstaDocotoresToolStripMenuItem,
            this.especialidadesToolStripMenuItem,
            this.diagnosticoToolStripMenuItem,
            this.altaDePacienteToolStripMenuItem});
            this.doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            this.doctoresToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.doctoresToolStripMenuItem.Text = "Doctores";
            // 
            // lIstaDocotoresToolStripMenuItem
            // 
            this.lIstaDocotoresToolStripMenuItem.Name = "lIstaDocotoresToolStripMenuItem";
            this.lIstaDocotoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lIstaDocotoresToolStripMenuItem.Text = "LIsta Docotores";
            this.lIstaDocotoresToolStripMenuItem.Click += new System.EventHandler(this.lIstaDocotoresToolStripMenuItem_Click);
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            this.especialidadesToolStripMenuItem.Click += new System.EventHandler(this.especialidadesToolStripMenuItem_Click);
            // 
            // diagnosticoToolStripMenuItem
            // 
            this.diagnosticoToolStripMenuItem.Name = "diagnosticoToolStripMenuItem";
            this.diagnosticoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.diagnosticoToolStripMenuItem.Text = "Diagnostico";
            this.diagnosticoToolStripMenuItem.Click += new System.EventHandler(this.diagnosticoToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCamasToolStripMenuItem,
            this.listaHabitacionesToolStripMenuItem});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // listaCamasToolStripMenuItem
            // 
            this.listaCamasToolStripMenuItem.Name = "listaCamasToolStripMenuItem";
            this.listaCamasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaCamasToolStripMenuItem.Text = "Lista camas";
            this.listaCamasToolStripMenuItem.Click += new System.EventHandler(this.listaCamasToolStripMenuItem_Click);
            // 
            // listaHabitacionesToolStripMenuItem
            // 
            this.listaHabitacionesToolStripMenuItem.Name = "listaHabitacionesToolStripMenuItem";
            this.listaHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listaHabitacionesToolStripMenuItem.Text = "Lista habitaciones";
            this.listaHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.listaHabitacionesToolStripMenuItem_Click);
            // 
            // altaDePacienteToolStripMenuItem
            // 
            this.altaDePacienteToolStripMenuItem.Name = "altaDePacienteToolStripMenuItem";
            this.altaDePacienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altaDePacienteToolStripMenuItem.Text = "Alta de paciente";
            this.altaDePacienteToolStripMenuItem.Click += new System.EventHandler(this.altaDePacienteToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 440);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Control Hospitalario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem pacienetesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIstaDocotoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCamasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDePacienteToolStripMenuItem;
    }
}

