namespace SistemaEscuela
{
    partial class Baja
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
            this.BClave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Sname = new System.Windows.Forms.Label();
            this.Sedad = new System.Windows.Forms.Label();
            this.Scalle = new System.Windows.Forms.Label();
            this.Snumero = new System.Windows.Forms.Label();
            this.Scolonia = new System.Windows.Forms.Label();
            this.Stelefono = new System.Windows.Forms.Label();
            this.Bname = new System.Windows.Forms.TextBox();
            this.Bedad = new System.Windows.Forms.TextBox();
            this.Bcalle = new System.Windows.Forms.TextBox();
            this.Bnumero = new System.Windows.Forms.TextBox();
            this.Bcolonia = new System.Windows.Forms.TextBox();
            this.Btelefono = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave:";
            // 
            // BClave
            // 
            this.BClave.Location = new System.Drawing.Point(167, 86);
            this.BClave.Name = "BClave";
            this.BClave.Size = new System.Drawing.Size(106, 22);
            this.BClave.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.Location = new System.Drawing.Point(111, 129);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(121, 16);
            this.Sname.TabIndex = 6;
            this.Sname.Text = "Nombre completo :";
            this.Sname.Visible = false;
            // 
            // Sedad
            // 
            this.Sedad.AutoSize = true;
            this.Sedad.Location = new System.Drawing.Point(111, 167);
            this.Sedad.Name = "Sedad";
            this.Sedad.Size = new System.Drawing.Size(46, 16);
            this.Sedad.TabIndex = 7;
            this.Sedad.Text = "Edad :";
            this.Sedad.Visible = false;
            // 
            // Scalle
            // 
            this.Scalle.AutoSize = true;
            this.Scalle.Location = new System.Drawing.Point(111, 205);
            this.Scalle.Name = "Scalle";
            this.Scalle.Size = new System.Drawing.Size(44, 16);
            this.Scalle.TabIndex = 8;
            this.Scalle.Text = "Calle :";
            this.Scalle.Visible = false;
            // 
            // Snumero
            // 
            this.Snumero.AutoSize = true;
            this.Snumero.Location = new System.Drawing.Point(111, 245);
            this.Snumero.Name = "Snumero";
            this.Snumero.Size = new System.Drawing.Size(61, 16);
            this.Snumero.TabIndex = 9;
            this.Snumero.Text = "Numero :";
            this.Snumero.Visible = false;
            // 
            // Scolonia
            // 
            this.Scolonia.AutoSize = true;
            this.Scolonia.Location = new System.Drawing.Point(111, 286);
            this.Scolonia.Name = "Scolonia";
            this.Scolonia.Size = new System.Drawing.Size(59, 16);
            this.Scolonia.TabIndex = 10;
            this.Scolonia.Text = "Colonia :";
            this.Scolonia.Visible = false;
            // 
            // Stelefono
            // 
            this.Stelefono.AutoSize = true;
            this.Stelefono.Location = new System.Drawing.Point(111, 328);
            this.Stelefono.Name = "Stelefono";
            this.Stelefono.Size = new System.Drawing.Size(67, 16);
            this.Stelefono.TabIndex = 11;
            this.Stelefono.Text = "Telefono :";
            this.Stelefono.Visible = false;
            // 
            // Bname
            // 
            this.Bname.Location = new System.Drawing.Point(255, 129);
            this.Bname.Name = "Bname";
            this.Bname.ReadOnly = true;
            this.Bname.Size = new System.Drawing.Size(173, 22);
            this.Bname.TabIndex = 12;
            this.Bname.Visible = false;
            // 
            // Bedad
            // 
            this.Bedad.Location = new System.Drawing.Point(255, 167);
            this.Bedad.Name = "Bedad";
            this.Bedad.ReadOnly = true;
            this.Bedad.Size = new System.Drawing.Size(173, 22);
            this.Bedad.TabIndex = 13;
            this.Bedad.Visible = false;
            // 
            // Bcalle
            // 
            this.Bcalle.Location = new System.Drawing.Point(255, 205);
            this.Bcalle.Name = "Bcalle";
            this.Bcalle.ReadOnly = true;
            this.Bcalle.Size = new System.Drawing.Size(173, 22);
            this.Bcalle.TabIndex = 14;
            this.Bcalle.Visible = false;
            // 
            // Bnumero
            // 
            this.Bnumero.Location = new System.Drawing.Point(255, 245);
            this.Bnumero.Name = "Bnumero";
            this.Bnumero.ReadOnly = true;
            this.Bnumero.Size = new System.Drawing.Size(173, 22);
            this.Bnumero.TabIndex = 15;
            this.Bnumero.Visible = false;
            // 
            // Bcolonia
            // 
            this.Bcolonia.Location = new System.Drawing.Point(255, 286);
            this.Bcolonia.Name = "Bcolonia";
            this.Bcolonia.ReadOnly = true;
            this.Bcolonia.Size = new System.Drawing.Size(173, 22);
            this.Bcolonia.TabIndex = 16;
            this.Bcolonia.Visible = false;
            // 
            // Btelefono
            // 
            this.Btelefono.Location = new System.Drawing.Point(255, 328);
            this.Btelefono.Name = "Btelefono";
            this.Btelefono.ReadOnly = true;
            this.Btelefono.Size = new System.Drawing.Size(173, 22);
            this.Btelefono.TabIndex = 17;
            this.Btelefono.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btelefono);
            this.Controls.Add(this.Bcolonia);
            this.Controls.Add(this.Bnumero);
            this.Controls.Add(this.Bcalle);
            this.Controls.Add(this.Bedad);
            this.Controls.Add(this.Bname);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.Sedad);
            this.Controls.Add(this.Scalle);
            this.Controls.Add(this.Snumero);
            this.Controls.Add(this.Scolonia);
            this.Controls.Add(this.Stelefono);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BClave);
            this.Controls.Add(this.label1);
            this.Name = "Baja";
            this.Text = "Baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BClave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Label Sedad;
        private System.Windows.Forms.Label Scalle;
        private System.Windows.Forms.Label Snumero;
        private System.Windows.Forms.Label Scolonia;
        private System.Windows.Forms.Label Stelefono;
        private System.Windows.Forms.TextBox Bname;
        private System.Windows.Forms.TextBox Bedad;
        private System.Windows.Forms.TextBox Bcalle;
        private System.Windows.Forms.TextBox Bnumero;
        private System.Windows.Forms.TextBox Bcolonia;
        private System.Windows.Forms.TextBox Btelefono;
        private System.Windows.Forms.Button button2;
    }
}