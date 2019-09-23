namespace Opdracht7
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
            this.user_beginkm = new System.Windows.Forms.TextBox();
            this.user_eindkm = new System.Windows.Forms.TextBox();
            this.user_ppk = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_prijs = new System.Windows.Forms.Label();
            this.lbl_btw = new System.Windows.Forms.Label();
            this.lbl_totaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin Km: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eind Km:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prijs per Km:";
            // 
            // user_beginkm
            // 
            this.user_beginkm.Location = new System.Drawing.Point(80, 6);
            this.user_beginkm.Margin = new System.Windows.Forms.Padding(2);
            this.user_beginkm.Name = "user_beginkm";
            this.user_beginkm.Size = new System.Drawing.Size(188, 20);
            this.user_beginkm.TabIndex = 3;
            // 
            // user_eindkm
            // 
            this.user_eindkm.Location = new System.Drawing.Point(80, 29);
            this.user_eindkm.Margin = new System.Windows.Forms.Padding(2);
            this.user_eindkm.Name = "user_eindkm";
            this.user_eindkm.Size = new System.Drawing.Size(188, 20);
            this.user_eindkm.TabIndex = 4;
            // 
            // user_ppk
            // 
            this.user_ppk.Location = new System.Drawing.Point(80, 52);
            this.user_ppk.Margin = new System.Windows.Forms.Padding(2);
            this.user_ppk.Name = "user_ppk";
            this.user_ppk.Size = new System.Drawing.Size(188, 20);
            this.user_ppk.TabIndex = 5;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(271, 6);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(107, 28);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "Wissen";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(271, 39);
            this.btn_calc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(107, 29);
            this.btn_calc.TabIndex = 7;
            this.btn_calc.Text = "Berekenen";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prijs excl. BTW";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prijs incl. BTW";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "BTW";
            // 
            // lbl_prijs
            // 
            this.lbl_prijs.AutoSize = true;
            this.lbl_prijs.Location = new System.Drawing.Point(14, 145);
            this.lbl_prijs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prijs.Name = "lbl_prijs";
            this.lbl_prijs.Size = new System.Drawing.Size(13, 13);
            this.lbl_prijs.TabIndex = 11;
            this.lbl_prijs.Text = "0";
            // 
            // lbl_btw
            // 
            this.lbl_btw.AutoSize = true;
            this.lbl_btw.Location = new System.Drawing.Point(129, 145);
            this.lbl_btw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_btw.Name = "lbl_btw";
            this.lbl_btw.Size = new System.Drawing.Size(13, 13);
            this.lbl_btw.TabIndex = 12;
            this.lbl_btw.Text = "0";
            // 
            // lbl_totaal
            // 
            this.lbl_totaal.AutoSize = true;
            this.lbl_totaal.Location = new System.Drawing.Point(284, 145);
            this.lbl_totaal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totaal.Name = "lbl_totaal";
            this.lbl_totaal.Size = new System.Drawing.Size(13, 13);
            this.lbl_totaal.TabIndex = 14;
            this.lbl_totaal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 184);
            this.Controls.Add(this.lbl_totaal);
            this.Controls.Add(this.lbl_btw);
            this.Controls.Add(this.lbl_prijs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.user_ppk);
            this.Controls.Add(this.user_eindkm);
            this.Controls.Add(this.user_beginkm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_beginkm;
        private System.Windows.Forms.TextBox user_eindkm;
        private System.Windows.Forms.TextBox user_ppk;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_prijs;
        private System.Windows.Forms.Label lbl_btw;
        private System.Windows.Forms.Label lbl_totaal;
    }
}

