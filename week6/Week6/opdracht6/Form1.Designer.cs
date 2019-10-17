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
            this.lbl_out = new System.Windows.Forms.Label();
            this.user_getal = new System.Windows.Forms.TextBox();
            this.btn_calc_ref = new System.Windows.Forms.Button();
            this.btn_calc_out = new System.Windows.Forms.Button();
            this.btn_calc_val = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uitkomst";
            // 
            // lbl_out
            // 
            this.lbl_out.Location = new System.Drawing.Point(63, 142);
            this.lbl_out.Name = "lbl_out";
            this.lbl_out.Size = new System.Drawing.Size(118, 13);
            this.lbl_out.TabIndex = 2;
            this.lbl_out.Text = "-";
            this.lbl_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // user_getal
            // 
            this.user_getal.Location = new System.Drawing.Point(50, 19);
            this.user_getal.Name = "user_getal";
            this.user_getal.Size = new System.Drawing.Size(131, 20);
            this.user_getal.TabIndex = 3;
            // 
            // btn_calc_ref
            // 
            this.btn_calc_ref.Location = new System.Drawing.Point(12, 45);
            this.btn_calc_ref.Name = "btn_calc_ref";
            this.btn_calc_ref.Size = new System.Drawing.Size(169, 23);
            this.btn_calc_ref.TabIndex = 4;
            this.btn_calc_ref.Text = "Bereken kwadraad (REF)";
            this.btn_calc_ref.UseVisualStyleBackColor = true;
            this.btn_calc_ref.Click += new System.EventHandler(this.Btn_calc_ref_Click);
            // 
            // btn_calc_out
            // 
            this.btn_calc_out.Location = new System.Drawing.Point(12, 74);
            this.btn_calc_out.Name = "btn_calc_out";
            this.btn_calc_out.Size = new System.Drawing.Size(169, 23);
            this.btn_calc_out.TabIndex = 5;
            this.btn_calc_out.Text = "Bereken kwadraad (OUT)";
            this.btn_calc_out.UseVisualStyleBackColor = true;
            this.btn_calc_out.Click += new System.EventHandler(this.Btn_calc_out_Click);
            // 
            // btn_calc_val
            // 
            this.btn_calc_val.Location = new System.Drawing.Point(12, 103);
            this.btn_calc_val.Name = "btn_calc_val";
            this.btn_calc_val.Size = new System.Drawing.Size(169, 23);
            this.btn_calc_val.TabIndex = 6;
            this.btn_calc_val.Text = "Bereken kwadraad (VALUE)";
            this.btn_calc_val.UseVisualStyleBackColor = true;
            this.btn_calc_val.Click += new System.EventHandler(this.Btn_calc_val_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 172);
            this.Controls.Add(this.btn_calc_val);
            this.Controls.Add(this.btn_calc_out);
            this.Controls.Add(this.btn_calc_ref);
            this.Controls.Add(this.user_getal);
            this.Controls.Add(this.lbl_out);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_out;
        private System.Windows.Forms.TextBox user_getal;
        private System.Windows.Forms.Button btn_calc_ref;
        private System.Windows.Forms.Button btn_calc_out;
        private System.Windows.Forms.Button btn_calc_val;
    }
}

