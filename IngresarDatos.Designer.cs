
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
            this.gunaLabel2.Location = new System.Drawing.Point(274, 29);
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
            this.cboBarbero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboBarbero.ForeColor = System.Drawing.Color.Black;
            this.cboBarbero.FormattingEnabled = true;
            this.cboBarbero.Location = new System.Drawing.Point(23, 64);
            this.cboBarbero.Name = "cboBarbero";
            this.cboBarbero.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboBarbero.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboBarbero.Size = new System.Drawing.Size(204, 31);
            this.cboBarbero.TabIndex = 15;
            // 
            // IngresarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}