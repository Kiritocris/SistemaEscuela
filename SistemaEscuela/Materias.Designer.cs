﻿namespace SistemaEscuela
{
    partial class Materias
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dcredito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dsemester = new System.Windows.Forms.TextBox();
            this.Dname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(132, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 34;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre de la materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Semestre:";
            // 
            // Dcredito
            // 
            this.Dcredito.Location = new System.Drawing.Point(260, 180);
            this.Dcredito.Name = "Dcredito";
            this.Dcredito.Size = new System.Drawing.Size(138, 22);
            this.Dcredito.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Creditos:";
            // 
            // Dsemester
            // 
            this.Dsemester.Location = new System.Drawing.Point(260, 142);
            this.Dsemester.Name = "Dsemester";
            this.Dsemester.Size = new System.Drawing.Size(138, 22);
            this.Dsemester.TabIndex = 31;
            // 
            // Dname
            // 
            this.Dname.Location = new System.Drawing.Point(260, 104);
            this.Dname.Name = "Dname";
            this.Dname.Size = new System.Drawing.Size(138, 22);
            this.Dname.TabIndex = 30;
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dcredito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dsemester);
            this.Controls.Add(this.Dname);
            this.Name = "Materias";
            this.Text = "Materias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dcredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dsemester;
        private System.Windows.Forms.TextBox Dname;
    }
}