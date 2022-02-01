
namespace BarberShop
{
    partial class IngresarDatos
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cboBarbero = new Guna.UI.WinForms.GunaComboBox();
            this.cboServicios = new Guna.UI.WinForms.GunaComboBox();
            this.cboMetodosPago = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtTotal = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(68, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(106, 32);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Barbero";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(308, 29);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(117, 32);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Servicios";
            // 
            // cboBarbero
            // 
            this.cboBarbero.BackColor = System.Drawing.Color.Transparent;
            this.cboBarbero.BaseColor = System.Drawing.Color.White;
            this.cboBarbero.BorderColor = System.Drawing.Color.Silver;
            this.cboBarbero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBarbero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarbero.FocusedColor = System.Drawing.Color.Empty;
            this.cboBarbero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBarbero.ForeColor = System.Drawing.Color.Black;
            this.cboBarbero.FormattingEnabled = true;
            this.cboBarbero.Location = new System.Drawing.Point(23, 64);
            this.cboBarbero.Name = "cboBarbero";
            this.cboBarbero.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboBarbero.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboBarbero.Size = new System.Drawing.Size(204, 35);
            this.cboBarbero.TabIndex = 15;
            // 
            // cboServicios
            // 
            this.cboServicios.BackColor = System.Drawing.Color.Transparent;
            this.cboServicios.BaseColor = System.Drawing.Color.White;
            this.cboServicios.BorderColor = System.Drawing.Color.Silver;
            this.cboServicios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServicios.FocusedColor = System.Drawing.Color.Empty;
            this.cboServicios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServicios.ForeColor = System.Drawing.Color.Black;
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Location = new System.Drawing.Point(262, 64);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboServicios.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboServicios.Size = new System.Drawing.Size(204, 35);
            this.cboServicios.TabIndex = 16;
            this.cboServicios.SelectedIndexChanged += new System.EventHandler(this.cboServicios_SelectedIndexChanged);
            // 
            // cboMetodosPago
            // 
            this.cboMetodosPago.BackColor = System.Drawing.Color.Transparent;
            this.cboMetodosPago.BaseColor = System.Drawing.Color.White;
            this.cboMetodosPago.BorderColor = System.Drawing.Color.Silver;
            this.cboMetodosPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMetodosPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMetodosPago.FocusedColor = System.Drawing.Color.Empty;
            this.cboMetodosPago.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetodosPago.ForeColor = System.Drawing.Color.Black;
            this.cboMetodosPago.FormattingEnabled = true;
            this.cboMetodosPago.Location = new System.Drawing.Point(516, 64);
            this.cboMetodosPago.Name = "cboMetodosPago";
            this.cboMetodosPago.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboMetodosPago.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboMetodosPago.Size = new System.Drawing.Size(204, 35);
            this.cboMetodosPago.TabIndex = 17;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(510, 29);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(216, 32);
            this.gunaLabel3.TabIndex = 18;
            this.gunaLabel3.Text = "Metodos de pago";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(49, 185);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(78, 32);
            this.gunaLabel4.TabIndex = 19;
            this.gunaLabel4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BaseColor = System.Drawing.Color.White;
            this.txtTotal.BorderColor = System.Drawing.Color.Silver;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(145, 185);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.Size = new System.Drawing.Size(160, 37);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IngresarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cboMetodosPago);
            this.Controls.Add(this.cboServicios);
            this.Controls.Add(this.cboBarbero);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarDatos";
            this.Load += new System.EventHandler(this.IngresarDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cboBarbero;
        private Guna.UI.WinForms.GunaComboBox cboServicios;
        private Guna.UI.WinForms.GunaComboBox cboMetodosPago;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtTotal;
    }
}