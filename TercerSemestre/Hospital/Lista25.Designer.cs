namespace Hospital
{
    partial class Lista25
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.boxNumber = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.boxPositive = new System.Windows.Forms.TextBox();
            this.boxNegatives = new System.Windows.Forms.TextBox();
            this.boxNotPair = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxPair = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxMajorTan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un valor:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(337, 56);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 264);
            this.listBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(221, 56);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // boxNumber
            // 
            this.boxNumber.Location = new System.Drawing.Point(102, 58);
            this.boxNumber.Name = "boxNumber";
            this.boxNumber.Size = new System.Drawing.Size(100, 20);
            this.boxNumber.TabIndex = 3;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(110, 100);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 4;
            // 
            // boxPositive
            // 
            this.boxPositive.Location = new System.Drawing.Point(508, 59);
            this.boxPositive.Name = "boxPositive";
            this.boxPositive.Size = new System.Drawing.Size(100, 20);
            this.boxPositive.TabIndex = 5;
            // 
            // boxNegatives
            // 
            this.boxNegatives.Location = new System.Drawing.Point(508, 121);
            this.boxNegatives.Name = "boxNegatives";
            this.boxNegatives.Size = new System.Drawing.Size(100, 20);
            this.boxNegatives.TabIndex = 6;
            // 
            // boxNotPair
            // 
            this.boxNotPair.Location = new System.Drawing.Point(508, 192);
            this.boxNotPair.Name = "boxNotPair";
            this.boxNotPair.Size = new System.Drawing.Size(100, 20);
            this.boxNotPair.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Positivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Negativos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inpares";
            // 
            // boxPair
            // 
            this.boxPair.Location = new System.Drawing.Point(508, 245);
            this.boxPair.Name = "boxPair";
            this.boxPair.Size = new System.Drawing.Size(100, 20);
            this.boxPair.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pares";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mayores de 50";
            // 
            // boxMajorTan
            // 
            this.boxMajorTan.Location = new System.Drawing.Point(508, 302);
            this.boxMajorTan.Name = "boxMajorTan";
            this.boxMajorTan.Size = new System.Drawing.Size(100, 20);
            this.boxMajorTan.TabIndex = 13;
            // 
            // Lista25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxMajorTan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxPair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxNotPair);
            this.Controls.Add(this.boxNegatives);
            this.Controls.Add(this.boxPositive);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.boxNumber);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label1);
            this.Name = "Lista25";
            this.Text = "Lista25";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox boxNumber;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox boxPositive;
        private System.Windows.Forms.TextBox boxNegatives;
        private System.Windows.Forms.TextBox boxNotPair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxPair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxMajorTan;
    }
}