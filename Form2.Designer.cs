﻿namespace lab6_wizualne
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 87);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 0;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 138);
            label2.Name = "label2";
            label2.Size = new Size(21, 25);
            label2.TabIndex = 1;
            label2.Text = "y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 49);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 2;
            label3.Text = "plansza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 49);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "dydelfy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 138);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 4;
            label5.Text = "Krokodyle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 242);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 5;
            label6.Text = "czas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(215, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(101, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(215, 166);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(101, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(154, 242);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 369);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Ustawienia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}