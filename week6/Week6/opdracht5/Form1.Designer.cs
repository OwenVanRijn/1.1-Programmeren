namespace opdracht5
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
            this.user_getal1 = new System.Windows.Forms.TextBox();
            this.user_getal2 = new System.Windows.Forms.TextBox();
            this.calc_add = new System.Windows.Forms.Button();
            this.calc_sub = new System.Windows.Forms.Button();
            this.calc_mul = new System.Windows.Forms.Button();
            this.calc_div = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_uitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Getal2";
            // 
            // user_getal1
            // 
            this.user_getal1.Location = new System.Drawing.Point(57, 10);
            this.user_getal1.Name = "user_getal1";
            this.user_getal1.Size = new System.Drawing.Size(217, 20);
            this.user_getal1.TabIndex = 2;
            // 
            // user_getal2
            // 
            this.user_getal2.Location = new System.Drawing.Point(57, 36);
            this.user_getal2.Name = "user_getal2";
            this.user_getal2.Size = new System.Drawing.Size(217, 20);
            this.user_getal2.TabIndex = 3;
            // 
            // calc_add
            // 
            this.calc_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_add.Location = new System.Drawing.Point(12, 62);
            this.calc_add.Name = "calc_add";
            this.calc_add.Size = new System.Drawing.Size(60, 60);
            this.calc_add.TabIndex = 4;
            this.calc_add.Text = "+";
            this.calc_add.UseVisualStyleBackColor = true;
            this.calc_add.Click += new System.EventHandler(this.Calc_add_Click);
            // 
            // calc_sub
            // 
            this.calc_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_sub.Location = new System.Drawing.Point(78, 62);
            this.calc_sub.Name = "calc_sub";
            this.calc_sub.Size = new System.Drawing.Size(57, 60);
            this.calc_sub.TabIndex = 5;
            this.calc_sub.Text = "-";
            this.calc_sub.UseVisualStyleBackColor = true;
            this.calc_sub.Click += new System.EventHandler(this.Calc_sub_Click);
            // 
            // calc_mul
            // 
            this.calc_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_mul.Location = new System.Drawing.Point(141, 62);
            this.calc_mul.Name = "calc_mul";
            this.calc_mul.Size = new System.Drawing.Size(63, 60);
            this.calc_mul.TabIndex = 6;
            this.calc_mul.Text = "X";
            this.calc_mul.UseVisualStyleBackColor = true;
            this.calc_mul.Click += new System.EventHandler(this.Calc_mul_Click);
            // 
            // calc_div
            // 
            this.calc_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_div.Location = new System.Drawing.Point(210, 62);
            this.calc_div.Name = "calc_div";
            this.calc_div.Size = new System.Drawing.Size(64, 60);
            this.calc_div.TabIndex = 7;
            this.calc_div.Text = "/";
            this.calc_div.UseVisualStyleBackColor = true;
            this.calc_div.Click += new System.EventHandler(this.Calc_div_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uitkomst";
            // 
            // lbl_uitkomst
            // 
            this.lbl_uitkomst.Location = new System.Drawing.Point(63, 144);
            this.lbl_uitkomst.Name = "lbl_uitkomst";
            this.lbl_uitkomst.Size = new System.Drawing.Size(211, 13);
            this.lbl_uitkomst.TabIndex = 9;
            this.lbl_uitkomst.Text = "-";
            this.lbl_uitkomst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 176);
            this.Controls.Add(this.lbl_uitkomst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calc_div);
            this.Controls.Add(this.calc_mul);
            this.Controls.Add(this.calc_sub);
            this.Controls.Add(this.calc_add);
            this.Controls.Add(this.user_getal2);
            this.Controls.Add(this.user_getal1);
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
        private System.Windows.Forms.TextBox user_getal1;
        private System.Windows.Forms.TextBox user_getal2;
        private System.Windows.Forms.Button calc_add;
        private System.Windows.Forms.Button calc_sub;
        private System.Windows.Forms.Button calc_mul;
        private System.Windows.Forms.Button calc_div;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_uitkomst;
    }
}

