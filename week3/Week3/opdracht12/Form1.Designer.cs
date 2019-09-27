namespace opdracht12
{
    partial class Form1
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
            this.user_leeftijd = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_biosprijs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leeftijd: ";
            // 
            // user_leeftijd
            // 
            this.user_leeftijd.Location = new System.Drawing.Point(66, 10);
            this.user_leeftijd.Name = "user_leeftijd";
            this.user_leeftijd.Size = new System.Drawing.Size(215, 20);
            this.user_leeftijd.TabIndex = 1;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(16, 36);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(265, 26);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Bereken prijs bioskaartje";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prijs bioscoopkaartje:";
            // 
            // lbl_biosprijs
            // 
            this.lbl_biosprijs.Location = new System.Drawing.Point(129, 81);
            this.lbl_biosprijs.Name = "lbl_biosprijs";
            this.lbl_biosprijs.Size = new System.Drawing.Size(152, 13);
            this.lbl_biosprijs.TabIndex = 4;
            this.lbl_biosprijs.Text = "?";
            this.lbl_biosprijs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 120);
            this.Controls.Add(this.lbl_biosprijs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.user_leeftijd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_leeftijd;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_biosprijs;
    }
}

