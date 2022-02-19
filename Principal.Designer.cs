
namespace BarberShop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnHistorial = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCerrarSesion = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lineaDatos = new Guna.UI.WinForms.GunaSeparator();
            this.lblPuestoP = new Guna.UI.WinForms.GunaLabel();
            this.lblNombre = new Guna.UI.WinForms.GunaLabel();
            this.lblPuesto = new Guna.UI.WinForms.GunaLabel();
            this.lblNombreP = new Guna.UI.WinForms.GunaLabel();
            this.btnIngresarDatos = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panelDatos = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.picLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnRestaurar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMaximizar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCerrar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMenu = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.btnModificarDatos = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PanelLateral.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.PanelLateral.Controls.Add(this.btnModificarDatos);
            this.PanelLateral.Controls.Add(this.btnHistorial);
            this.PanelLateral.Controls.Add(this.btnCerrarSesion);
            this.PanelLateral.Controls.Add(this.lineaDatos);
            this.PanelLateral.Controls.Add(this.lblPuestoP);
            this.PanelLateral.Controls.Add(this.lblNombre);
            this.PanelLateral.Controls.Add(this.lblPuesto);
            this.PanelLateral.Controls.Add(this.lblNombreP);
            this.PanelLateral.Controls.Add(this.btnIngresarDatos);
            this.PanelLateral.Controls.Add(this.panelDatos);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(291, 1050);
            this.PanelLateral.TabIndex = 0;
            // 
            // btnHistorial
            // 
            this.btnHistorial.AnimationHoverSpeed = 0.07F;
            this.btnHistorial.AnimationSpeed = 0.03F;
            this.btnHistorial.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnHistorial.BorderColor = System.Drawing.Color.Black;
            this.btnHistorial.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnHistorial.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnHistorial.CheckedForeColor = System.Drawing.Color.White;
            this.btnHistorial.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnHistorial.CheckedImage")));
            this.btnHistorial.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnHistorial.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorial.FocusedColor = System.Drawing.Color.Empty;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Image = global::BarberShop.Properties.Resources.Historial2;
            this.btnHistorial.ImageSize = new System.Drawing.Size(50, 50);
            this.btnHistorial.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHistorial.Location = new System.Drawing.Point(0, 158);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnHistorial.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHistorial.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHistorial.OnHoverImage = null;
            this.btnHistorial.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnHistorial.OnPressedColor = System.Drawing.Color.Black;
            this.btnHistorial.Size = new System.Drawing.Size(291, 69);
            this.btnHistorial.TabIndex = 12;
            this.btnHistorial.Text = "Historial de datos";
            this.btnHistorial.TextOffsetX = 20;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AnimationHoverSpeed = 0.07F;
            this.btnCerrarSesion.AnimationSpeed = 0.03F;
            this.btnCerrarSesion.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnCerrarSesion.BorderColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.CheckedForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.CheckedImage")));
            this.btnCerrarSesion.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::BarberShop.Properties.Resources.CerrarSesion2;
            this.btnCerrarSesion.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCerrarSesion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 981);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCerrarSesion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.OnHoverImage = null;
            this.btnCerrarSesion.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCerrarSesion.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Size = new System.Drawing.Size(291, 69);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCerrarSesion.TextOffsetX = 20;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lineaDatos
            // 
            this.lineaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineaDatos.LineColor = System.Drawing.Color.Silver;
            this.lineaDatos.Location = new System.Drawing.Point(0, 888);
            this.lineaDatos.Name = "lineaDatos";
            this.lineaDatos.Size = new System.Drawing.Size(300, 13);
            this.lineaDatos.TabIndex = 10;
            // 
            // lblPuestoP
            // 
            this.lblPuestoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPuestoP.AutoSize = true;
            this.lblPuestoP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoP.ForeColor = System.Drawing.Color.White;
            this.lblPuestoP.Location = new System.Drawing.Point(12, 940);
            this.lblPuestoP.Name = "lblPuestoP";
            this.lblPuestoP.Size = new System.Drawing.Size(78, 25);
            this.lblPuestoP.TabIndex = 7;
            this.lblPuestoP.Text = "Puesto:";
            this.lblPuestoP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(102, 904);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(151, 25);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Miguel Alvarado";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.White;
            this.lblPuesto.Location = new System.Drawing.Point(102, 940);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(132, 25);
            this.lblPuesto.TabIndex = 9;
            this.lblPuesto.Text = "Administrador";
            this.lblPuesto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreP
            // 
            this.lblNombreP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreP.ForeColor = System.Drawing.Color.White;
            this.lblNombreP.Location = new System.Drawing.Point(12, 904);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(96, 25);
            this.lblNombreP.TabIndex = 6;
            this.lblNombreP.Text = "Nombre: ";
            this.lblNombreP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.AnimationHoverSpeed = 0.07F;
            this.btnIngresarDatos.AnimationSpeed = 0.03F;
            this.btnIngresarDatos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnIngresarDatos.BorderColor = System.Drawing.Color.Black;
            this.btnIngresarDatos.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnIngresarDatos.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnIngresarDatos.CheckedForeColor = System.Drawing.Color.White;
            this.btnIngresarDatos.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnIngresarDatos.CheckedImage")));
            this.btnIngresarDatos.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnIngresarDatos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIngresarDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngresarDatos.FocusedColor = System.Drawing.Color.Empty;
            this.btnIngresarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDatos.ForeColor = System.Drawing.Color.White;
            this.btnIngresarDatos.Image = global::BarberShop.Properties.Resources.ventas;
            this.btnIngresarDatos.ImageSize = new System.Drawing.Size(50, 50);
            this.btnIngresarDatos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnIngresarDatos.Location = new System.Drawing.Point(0, 89);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIngresarDatos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIngresarDatos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIngresarDatos.OnHoverImage = null;
            this.btnIngresarDatos.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnIngresarDatos.OnPressedColor = System.Drawing.Color.Black;
            this.btnIngresarDatos.Size = new System.Drawing.Size(291, 69);
            this.btnIngresarDatos.TabIndex = 3;
            this.btnIngresarDatos.Text = "Registrar Servicio";
            this.btnIngresarDatos.TextOffsetX = 20;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelDatos.Controls.Add(this.gunaLabel3);
            this.panelDatos.Controls.Add(this.picLogo);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatos.Location = new System.Drawing.Point(0, 0);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(291, 89);
            this.panelDatos.TabIndex = 2;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(101, 37);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(167, 25);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Arte Barber Shop";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picLogo
            // 
            this.picLogo.BaseColor = System.Drawing.Color.White;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = global::BarberShop.Properties.Resources.logo2;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(84, 89);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.PanelSuperior.Controls.Add(this.btnMinimizar);
            this.PanelSuperior.Controls.Add(this.btnRestaurar);
            this.PanelSuperior.Controls.Add(this.btnMaximizar);
            this.PanelSuperior.Controls.Add(this.btnCerrar);
            this.PanelSuperior.Controls.Add(this.btnMenu);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(291, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(1109, 51);
            this.PanelSuperior.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AnimationHoverSpeed = 0.07F;
            this.btnMinimizar.AnimationSpeed = 0.03F;
            this.btnMinimizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnMinimizar.BorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMinimizar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.CheckedForeColor = System.Drawing.Color.White;
            this.btnMinimizar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.CheckedImage")));
            this.btnMinimizar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMinimizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = global::BarberShop.Properties.Resources.minimizar2;
            this.btnMinimizar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimizar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimizar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMinimizar.Location = new System.Drawing.Point(917, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMinimizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimizar.OnHoverImage = null;
            this.btnMinimizar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMinimizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimizar.Size = new System.Drawing.Size(48, 51);
            this.btnMinimizar.TabIndex = 13;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.AnimationHoverSpeed = 0.07F;
            this.btnRestaurar.AnimationSpeed = 0.03F;
            this.btnRestaurar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnRestaurar.BorderColor = System.Drawing.Color.Black;
            this.btnRestaurar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRestaurar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRestaurar.CheckedForeColor = System.Drawing.Color.White;
            this.btnRestaurar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.CheckedImage")));
            this.btnRestaurar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRestaurar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestaurar.FocusedColor = System.Drawing.Color.Empty;
            this.btnRestaurar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Image = global::BarberShop.Properties.Resources.Restaurar;
            this.btnRestaurar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRestaurar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRestaurar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRestaurar.Location = new System.Drawing.Point(965, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRestaurar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRestaurar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRestaurar.OnHoverImage = null;
            this.btnRestaurar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRestaurar.OnPressedColor = System.Drawing.Color.Black;
            this.btnRestaurar.Size = new System.Drawing.Size(48, 51);
            this.btnRestaurar.TabIndex = 12;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.AnimationHoverSpeed = 0.07F;
            this.btnMaximizar.AnimationSpeed = 0.03F;
            this.btnMaximizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnMaximizar.BorderColor = System.Drawing.Color.Black;
            this.btnMaximizar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMaximizar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMaximizar.CheckedForeColor = System.Drawing.Color.White;
            this.btnMaximizar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.CheckedImage")));
            this.btnMaximizar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMaximizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnMaximizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Image = global::BarberShop.Properties.Resources.Maximizar;
            this.btnMaximizar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMaximizar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMaximizar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMaximizar.Location = new System.Drawing.Point(1013, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMaximizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMaximizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMaximizar.OnHoverImage = null;
            this.btnMaximizar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMaximizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnMaximizar.Size = new System.Drawing.Size(48, 51);
            this.btnMaximizar.TabIndex = 11;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AnimationHoverSpeed = 0.07F;
            this.btnCerrar.AnimationSpeed = 0.03F;
            this.btnCerrar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCerrar.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCerrar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCerrar.CheckedForeColor = System.Drawing.Color.White;
            this.btnCerrar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.CheckedImage")));
            this.btnCerrar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::BarberShop.Properties.Resources.Cerrar2;
            this.btnCerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCerrar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCerrar.Location = new System.Drawing.Point(1061, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Size = new System.Drawing.Size(48, 51);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.AnimationHoverSpeed = 0.07F;
            this.btnMenu.AnimationSpeed = 0.03F;
            this.btnMenu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnMenu.BorderColor = System.Drawing.Color.Black;
            this.btnMenu.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMenu.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMenu.CheckedForeColor = System.Drawing.Color.White;
            this.btnMenu.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.CheckedImage")));
            this.btnMenu.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMenu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FocusedColor = System.Drawing.Color.Empty;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::BarberShop.Properties.Resources.Menu2;
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMenu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMenu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMenu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMenu.OnHoverImage = null;
            this.btnMenu.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnMenu.OnPressedColor = System.Drawing.Color.Black;
            this.btnMenu.Size = new System.Drawing.Size(48, 51);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(291, 51);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1109, 999);
            this.PanelContenedor.TabIndex = 2;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.PanelSuperior;
            // 
            // btnModificarDatos
            // 
            this.btnModificarDatos.AnimationHoverSpeed = 0.07F;
            this.btnModificarDatos.AnimationSpeed = 0.03F;
            this.btnModificarDatos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnModificarDatos.BorderColor = System.Drawing.Color.Black;
            this.btnModificarDatos.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnModificarDatos.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnModificarDatos.CheckedForeColor = System.Drawing.Color.White;
            this.btnModificarDatos.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnModificarDatos.CheckedImage")));
            this.btnModificarDatos.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnModificarDatos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnModificarDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificarDatos.FocusedColor = System.Drawing.Color.Empty;
            this.btnModificarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDatos.ForeColor = System.Drawing.Color.White;
            this.btnModificarDatos.Image = global::BarberShop.Properties.Resources.ajustes;
            this.btnModificarDatos.ImageSize = new System.Drawing.Size(50, 50);
            this.btnModificarDatos.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnModificarDatos.Location = new System.Drawing.Point(0, 227);
            this.btnModificarDatos.Name = "btnModificarDatos";
            this.btnModificarDatos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnModificarDatos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnModificarDatos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnModificarDatos.OnHoverImage = null;
            this.btnModificarDatos.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnModificarDatos.OnPressedColor = System.Drawing.Color.Black;
            this.btnModificarDatos.Size = new System.Drawing.Size(291, 69);
            this.btnModificarDatos.TabIndex = 13;
            this.btnModificarDatos.Text = "Modificar Datos";
            this.btnModificarDatos.TextOffsetX = 20;
            this.btnModificarDatos.Click += new System.EventHandler(this.btnModificarDatos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 1050);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PanelLateral.ResumeLayout(false);
            this.PanelLateral.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelContenedor;
        private Guna.UI.WinForms.GunaPanel panelDatos;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaPictureBox picLogo;
        private Guna.UI.WinForms.GunaAdvenceButton btnIngresarDatos;
        private Guna.UI.WinForms.GunaAdvenceButton btnMenu;
        private Guna.UI.WinForms.GunaAdvenceButton btnMinimizar;
        private Guna.UI.WinForms.GunaAdvenceButton btnRestaurar;
        private Guna.UI.WinForms.GunaAdvenceButton btnMaximizar;
        private Guna.UI.WinForms.GunaAdvenceButton btnCerrar;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaLabel lblPuestoP;
        private Guna.UI.WinForms.GunaLabel lblNombre;
        private Guna.UI.WinForms.GunaLabel lblPuesto;
        private Guna.UI.WinForms.GunaLabel lblNombreP;
        private Guna.UI.WinForms.GunaSeparator lineaDatos;
        private Guna.UI.WinForms.GunaAdvenceButton btnCerrarSesion;
        private Guna.UI.WinForms.GunaAdvenceButton btnHistorial;
        private Guna.UI.WinForms.GunaAdvenceButton btnModificarDatos;
    }
}