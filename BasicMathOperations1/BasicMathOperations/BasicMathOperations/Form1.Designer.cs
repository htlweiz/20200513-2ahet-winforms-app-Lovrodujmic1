namespace BasicMathOperations
{
    partial class titel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.LblNumber2 = new System.Windows.Forms.Label();
            this.LblNumber3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.LblNumber4 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(80, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(699, 66);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Einfache Rechenoperationen";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(22, 147);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(82, 31);
            this.lblNumber1.TabIndex = 2;
            this.lblNumber1.Text = "Zahl1";
            this.lblNumber1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblNumber2
            // 
            this.LblNumber2.AutoSize = true;
            this.LblNumber2.Location = new System.Drawing.Point(22, 223);
            this.LblNumber2.Name = "LblNumber2";
            this.LblNumber2.Size = new System.Drawing.Size(82, 31);
            this.LblNumber2.TabIndex = 3;
            this.LblNumber2.Text = "Zahl2";
            this.LblNumber2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LblNumber3
            // 
            this.LblNumber3.AutoSize = true;
            this.LblNumber3.Location = new System.Drawing.Point(12, 295);
            this.LblNumber3.Name = "LblNumber3";
            this.LblNumber3.Size = new System.Drawing.Size(121, 31);
            this.LblNumber3.TabIndex = 4;
            this.LblNumber3.Text = "Ergebnis";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(162, 144);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(175, 38);
            this.txt1.TabIndex = 5;
            this.txt1.Text = "0";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(162, 223);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(175, 38);
            this.txt2.TabIndex = 6;
            this.txt2.Text = "0";
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblNumber4
            // 
            this.LblNumber4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNumber4.Location = new System.Drawing.Point(162, 295);
            this.LblNumber4.Name = "LblNumber4";
            this.LblNumber4.Size = new System.Drawing.Size(175, 41);
            this.LblNumber4.TabIndex = 8;
            this.LblNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblNumber4.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(394, 121);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(69, 67);
            this.btnA.TabIndex = 9;
            this.btnA.Text = "+";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(394, 205);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(69, 67);
            this.btnB.TabIndex = 10;
            this.btnB.Text = "*";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(469, 121);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(69, 67);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "-";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(469, 205);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(69, 67);
            this.btnD.TabIndex = 12;
            this.btnD.Text = "/";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(548, 121);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(69, 67);
            this.btnE.TabIndex = 13;
            this.btnE.Text = "b√a";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(548, 205);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(69, 67);
            this.btnF.TabIndex = 14;
            this.btnF.Text = "a^b";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(623, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 67);
            this.button1.TabIndex = 15;
            this.button1.Text = "ln(a)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(623, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 67);
            this.button2.TabIndex = 16;
            this.button2.Text = "lg(a)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(249, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // titel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 469);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.LblNumber4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.LblNumber3);
            this.Controls.Add(this.LblNumber2);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "titel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einfacher Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label LblNumber2;
        private System.Windows.Forms.Label LblNumber3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label LblNumber4;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnF;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

