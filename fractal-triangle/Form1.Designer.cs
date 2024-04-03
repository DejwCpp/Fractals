using System;
using System.Drawing;
using System.Windows.Forms;

namespace fractal_triangle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlus = new Button();
            btnMinus = new Button();
            labelActualDeepth = new Label();
            btnTriangle = new Button();
            btnCarpet = new Button();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(720, 9);
            btnPlus.Margin = new Padding(0);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 50);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(720, 59);
            btnMinus.Margin = new Padding(0);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(50, 50);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // labelActualDeepth
            // 
            labelActualDeepth.AutoSize = true;
            labelActualDeepth.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelActualDeepth.Location = new Point(667, 27);
            labelActualDeepth.Name = "labelActualDeepth";
            labelActualDeepth.Size = new Size(50, 65);
            labelActualDeepth.TabIndex = 2;
            labelActualDeepth.Text = "?";
            // 
            // btnTriangle
            // 
            btnTriangle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnTriangle.Location = new Point(81, 27);
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(245, 46);
            btnTriangle.TabIndex = 3;
            btnTriangle.Text = "Sierpinski triangle";
            btnTriangle.UseVisualStyleBackColor = true;
            btnTriangle.Click += btnTriangle_Click;
            // 
            // btnCarpet
            // 
            btnCarpet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarpet.Location = new Point(332, 27);
            btnCarpet.Name = "btnCarpet";
            btnCarpet.Size = new Size(245, 46);
            btnCarpet.TabIndex = 4;
            btnCarpet.Text = "Sierpinski carpet";
            btnCarpet.UseVisualStyleBackColor = true;
            btnCarpet.Click += btnCarpet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(779, 886);
            Controls.Add(btnCarpet);
            Controls.Add(btnTriangle);
            Controls.Add(labelActualDeepth);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Name = "Form1";
            Text = "Sierpinski triangle";
            Paint += CreateFractal;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlus;
        private Button btnMinus;
        private Label labelActualDeepth;
        private Button btnTriangle;
        private Button btnCarpet;
    }
}
