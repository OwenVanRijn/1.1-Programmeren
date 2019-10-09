namespace opdracht8
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
            this.user_n = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_uitkomst = new System.Windows.Forms.Label();
            this.lbl_som_optel = new System.Windows.Forms.Label();
            this.lbl_som_formule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geef een getal (n)";
            // 
            // user_n
            // 
            this.user_n.Location = new System.Drawing.Point(142, 15);
            this.user_n.Name = "user_n";
            this.user_n.Size = new System.Drawing.Size(167, 22);
            this.user_n.TabIndex = 1;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(13, 39);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(296, 26);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Vergelijk";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "som = 0 + 1 + .. + n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "som = n * (n+1) / 2";
            // 
            // lbl_uitkomst
            // 
            this.lbl_uitkomst.AutoSize = true;
            this.lbl_uitkomst.Location = new System.Drawing.Point(13, 153);
            this.lbl_uitkomst.Name = "lbl_uitkomst";
            this.lbl_uitkomst.Size = new System.Drawing.Size(188, 17);
            this.lbl_uitkomst.TabIndex = 5;
            this.lbl_uitkomst.Text = "De som en formule zijn gelijk";
            // 
            // lbl_som_optel
            // 
            this.lbl_som_optel.Location = new System.Drawing.Point(149, 84);
            this.lbl_som_optel.Name = "lbl_som_optel";
            this.lbl_som_optel.Size = new System.Drawing.Size(160, 17);
            this.lbl_som_optel.TabIndex = 6;
            this.lbl_som_optel.Text = "?";
            this.lbl_som_optel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_som_formule
            // 
            this.lbl_som_formule.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_som_formule.Location = new System.Drawing.Point(149, 112);
            this.lbl_som_formule.Name = "lbl_som_formule";
            this.lbl_som_formule.Size = new System.Drawing.Size(160, 17);
            this.lbl_som_formule.TabIndex = 7;
            this.lbl_som_formule.Text = "?";
            this.lbl_som_formule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 188);
            this.Controls.Add(this.lbl_som_formule);
            this.Controls.Add(this.lbl_som_optel);
            this.Controls.Add(this.lbl_uitkomst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.user_n);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_n;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_uitkomst;
        private System.Windows.Forms.Label lbl_som_optel;
        private System.Windows.Forms.Label lbl_som_formule;
    }
}

