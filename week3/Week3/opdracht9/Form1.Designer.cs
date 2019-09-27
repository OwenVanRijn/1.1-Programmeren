namespace opdracht9
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
            this.radio_voetbal = new System.Windows.Forms.RadioButton();
            this.radio_handbal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_leeftijd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_lidtijd = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radio_voetbal
            // 
            this.radio_voetbal.AutoSize = true;
            this.radio_voetbal.Location = new System.Drawing.Point(180, 5);
            this.radio_voetbal.Name = "radio_voetbal";
            this.radio_voetbal.Size = new System.Drawing.Size(77, 21);
            this.radio_voetbal.TabIndex = 0;
            this.radio_voetbal.TabStop = true;
            this.radio_voetbal.Text = "Voetbal";
            this.radio_voetbal.UseVisualStyleBackColor = true;
            // 
            // radio_handbal
            // 
            this.radio_handbal.AutoSize = true;
            this.radio_handbal.Location = new System.Drawing.Point(180, 32);
            this.radio_handbal.Name = "radio_handbal";
            this.radio_handbal.Size = new System.Drawing.Size(82, 21);
            this.radio_handbal.TabIndex = 1;
            this.radio_handbal.TabStop = true;
            this.radio_handbal.Text = "Handbal";
            this.radio_handbal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sportsoort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Leeftijd";
            // 
            // user_leeftijd
            // 
            this.user_leeftijd.Location = new System.Drawing.Point(180, 79);
            this.user_leeftijd.Name = "user_leeftijd";
            this.user_leeftijd.Size = new System.Drawing.Size(110, 22);
            this.user_leeftijd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Duur lidmaatschap";
            // 
            // user_lidtijd
            // 
            this.user_lidtijd.Location = new System.Drawing.Point(180, 107);
            this.user_lidtijd.Name = "user_lidtijd";
            this.user_lidtijd.Size = new System.Drawing.Size(110, 22);
            this.user_lidtijd.TabIndex = 6;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(12, 145);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(278, 27);
            this.btn_calc.TabIndex = 7;
            this.btn_calc.Text = "Bereken contributie";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Te betalen Contributie:";
            // 
            // lbl_totaal
            // 
            this.lbl_totaal.Location = new System.Drawing.Point(170, 192);
            this.lbl_totaal.Name = "lbl_totaal";
            this.lbl_totaal.Size = new System.Drawing.Size(120, 17);
            this.lbl_totaal.TabIndex = 9;
            this.lbl_totaal.Text = "?";
            this.lbl_totaal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 231);
            this.Controls.Add(this.lbl_totaal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.user_lidtijd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_leeftijd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_handbal);
            this.Controls.Add(this.radio_voetbal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_voetbal;
        private System.Windows.Forms.RadioButton radio_handbal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_leeftijd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_lidtijd;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_totaal;
    }
}

