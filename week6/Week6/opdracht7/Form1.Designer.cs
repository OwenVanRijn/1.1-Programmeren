namespace opdracht7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_ctof = new System.Windows.Forms.RadioButton();
            this.radio_ftoc = new System.Windows.Forms.RadioButton();
            this.radio_ctok = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.user_graden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_out = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_ctok);
            this.groupBox1.Controls.Add(this.radio_ftoc);
            this.groupBox1.Controls.Add(this.radio_ctof);
            this.groupBox1.Location = new System.Drawing.Point(15, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Omrekenen";
            // 
            // radio_ctof
            // 
            this.radio_ctof.AutoSize = true;
            this.radio_ctof.Location = new System.Drawing.Point(6, 42);
            this.radio_ctof.Name = "radio_ctof";
            this.radio_ctof.Size = new System.Drawing.Size(161, 17);
            this.radio_ctof.TabIndex = 1;
            this.radio_ctof.Text = "Van Celcius naar Fahrenheid";
            this.radio_ctof.UseVisualStyleBackColor = true;
            // 
            // radio_ftoc
            // 
            this.radio_ftoc.AutoSize = true;
            this.radio_ftoc.Location = new System.Drawing.Point(6, 65);
            this.radio_ftoc.Name = "radio_ftoc";
            this.radio_ftoc.Size = new System.Drawing.Size(160, 17);
            this.radio_ftoc.TabIndex = 2;
            this.radio_ftoc.Text = "van Fahrenheid naar Celcius";
            this.radio_ftoc.UseVisualStyleBackColor = true;
            // 
            // radio_ctok
            // 
            this.radio_ctok.AutoSize = true;
            this.radio_ctok.Checked = true;
            this.radio_ctok.Location = new System.Drawing.Point(6, 19);
            this.radio_ctok.Name = "radio_ctok";
            this.radio_ctok.Size = new System.Drawing.Size(136, 17);
            this.radio_ctok.TabIndex = 1;
            this.radio_ctok.TabStop = true;
            this.radio_ctok.Text = "van Celcius naar Kelvin";
            this.radio_ctok.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Graden";
            // 
            // user_graden
            // 
            this.user_graden.Location = new System.Drawing.Point(60, 17);
            this.user_graden.Name = "user_graden";
            this.user_graden.Size = new System.Drawing.Size(129, 20);
            this.user_graden.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Niewe graden";
            // 
            // lbl_out
            // 
            this.lbl_out.Location = new System.Drawing.Point(91, 180);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(98, 13);
            this.lbl_out.TabIndex = 4;
            this.lbl_out.Text = "-";
            this.lbl_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(13, 144);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(176, 23);
            this.btn_calc.TabIndex = 5;
            this.btn_calc.Text = "Bereken niewe graden";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 202);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lbl_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_graden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "opdracht7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_ctok;
        private System.Windows.Forms.RadioButton radio_ftoc;
        private System.Windows.Forms.RadioButton radio_ctof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_graden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_out;
        private System.Windows.Forms.Button btn_calc;
    }
}

