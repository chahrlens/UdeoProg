namespace Clase2WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            textBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            listBox2 = new ListBox();
            button2 = new Button();
            listBox3 = new ListBox();
            labrelNegatives = new Label();
            labelPositive = new Label();
            labelNotPair = new Label();
            labelPair = new Label();
            subStractButton = new Button();
            multiplierButton = new Button();
            dividerButton = new Button();
            label2 = new Label();
            boxNegatives = new TextBox();
            boxPositives = new TextBox();
            boxNotPair = new TextBox();
            boxPair = new TextBox();
            boxAvgL3 = new TextBox();
            boxAvgL2 = new TextBox();
            boxAvgL1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(72, 85);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(93, 264);
            listBox1.TabIndex = 1;
            // 
            // textBox
            // 
            textBox.Location = new Point(235, 36);
            textBox.Name = "textBox";
            textBox.Size = new Size(125, 27);
            textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 36);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese cantidad:";
            // 
            // button1
            // 
            button1.Location = new Point(393, 36);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Generar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(235, 85);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(99, 264);
            listBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(393, 113);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Sumar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(514, 85);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(101, 264);
            listBox3.TabIndex = 7;
            // 
            // labrelNegatives
            // 
            labrelNegatives.AutoSize = true;
            labrelNegatives.Location = new Point(662, 113);
            labrelNegatives.Name = "labrelNegatives";
            labrelNegatives.Size = new Size(108, 20);
            labrelNegatives.TabIndex = 8;
            labrelNegatives.Text = "Total Negtivos:";
            // 
            // labelPositive
            // 
            labelPositive.AutoSize = true;
            labelPositive.Location = new Point(662, 170);
            labelPositive.Name = "labelPositive";
            labelPositive.Size = new Size(106, 20);
            labelPositive.TabIndex = 9;
            labelPositive.Text = "Total Positivos:";
            // 
            // labelNotPair
            // 
            labelNotPair.AutoSize = true;
            labelNotPair.Location = new Point(662, 239);
            labelNotPair.Name = "labelNotPair";
            labelNotPair.Size = new Size(102, 20);
            labelNotPair.TabIndex = 10;
            labelNotPair.Text = "Total Impares:";
            // 
            // labelPair
            // 
            labelPair.AutoSize = true;
            labelPair.Location = new Point(662, 306);
            labelPair.Name = "labelPair";
            labelPair.Size = new Size(83, 20);
            labelPair.TabIndex = 11;
            labelPair.Text = "Total Pares:";
            // 
            // subStractButton
            // 
            subStractButton.Location = new Point(393, 184);
            subStractButton.Name = "subStractButton";
            subStractButton.Size = new Size(94, 29);
            subStractButton.TabIndex = 12;
            subStractButton.Text = "Restar";
            subStractButton.UseVisualStyleBackColor = true;
            subStractButton.Click += subStractButton_Click;
            // 
            // multiplierButton
            // 
            multiplierButton.Location = new Point(393, 256);
            multiplierButton.Name = "multiplierButton";
            multiplierButton.Size = new Size(94, 29);
            multiplierButton.TabIndex = 13;
            multiplierButton.Text = "Multiplicar";
            multiplierButton.UseVisualStyleBackColor = true;
            multiplierButton.Click += multiplierButton_Click;
            // 
            // dividerButton
            // 
            dividerButton.Location = new Point(393, 320);
            dividerButton.Name = "dividerButton";
            dividerButton.Size = new Size(94, 29);
            dividerButton.TabIndex = 14;
            dividerButton.Text = "Dividir";
            dividerButton.UseVisualStyleBackColor = true;
            dividerButton.Click += dividerButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 362);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 15;
            label2.Text = "Promedio:";
            // 
            // boxNegatives
            // 
            boxNegatives.Location = new Point(797, 110);
            boxNegatives.Name = "boxNegatives";
            boxNegatives.ReadOnly = true;
            boxNegatives.Size = new Size(125, 27);
            boxNegatives.TabIndex = 18;
            // 
            // boxPositives
            // 
            boxPositives.Location = new Point(797, 163);
            boxPositives.Name = "boxPositives";
            boxPositives.ReadOnly = true;
            boxPositives.Size = new Size(125, 27);
            boxPositives.TabIndex = 19;
            // 
            // boxNotPair
            // 
            boxNotPair.Location = new Point(797, 236);
            boxNotPair.Name = "boxNotPair";
            boxNotPair.ReadOnly = true;
            boxNotPair.Size = new Size(125, 27);
            boxNotPair.TabIndex = 20;
            // 
            // boxPair
            // 
            boxPair.Location = new Point(797, 306);
            boxPair.Name = "boxPair";
            boxPair.ReadOnly = true;
            boxPair.Size = new Size(125, 27);
            boxPair.TabIndex = 21;
            // 
            // boxAvgL3
            // 
            boxAvgL3.Location = new Point(514, 397);
            boxAvgL3.Name = "boxAvgL3";
            boxAvgL3.ReadOnly = true;
            boxAvgL3.Size = new Size(125, 27);
            boxAvgL3.TabIndex = 22;
            // 
            // boxAvgL2
            // 
            boxAvgL2.Location = new Point(235, 397);
            boxAvgL2.Name = "boxAvgL2";
            boxAvgL2.ReadOnly = true;
            boxAvgL2.Size = new Size(125, 27);
            boxAvgL2.TabIndex = 23;
            // 
            // boxAvgL1
            // 
            boxAvgL1.Location = new Point(72, 397);
            boxAvgL1.Name = "boxAvgL1";
            boxAvgL1.ReadOnly = true;
            boxAvgL1.Size = new Size(125, 27);
            boxAvgL1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 362);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 25;
            label3.Text = "Promedio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(514, 362);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 26;
            label4.Text = "Promedio:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(boxAvgL1);
            Controls.Add(boxAvgL2);
            Controls.Add(boxAvgL3);
            Controls.Add(boxPair);
            Controls.Add(boxNotPair);
            Controls.Add(boxPositives);
            Controls.Add(boxNegatives);
            Controls.Add(label2);
            Controls.Add(dividerButton);
            Controls.Add(multiplierButton);
            Controls.Add(subStractButton);
            Controls.Add(labelPair);
            Controls.Add(labelNotPair);
            Controls.Add(labelPositive);
            Controls.Add(labrelNegatives);
            Controls.Add(listBox3);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private TextBox textBox;
        private Label label1;
        private Button button1;
        private ListBox listBox2;
        private Button button2;
        private ListBox listBox3;
        private Label labrelNegatives;
        private Label labelPositive;
        private Label labelNotPair;
        private Label labelPair;
        private Button subStractButton;
        private Button multiplierButton;
        private Button dividerButton;
        private Label label2;
        private TextBox boxNegatives;
        private TextBox boxPositives;
        private TextBox boxNotPair;
        private TextBox boxPair;
        private TextBox boxAvgL3;
        private TextBox boxAvgL2;
        private TextBox boxAvgL1;
        private Label label3;
        private Label label4;
    }
}
