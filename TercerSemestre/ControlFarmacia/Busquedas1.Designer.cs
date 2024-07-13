namespace ControlEducativo
{
    partial class Busquedas1
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.texBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Button();
            this.apellido = new System.Windows.Forms.Button();
            this.carne = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(774, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Busqueda de Productos";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(414, 118);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(1159, 590);
            this.dataGrid.TabIndex = 53;
            // 
            // texBox
            // 
            this.texBox.Location = new System.Drawing.Point(135, 102);
            this.texBox.Name = "texBox";
            this.texBox.Size = new System.Drawing.Size(231, 22);
            this.texBox.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Valor a buscar:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(15, 223);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(192, 52);
            this.nombre.TabIndex = 59;
            this.nombre.Text = "Buscar Nombre";
            this.nombre.UseVisualStyleBackColor = true;
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(12, 296);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(192, 52);
            this.apellido.TabIndex = 60;
            this.apellido.Text = "Apellido";
            this.apellido.UseVisualStyleBackColor = true;
            this.apellido.Click += new System.EventHandler(this.apellido_Click);
            // 
            // carne
            // 
            this.carne.Location = new System.Drawing.Point(15, 154);
            this.carne.Name = "carne";
            this.carne.Size = new System.Drawing.Size(192, 52);
            this.carne.TabIndex = 62;
            this.carne.Text = "Carne:";
            this.carne.UseVisualStyleBackColor = true;
            this.carne.Click += new System.EventHandler(this.carne_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(12, 400);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(192, 52);
            this.reset.TabIndex = 63;
            this.reset.Text = "Restablecer";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Busquedas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1829, 895);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.carne);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid);
            this.Name = "Busquedas1";
            this.Text = "Busquedas1";
            this.Load += new System.EventHandler(this.Busquedas1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox texBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nombre;
        private System.Windows.Forms.Button apellido;
        private System.Windows.Forms.Button carne;
        private System.Windows.Forms.Button reset;
    }
}