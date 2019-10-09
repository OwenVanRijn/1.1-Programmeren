namespace opdracht6
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.user_start = new System.Windows.Forms.TextBox();
            this.lbl_eind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Startbedrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eindkapitaal";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(12, 50);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(309, 28);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Bereken bedrag na 5 jaar met 5% rente";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // user_start
            // 
            this.user_start.Location = new System.Drawing.Point(172, 22);
            this.user_start.Name = "user_start";
            this.user_start.Size = new System.Drawing.Size(150, 22);
            this.user_start.TabIndex = 3;
            // 
            // lbl_eind
            // 
            this.lbl_eind.Location = new System.Drawing.Point(106, 98);
            this.lbl_eind.Name = "lbl_eind";
            this.lbl_eind.Size = new System.Drawing.Size(215, 17);
            this.lbl_eind.TabIndex = 4;
            this.lbl_eind.Text = "?";
            this.lbl_eind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 138);
            this.Controls.Add(this.lbl_eind);
            this.Controls.Add(this.user_start);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox user_start;
        private System.Windows.Forms.Label lbl_eind;
    }
}

