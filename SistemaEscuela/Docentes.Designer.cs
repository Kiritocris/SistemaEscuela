namespace SistemaEscuela
{
    partial class Docentes
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
            this.Dtelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dapellidop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dapellido = new System.Windows.Forms.TextBox();
            this.Dname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 25;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dtelefono
            // 
            this.Dtelefono.Location = new System.Drawing.Point(287, 194);
            this.Dtelefono.Name = "Dtelefono";
            this.Dtelefono.Size = new System.Drawing.Size(179, 22);
            this.Dtelefono.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido paterno:";
            // 
            // Dapellidop
            // 
            this.Dapellidop.Location = new System.Drawing.Point(285, 156);
            this.Dapellidop.Name = "Dapellidop";
            this.Dapellidop.Size = new System.Drawing.Size(179, 22);
            this.Dapellidop.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Apellido materno:";
            // 
            // Dapellido
            // 
            this.Dapellido.Location = new System.Drawing.Point(285, 118);
            this.Dapellido.Name = "Dapellido";
            this.Dapellido.Size = new System.Drawing.Size(179, 22);
            this.Dapellido.TabIndex = 20;
            // 
            // Dname
            // 
            this.Dname.Location = new System.Drawing.Point(285, 80);
            this.Dname.Name = "Dname";
            this.Dname.Size = new System.Drawing.Size(179, 22);
            this.Dname.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Telefono :";
            // 
            // Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dtelefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dapellidop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dapellido);
            this.Controls.Add(this.Dname);
            this.Controls.Add(this.label6);
            this.Name = "Docentes";
            this.Text = "Docentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Dtelefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dapellidop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Dapellido;
        private System.Windows.Forms.TextBox Dname;
        private System.Windows.Forms.Label label6;
    }
}