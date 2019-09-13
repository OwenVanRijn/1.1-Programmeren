namespace Opdracht_5
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
            this.label3 = new System.Windows.Forms.Label();
            this.user_getal1 = new System.Windows.Forms.TextBox();
            this.user_getal2 = new System.Windows.Forms.TextBox();
            this.user_getal3 = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoer getal 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoer getal 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Invoer getal 3:";
            // 
            // user_getal1
            // 
            this.user_getal1.Location = new System.Drawing.Point(132, 30);
            this.user_getal1.Name = "user_getal1";
            this.user_getal1.Size = new System.Drawing.Size(291, 22);
            this.user_getal1.TabIndex = 3;
            // 
            // user_getal2
            // 
            this.user_getal2.Location = new System.Drawing.Point(132, 59);
            this.user_getal2.Name = "user_getal2";
            this.user_getal2.Size = new System.Drawing.Size(291, 22);
            this.user_getal2.TabIndex = 4;
            // 
            // user_getal3
            // 
            this.user_getal3.Location = new System.Drawing.Point(132, 87);
            this.user_getal3.Name = "user_getal3";
            this.user_getal3.Size = new System.Drawing.Size(291, 22);
            this.user_getal3.TabIndex = 5;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(31, 130);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(392, 28);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Bereken gemiddelde";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gemiddelde: ";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(290, 183);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(16, 17);
            this.lbl_result.TabIndex = 8;
            this.lbl_result.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 225);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.user_getal3);
            this.Controls.Add(this.user_getal2);
            this.Controls.Add(this.user_getal1);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_getal1;
        private System.Windows.Forms.TextBox user_getal2;
        private System.Windows.Forms.TextBox user_getal3;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_result;
    }
}

