namespace KalkulatorUKK21
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttontmbah = new System.Windows.Forms.Button();
            this.buttonkurang = new System.Windows.Forms.Button();
            this.buttonkali = new System.Windows.Forms.Button();
            this.buttonbagi = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LbLhasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator Sederhana";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "UKK Ghina Rosvita Maharanisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angka 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Angka 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasil";
            // 
            // buttontmbah
            // 
            this.buttontmbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontmbah.Location = new System.Drawing.Point(163, 239);
            this.buttontmbah.Name = "buttontmbah";
            this.buttontmbah.Size = new System.Drawing.Size(40, 38);
            this.buttontmbah.TabIndex = 5;
            this.buttontmbah.Text = "+";
            this.buttontmbah.UseVisualStyleBackColor = true;
            this.buttontmbah.Click += new System.EventHandler(this.buttontmbah_Click);
            // 
            // buttonkurang
            // 
            this.buttonkurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonkurang.Location = new System.Drawing.Point(209, 239);
            this.buttonkurang.Name = "buttonkurang";
            this.buttonkurang.Size = new System.Drawing.Size(40, 38);
            this.buttonkurang.TabIndex = 6;
            this.buttonkurang.Text = "-";
            this.buttonkurang.UseVisualStyleBackColor = true;
            this.buttonkurang.Click += new System.EventHandler(this.buttonkurang_Click);
            // 
            // buttonkali
            // 
            this.buttonkali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonkali.Location = new System.Drawing.Point(163, 283);
            this.buttonkali.Name = "buttonkali";
            this.buttonkali.Size = new System.Drawing.Size(40, 38);
            this.buttonkali.TabIndex = 7;
            this.buttonkali.Text = "x";
            this.buttonkali.UseVisualStyleBackColor = true;
            this.buttonkali.Click += new System.EventHandler(this.buttonkali_Click);
            // 
            // buttonbagi
            // 
            this.buttonbagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbagi.Location = new System.Drawing.Point(209, 283);
            this.buttonbagi.Name = "buttonbagi";
            this.buttonbagi.Size = new System.Drawing.Size(40, 38);
            this.buttonbagi.TabIndex = 8;
            this.buttonbagi.Text = "/";
            this.buttonbagi.UseVisualStyleBackColor = true;
            this.buttonbagi.Click += new System.EventHandler(this.buttonbagi_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.Location = new System.Drawing.Point(34, 239);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(118, 82);
            this.buttonclear.TabIndex = 10;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 12;
            // 
            // LbLhasil
            // 
            this.LbLhasil.Location = new System.Drawing.Point(103, 182);
            this.LbLhasil.Name = "LbLhasil";
            this.LbLhasil.Size = new System.Drawing.Size(146, 20);
            this.LbLhasil.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 352);
            this.Controls.Add(this.LbLhasil);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonbagi);
            this.Controls.Add(this.buttonkali);
            this.Controls.Add(this.buttonkurang);
            this.Controls.Add(this.buttontmbah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KALKULATOR SEDERHANA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttontmbah;
        private System.Windows.Forms.Button buttonkurang;
        private System.Windows.Forms.Button buttonkali;
        private System.Windows.Forms.Button buttonbagi;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox LbLhasil;
    }
}

