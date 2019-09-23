namespace Opdracht8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_shirt = new System.Windows.Forms.TextBox();
            this.user_broek = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_prijs = new System.Windows.Forms.Label();
            this.lbl_btw = new System.Windows.Forms.Label();
            this.lbl_totaal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal T-Shirts (€30 per stuk)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aantal Broeken (€100 per stuk)";
            // 
            // user_shirt
            // 
            this.user_shirt.Location = new System.Drawing.Point(228, 8);
            this.user_shirt.Name = "user_shirt";
            this.user_shirt.Size = new System.Drawing.Size(146, 22);
            this.user_shirt.TabIndex = 2;
            // 
            // user_broek
            // 
            this.user_broek.Location = new System.Drawing.Point(228, 36);
            this.user_broek.Name = "user_broek";
            this.user_broek.Size = new System.Drawing.Size(146, 22);
            this.user_broek.TabIndex = 3;
            // 
            // btn_calc
            // 
            this.btn_calc.Image = ((System.Drawing.Image)(resources.GetObject("btn_calc.Image")));
            this.btn_calc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_calc.Location = new System.Drawing.Point(19, 76);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(355, 48);
            this.btn_calc.TabIndex = 4;
            this.btn_calc.Text = "Berekenen";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_totaal);
            this.groupBox1.Controls.Add(this.lbl_btw);
            this.groupBox1.Controls.Add(this.lbl_prijs);
            this.groupBox1.Controls.Add(this.lbl_datum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rekening";
            // 
            // lbl_datum
            // 
            this.lbl_datum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_datum.Location = new System.Drawing.Point(69, 30);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(287, 17);
            this.lbl_datum.TabIndex = 4;
            this.lbl_datum.Text = "?";
            this.lbl_datum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Totaal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "BTW: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prijs: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum: ";
            // 
            // lbl_prijs
            // 
            this.lbl_prijs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_prijs.Location = new System.Drawing.Point(55, 47);
            this.lbl_prijs.Name = "lbl_prijs";
            this.lbl_prijs.Size = new System.Drawing.Size(301, 17);
            this.lbl_prijs.TabIndex = 5;
            this.lbl_prijs.Text = "?";
            this.lbl_prijs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_btw
            // 
            this.lbl_btw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_btw.Location = new System.Drawing.Point(59, 64);
            this.lbl_btw.Name = "lbl_btw";
            this.lbl_btw.Size = new System.Drawing.Size(297, 17);
            this.lbl_btw.TabIndex = 6;
            this.lbl_btw.Text = "?";
            this.lbl_btw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_totaal
            // 
            this.lbl_totaal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totaal.Location = new System.Drawing.Point(64, 101);
            this.lbl_totaal.Name = "lbl_totaal";
            this.lbl_totaal.Size = new System.Drawing.Size(292, 17);
            this.lbl_totaal.TabIndex = 7;
            this.lbl_totaal.Text = "?";
            this.lbl_totaal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.user_broek);
            this.Controls.Add(this.user_shirt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_shirt;
        private System.Windows.Forms.TextBox user_broek;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.Label lbl_prijs;
        private System.Windows.Forms.Label lbl_totaal;
        private System.Windows.Forms.Label lbl_btw;
    }
}

