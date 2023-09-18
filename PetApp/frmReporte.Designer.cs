namespace PetApp
{
    partial class frmReporte
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
            this.gpbReporte = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridView();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.gpbReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbReporte
            // 
            this.gpbReporte.Controls.Add(this.txtDatos);
            this.gpbReporte.Controls.Add(this.Data);
            this.gpbReporte.Controls.Add(this.button2);
            this.gpbReporte.Controls.Add(this.button1);
            this.gpbReporte.Location = new System.Drawing.Point(13, 13);
            this.gpbReporte.Name = "gpbReporte";
            this.gpbReporte.Size = new System.Drawing.Size(455, 273);
            this.gpbReporte.TabIndex = 0;
            this.gpbReporte.TabStop = false;
            this.gpbReporte.Text = "Reporte";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar  mascota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.AllowUserToDeleteRows = false;
            this.Data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(6, 108);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(321, 144);
            this.Data.TabIndex = 7;
            this.Data.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Data_MouseDoubleClick);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(6, 57);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(321, 20);
            this.txtDatos.TabIndex = 1;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 409);
            this.Controls.Add(this.gpbReporte);
            this.Name = "frmReporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.gpbReporte.ResumeLayout(false);
            this.gpbReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.TextBox txtDatos;
    }
}