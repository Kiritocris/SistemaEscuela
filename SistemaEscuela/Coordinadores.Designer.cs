﻿namespace SistemaEscuela
{
    partial class Coordinadores
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
            this.Cgrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cedad = new System.Windows.Forms.TextBox();
            this.Cname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(133, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 41;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre del coordinador: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Edad:";
            // 
            // Cgrade
            // 
            this.Cgrade.Location = new System.Drawing.Point(261, 184);
            this.Cgrade.Name = "Cgrade";
            this.Cgrade.Size = new System.Drawing.Size(138, 22);
            this.Cgrade.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "grado academico:";
            // 
            // Cedad
            // 
            this.Cedad.Location = new System.Drawing.Point(261, 146);
            this.Cedad.Name = "Cedad";
            this.Cedad.Size = new System.Drawing.Size(138, 22);
            this.Cedad.TabIndex = 39;
            // 
            // Cname
            // 
            this.Cname.Location = new System.Drawing.Point(261, 108);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(138, 22);
            this.Cname.TabIndex = 38;
            // 
            // Coordinadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cgrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cedad);
            this.Controls.Add(this.Cname);
            this.Name = "Coordinadores";
            this.Text = "Coordinadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cgrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cedad;
        private System.Windows.Forms.TextBox Cname;
    }
}