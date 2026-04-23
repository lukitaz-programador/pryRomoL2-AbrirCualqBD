namespace pryRomoL2_AbrirCualqBD
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            this.btnAbrirBD = new System.Windows.Forms.Button();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblTablas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();

            // btnAbrirBD
            this.btnAbrirBD.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirBD.Name = "btnAbrirBD";
            this.btnAbrirBD.Size = new System.Drawing.Size(150, 35);
            this.btnAbrirBD.TabIndex = 0;
            this.btnAbrirBD.Text = "Abrir Base de Datos";
            this.btnAbrirBD.UseVisualStyleBackColor = true;
            this.btnAbrirBD.Click += new System.EventHandler(this.btnAbrirBD_Click);

            // lblTablas
            this.lblTablas.AutoSize = true;
            this.lblTablas.Location = new System.Drawing.Point(180, 20);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(45, 15);
            this.lblTablas.TabIndex = 1;
            this.lblTablas.Text = "Tablas:";

            // cmbTablas
            this.cmbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(230, 17);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(200, 23);
            this.cmbTablas.TabIndex = 2;
            this.cmbTablas.SelectedIndexChanged += new System.EventHandler(this.cmbTablas_SelectedIndexChanged);

            // dgvDatos
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 60);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowTemplate.Height = 25;
            this.dgvDatos.Size = new System.Drawing.Size(760, 380);
            this.dgvDatos.TabIndex = 3;

            // lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(450, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(95, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Sin conexión...";

            // frmPrincipal
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.cmbTablas);
            this.Controls.Add(this.lblTablas);
            this.Controls.Add(this.btnAbrirBD);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visor de Base de Datos Access";

            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAbrirBD;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.Label lblEstado;
    }
}