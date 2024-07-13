namespace Calcularoda
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
            btnC = new Button();
            boxResult = new TextBox();
            btnCE = new Button();
            btnBackSpace = new Button();
            btnSqr = new Button();
            btnDivided = new Button();
            btnMultiplier = new Button();
            btnPercent = new Button();
            btnMinus = new Button();
            btnFraction = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnInverter = new Button();
            btnPoint = new Button();
            btnMplus = new Button();
            btnMS = new Button();
            btnMR = new Button();
            btnMC = new Button();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutMeToolStripMenuItem = new ToolStripMenuItem();
            standardToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnC
            // 
            btnC.ForeColor = Color.Red;
            btnC.Location = new Point(212, 79);
            btnC.Name = "btnC";
            btnC.Size = new Size(92, 31);
            btnC.TabIndex = 0;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // boxResult
            // 
            boxResult.BackColor = SystemColors.HighlightText;
            boxResult.Location = new Point(15, 33);
            boxResult.Name = "boxResult";
            boxResult.ReadOnly = true;
            boxResult.Size = new Size(293, 27);
            boxResult.TabIndex = 1;
            boxResult.Text = "0.";
            boxResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCE
            // 
            btnCE.ForeColor = Color.Red;
            btnCE.Location = new Point(112, 79);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(94, 31);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnBackSpace
            // 
            btnBackSpace.ForeColor = Color.Red;
            btnBackSpace.Location = new Point(12, 79);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(94, 31);
            btnBackSpace.TabIndex = 3;
            btnBackSpace.Text = "Back Space";
            btnBackSpace.UseVisualStyleBackColor = true;
            // 
            // btnSqr
            // 
            btnSqr.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSqr.ForeColor = SystemColors.HotTrack;
            btnSqr.Location = new Point(263, 120);
            btnSqr.Name = "btnSqr";
            btnSqr.Size = new Size(41, 31);
            btnSqr.TabIndex = 4;
            btnSqr.Text = "sqrt";
            btnSqr.UseVisualStyleBackColor = true;
            btnSqr.Click += btnSqr_Click;
            // 
            // btnDivided
            // 
            btnDivided.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnDivided.ForeColor = SystemColors.HotTrack;
            btnDivided.Location = new Point(216, 120);
            btnDivided.Name = "btnDivided";
            btnDivided.Size = new Size(41, 31);
            btnDivided.TabIndex = 5;
            btnDivided.Text = "/";
            btnDivided.UseVisualStyleBackColor = true;
            btnDivided.Click += btnDivided_Click;
            // 
            // btnMultiplier
            // 
            btnMultiplier.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnMultiplier.ForeColor = SystemColors.HotTrack;
            btnMultiplier.Location = new Point(216, 157);
            btnMultiplier.Name = "btnMultiplier";
            btnMultiplier.Size = new Size(41, 31);
            btnMultiplier.TabIndex = 7;
            btnMultiplier.Text = "*";
            btnMultiplier.UseVisualStyleBackColor = true;
            btnMultiplier.Click += btnMultiplier_Click;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPercent.ForeColor = SystemColors.HotTrack;
            btnPercent.Location = new Point(263, 157);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(41, 31);
            btnPercent.TabIndex = 6;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnMinus.ForeColor = SystemColors.HotTrack;
            btnMinus.Location = new Point(216, 194);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(41, 31);
            btnMinus.TabIndex = 9;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnFraction
            // 
            btnFraction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFraction.ForeColor = SystemColors.HotTrack;
            btnFraction.Location = new Point(263, 194);
            btnFraction.Name = "btnFraction";
            btnFraction.Size = new Size(41, 31);
            btnFraction.TabIndex = 8;
            btnFraction.Text = "1/x";
            btnFraction.UseVisualStyleBackColor = true;
            btnFraction.Click += btnFraction_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold);
            btnPlus.ForeColor = SystemColors.HotTrack;
            btnPlus.Location = new Point(216, 231);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(41, 31);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEqual.ForeColor = SystemColors.HotTrack;
            btnEqual.Location = new Point(263, 231);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(41, 31);
            btnEqual.TabIndex = 10;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(122, 120);
            btn8.Name = "btn8";
            btn8.Size = new Size(41, 31);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(169, 120);
            btn9.Name = "btn9";
            btn9.Size = new Size(41, 31);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(75, 120);
            btn7.Name = "btn7";
            btn7.Size = new Size(41, 31);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(75, 157);
            btn4.Name = "btn4";
            btn4.Size = new Size(41, 31);
            btn4.TabIndex = 17;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(122, 157);
            btn5.Name = "btn5";
            btn5.Size = new Size(41, 31);
            btn5.TabIndex = 16;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(169, 157);
            btn6.Name = "btn6";
            btn6.Size = new Size(41, 31);
            btn6.TabIndex = 15;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(75, 194);
            btn1.Name = "btn1";
            btn1.Size = new Size(41, 31);
            btn1.TabIndex = 20;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(122, 194);
            btn2.Name = "btn2";
            btn2.Size = new Size(41, 31);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(169, 194);
            btn3.Name = "btn3";
            btn3.Size = new Size(41, 31);
            btn3.TabIndex = 18;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(75, 231);
            btn0.Name = "btn0";
            btn0.Size = new Size(41, 31);
            btn0.TabIndex = 23;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnInverter
            // 
            btnInverter.Location = new Point(122, 231);
            btnInverter.Name = "btnInverter";
            btnInverter.Size = new Size(41, 31);
            btnInverter.TabIndex = 22;
            btnInverter.Text = "+/-";
            btnInverter.UseVisualStyleBackColor = true;
            btnInverter.Click += btnInverter_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(169, 231);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(41, 31);
            btnPoint.TabIndex = 21;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnMplus
            // 
            btnMplus.Location = new Point(15, 231);
            btnMplus.Name = "btnMplus";
            btnMplus.Size = new Size(41, 31);
            btnMplus.TabIndex = 27;
            btnMplus.Text = "M+";
            btnMplus.UseVisualStyleBackColor = true;
            // 
            // btnMS
            // 
            btnMS.Location = new Point(15, 194);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(41, 31);
            btnMS.TabIndex = 26;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = true;
            // 
            // btnMR
            // 
            btnMR.Location = new Point(15, 157);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(41, 31);
            btnMR.TabIndex = 25;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = true;
            // 
            // btnMC
            // 
            btnMC.Location = new Point(15, 120);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(41, 31);
            btnMC.TabIndex = 24;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(325, 28);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientificToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMeToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // aboutMeToolStripMenuItem
            // 
            aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            aboutMeToolStripMenuItem.Size = new Size(161, 26);
            aboutMeToolStripMenuItem.Text = "About me.";
            aboutMeToolStripMenuItem.Click += aboutMeToolStripMenuItem_Click;
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(224, 26);
            standardToolStripMenuItem.Text = "Standard";
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(224, 26);
            scientificToolStripMenuItem.Text = "Scientific";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(224, 26);
            toolStripMenuItem2.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            CancelButton = btnC;
            ClientSize = new Size(325, 291);
            Controls.Add(btnMplus);
            Controls.Add(btnMS);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(btn0);
            Controls.Add(btnInverter);
            Controls.Add(btnPoint);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnPlus);
            Controls.Add(btnEqual);
            Controls.Add(btnMinus);
            Controls.Add(btnFraction);
            Controls.Add(btnMultiplier);
            Controls.Add(btnPercent);
            Controls.Add(btnDivided);
            Controls.Add(btnSqr);
            Controls.Add(btnBackSpace);
            Controls.Add(btnCE);
            Controls.Add(boxResult);
            Controls.Add(btnC);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(343, 338);
            Name = "Form1";
            Text = "Calculadora";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnC;
        private TextBox boxResult;
        private Button btnCE;
        private Button btnBackSpace;
        private Button btnSqr;
        private Button btnDivided;
        private Button btnMultiplier;
        private Button btnPercent;
        private Button btnMinus;
        private Button btnFraction;
        private Button btnPlus;
        private Button btnEqual;
        private Button btn8;
        private Button btn9;
        private Button btn7;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnInverter;
        private Button btnPoint;
        private Button btnMplus;
        private Button btnMS;
        private Button btnMR;
        private Button btnMC;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutMeToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}
