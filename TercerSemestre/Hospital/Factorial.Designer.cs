namespace Hospital
{
    partial class Factorial
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxFactorial = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.boxNumber = new System.Windows.Forms.TextBox();
            this.listFactorial = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(318, 57);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un numero";
            // 
            // boxFactorial
            // 
            this.boxFactorial.Location = new System.Drawing.Point(590, 69);
            this.boxFactorial.Name = "boxFactorial";
            this.boxFactorial.Size = new System.Drawing.Size(130, 20);
            this.boxFactorial.TabIndex = 2;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(587, 41);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(47, 13);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "Factorial";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(162, 92);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 4;
            // 
            // boxNumber
            // 
            this.boxNumber.Location = new System.Drawing.Point(165, 54);
            this.boxNumber.Name = "boxNumber";
            this.boxNumber.Size = new System.Drawing.Size(102, 20);
            this.boxNumber.TabIndex = 5;
            // 
            // listFactorial
            // 
            this.listFactorial.FormattingEnabled = true;
            this.listFactorial.Location = new System.Drawing.Point(446, 26);
            this.listFactorial.Name = "listFactorial";
            this.listFactorial.Size = new System.Drawing.Size(120, 186);
            this.listFactorial.TabIndex = 6;
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 224);
            this.Controls.Add(this.listFactorial);
            this.Controls.Add(this.boxNumber);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.boxFactorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxFactorial;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox boxNumber;
        private System.Windows.Forms.ListBox listFactorial;
    }
}