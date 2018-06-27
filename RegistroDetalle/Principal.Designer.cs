namespace RegistroDetalle
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
            this.registrarCotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistrarToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.PersonasToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ArticulosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.CotizacionesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.consultarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            // registrarCotizacionToolStripMenuItem
            // 
            this.registrarCotizacionToolStripMenuItem.Name = "registrarCotizacionToolStripMenuItem";
            this.registrarCotizacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarCotizacionToolStripMenuItem.Text = "Registrar Cotizacion";
            this.registrarCotizacionToolStripMenuItem.Click += new System.EventHandler(this.registrarCotizacionToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarArticuloToolStripMenuItem,
            this.consultarPersonaToolStripMenuItem});
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
            // RegistrarToolStrip
            // 
            this.RegistrarToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegistrarToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.PersonasToolStripButton,
            this.toolStripLabel2,
            this.ArticulosToolStripButton,
            this.toolStripLabel3,
            this.CotizacionesToolStripButton});
            this.RegistrarToolStrip.Location = new System.Drawing.Point(0, 24);
            this.RegistrarToolStrip.Name = "RegistrarToolStrip";
            this.RegistrarToolStrip.Size = new System.Drawing.Size(282, 25);
            this.RegistrarToolStrip.TabIndex = 2;
            this.RegistrarToolStrip.Text = "Personas";
            this.RegistrarToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RegistrarPersonasToolStrip_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel1.Text = "Personas";
            // 
            // PersonasToolStripButton
            // 
            this.PersonasToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PersonasToolStripButton.Image = global::RegistroDetalle.Properties.Resources.User_48px;
            this.PersonasToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PersonasToolStripButton.Name = "PersonasToolStripButton";
            this.PersonasToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PersonasToolStripButton.Text = "Registrar Personas";
            this.PersonasToolStripButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel2.Text = "Artículos";
            // 
            // ArticulosToolStripButton
            // 
            this.ArticulosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ArticulosToolStripButton.Image = global::RegistroDetalle.Properties.Resources.Buying_48px;
            this.ArticulosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ArticulosToolStripButton.Name = "ArticulosToolStripButton";
            this.ArticulosToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ArticulosToolStripButton.Text = "Registrar Artículos";
            this.ArticulosToolStripButton.Click += new System.EventHandler(this.ArticulosToolStripButton_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel3.Text = "Cotizaciones";
            // 
            // CotizacionesToolStripButton
            // 
            this.CotizacionesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CotizacionesToolStripButton.Image = global::RegistroDetalle.Properties.Resources.Accounting_48px;
            this.CotizacionesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CotizacionesToolStripButton.Name = "CotizacionesToolStripButton";
            this.CotizacionesToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CotizacionesToolStripButton.Text = "Registrar Cotizaciones";
            this.CotizacionesToolStripButton.Click += new System.EventHandler(this.CotizacionesToolStripButton_Click);
            // 
            // consultarArticuloToolStripMenuItem
            // 
            this.consultarArticuloToolStripMenuItem.Name = "consultarArticuloToolStripMenuItem";
            this.consultarArticuloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarArticuloToolStripMenuItem.Text = "Consultar Articulo";
            this.consultarArticuloToolStripMenuItem.Click += new System.EventHandler(this.consultarArticuloToolStripMenuItem_Click);
            // 
            // consultarPersonaToolStripMenuItem
            // 
            this.consultarPersonaToolStripMenuItem.Name = "consultarPersonaToolStripMenuItem";
            this.consultarPersonaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarPersonaToolStripMenuItem.Text = "Consultar Persona";
            this.consultarPersonaToolStripMenuItem.Click += new System.EventHandler(this.consultarPersonaToolStripMenuItem_Click);
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
            this.Text = "Registrar Personas";
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
        private System.Windows.Forms.ToolStripButton PersonasToolStripButton;
        private System.Windows.Forms.ToolStripButton ArticulosToolStripButton;
        private System.Windows.Forms.ToolStripButton CotizacionesToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem consultarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPersonaToolStripMenuItem;
    }
}

