﻿namespace RegistroDetalle
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrarToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.RegistrarToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.AyudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarArticulosToolStripMenuItem,
            this.registrarPersonasToolStripMenuItem,
            this.registrarCotizacionToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registrarArticulosToolStripMenuItem
            // 
            this.registrarArticulosToolStripMenuItem.Name = "registrarArticulosToolStripMenuItem";
            this.registrarArticulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarArticulosToolStripMenuItem.Text = "Registrar Articulos";
            this.registrarArticulosToolStripMenuItem.Click += new System.EventHandler(this.registrarArticulosToolStripMenuItem_Click);
            // 
            // registrarPersonasToolStripMenuItem
            // 
            this.registrarPersonasToolStripMenuItem.Name = "registrarPersonasToolStripMenuItem";
            this.registrarPersonasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarPersonasToolStripMenuItem.Text = "Registrar Personas";
            this.registrarPersonasToolStripMenuItem.Click += new System.EventHandler(this.registrarPersonasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.AyudaToolStripMenuItem.Text = "Ayuda";
            // 
            // registrarCotizacionToolStripMenuItem
            // 
            this.registrarCotizacionToolStripMenuItem.Name = "registrarCotizacionToolStripMenuItem";
            this.registrarCotizacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarCotizacionToolStripMenuItem.Text = "Registrar Cotizacion";
            this.registrarCotizacionToolStripMenuItem.Click += new System.EventHandler(this.registrarCotizacionToolStripMenuItem_Click);
            // 
            // RegistrarToolStrip
            // 
            this.RegistrarToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegistrarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.RegistrarToolStrip.Location = new System.Drawing.Point(0, 24);
            this.RegistrarToolStrip.Name = "RegistrarToolStrip";
            this.RegistrarToolStrip.Size = new System.Drawing.Size(282, 25);
            this.RegistrarToolStrip.TabIndex = 2;
            this.RegistrarToolStrip.Text = "Personas";
            this.RegistrarToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RegistrarPersonasToolStrip_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::RegistroDetalle.Properties.Resources.Edit_Property_16px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 372);
            this.Controls.Add(this.RegistrarToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Registro de Personas  y Artículos";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RegistrarToolStrip.ResumeLayout(false);
            this.RegistrarToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCotizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStrip RegistrarToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

