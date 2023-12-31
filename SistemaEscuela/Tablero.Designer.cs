﻿namespace SistemaEscuela
{
    partial class Tablero
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
            this.btnAlta = new System.Windows.Forms.MenuStrip();
            this.menualta = new FontAwesome.Sharp.IconMenuItem();
            this.menudocentes = new FontAwesome.Sharp.IconMenuItem();
            this.menumaterias = new FontAwesome.Sharp.IconMenuItem();
            this.menucoord = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.updatealumnos = new FontAwesome.Sharp.IconMenuItem();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btnAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.AutoSize = false;
            this.btnAlta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlta.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.btnAlta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menualta,
            this.menudocentes,
            this.menumaterias,
            this.menucoord,
            this.iconMenuItem1,
            this.updatealumnos});
            this.btnAlta.Location = new System.Drawing.Point(0, 0);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAlta.Size = new System.Drawing.Size(535, 89);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Text = "INSCRIBIR";
            // 
            // menualta
            // 
            this.menualta.AutoSize = false;
            this.menualta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menualta.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.menualta.IconColor = System.Drawing.Color.Black;
            this.menualta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menualta.IconSize = 40;
            this.menualta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menualta.Name = "menualta";
            this.menualta.Size = new System.Drawing.Size(85, 85);
            this.menualta.Text = "Alta";
            this.menualta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menualta.Click += new System.EventHandler(this.Menualta_Click);
            // 
            // menudocentes
            // 
            this.menudocentes.AutoSize = false;
            this.menudocentes.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menudocentes.IconChar = FontAwesome.Sharp.IconChar.Smile;
            this.menudocentes.IconColor = System.Drawing.Color.Black;
            this.menudocentes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menudocentes.IconSize = 40;
            this.menudocentes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menudocentes.Name = "menudocentes";
            this.menudocentes.Size = new System.Drawing.Size(85, 85);
            this.menudocentes.Text = "Docentes";
            this.menudocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menudocentes.Click += new System.EventHandler(this.Menudocentes_Click);
            // 
            // menumaterias
            // 
            this.menumaterias.AutoSize = false;
            this.menumaterias.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menumaterias.IconChar = FontAwesome.Sharp.IconChar.Subscript;
            this.menumaterias.IconColor = System.Drawing.Color.Black;
            this.menumaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumaterias.IconSize = 40;
            this.menumaterias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumaterias.Name = "menumaterias";
            this.menumaterias.Size = new System.Drawing.Size(85, 85);
            this.menumaterias.Text = "Materias";
            this.menumaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menumaterias.Click += new System.EventHandler(this.Menumaterias_Click);
            // 
            // menucoord
            // 
            this.menucoord.AutoSize = false;
            this.menucoord.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucoord.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.menucoord.IconColor = System.Drawing.Color.Black;
            this.menucoord.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucoord.IconSize = 40;
            this.menucoord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucoord.Name = "menucoord";
            this.menucoord.Size = new System.Drawing.Size(85, 85);
            this.menucoord.Text = "Coord.";
            this.menucoord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menucoord.Click += new System.EventHandler(this.Menucoord_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.AutoSize = false;
            this.iconMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 40;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(85, 85);
            this.iconMenuItem1.Text = "Buscar";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconMenuItem1.Click += new System.EventHandler(this.IconMenuItem1_Click);
            // 
            // updatealumnos
            // 
            this.updatealumnos.AutoSize = false;
            this.updatealumnos.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatealumnos.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.updatealumnos.IconColor = System.Drawing.Color.Black;
            this.updatealumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updatealumnos.IconSize = 40;
            this.updatealumnos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updatealumnos.Name = "updatealumnos";
            this.updatealumnos.Size = new System.Drawing.Size(90, 85);
            this.updatealumnos.Text = "Actualizar";
            this.updatealumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.updatealumnos.Click += new System.EventHandler(this.Menualumnos_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 89);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(535, 496);
            this.contenedor.TabIndex = 1;
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(535, 585);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.btnAlta);
            this.MainMenuStrip = this.btnAlta;
            this.Name = "Tablero";
            this.Text = "Tablero";
            this.btnAlta.ResumeLayout(false);
            this.btnAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip btnAlta;
        private FontAwesome.Sharp.IconMenuItem menualta;
        private FontAwesome.Sharp.IconMenuItem updatealumnos;
        private FontAwesome.Sharp.IconMenuItem menudocentes;
        private FontAwesome.Sharp.IconMenuItem menumaterias;
        private FontAwesome.Sharp.IconMenuItem menucoord;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}

