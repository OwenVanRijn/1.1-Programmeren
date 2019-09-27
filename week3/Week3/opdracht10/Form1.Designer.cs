namespace opdracht10
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
            this.user_salaris = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_verhoging = new System.Windows.Forms.Label();
            this.lbl_nieuw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huidig Maandsalaris: ";
            // 
            // user_salaris
            // 
            this.user_salaris.Location = new System.Drawing.Point(163, 10);
            this.user_salaris.Name = "user_salaris";
            this.user_salaris.Size = new System.Drawing.Size(125, 22);
            this.user_salaris.TabIndex = 1;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(12, 49);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(276, 28);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Bereken verhoging";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verhoging: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Niew Maandsalaris:";
            // 
            // lbl_verhoging
            // 
            this.lbl_verhoging.Location = new System.Drawing.Point(100, 106);
            this.lbl_verhoging.Name = "lbl_verhoging";
            this.lbl_verhoging.Size = new System.Drawing.Size(188, 19);
            this.lbl_verhoging.TabIndex = 5;
            this.lbl_verhoging.Text = "?";
            this.lbl_verhoging.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_nieuw
            // 
            this.lbl_nieuw.Location = new System.Drawing.Point(160, 136);
            this.lbl_nieuw.Name = "lbl_nieuw";
            this.lbl_nieuw.Size = new System.Drawing.Size(128, 17);
            this.lbl_nieuw.TabIndex = 6;
            this.lbl_nieuw.Text = "?";
            this.lbl_nieuw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 174);
            this.Controls.Add(this.lbl_nieuw);
            this.Controls.Add(this.lbl_verhoging);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.user_salaris);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_salaris;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_verhoging;
        private System.Windows.Forms.Label lbl_nieuw;
    }
}

