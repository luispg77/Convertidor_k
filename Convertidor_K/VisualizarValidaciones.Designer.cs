namespace Convertidor_K
{
    partial class VisualizarValidaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvVisualizaciones = new System.Windows.Forms.DataGridView();
            this.btnModificarValidacion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTitulo
            // 
            this.gbTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTitulo.Controls.Add(this.lblTitulo);
            this.gbTitulo.Location = new System.Drawing.Point(12, 4);
            this.gbTitulo.Name = "gbTitulo";
            this.gbTitulo.Size = new System.Drawing.Size(924, 63);
            this.gbTitulo.TabIndex = 3;
            this.gbTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(292, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(334, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "VISUALIZACION DE VALIDACIONES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvVisualizaciones
            // 
            this.dgvVisualizaciones.AllowUserToAddRows = false;
            this.dgvVisualizaciones.AllowUserToOrderColumns = true;
            this.dgvVisualizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisualizaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVisualizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizaciones.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVisualizaciones.Location = new System.Drawing.Point(207, 73);
            this.dgvVisualizaciones.Name = "dgvVisualizaciones";
            this.dgvVisualizaciones.RowHeadersWidth = 30;
            this.dgvVisualizaciones.RowTemplate.Height = 24;
            this.dgvVisualizaciones.Size = new System.Drawing.Size(535, 308);
            this.dgvVisualizaciones.TabIndex = 4;
            // 
            // btnModificarValidacion
            // 
            this.btnModificarValidacion.Location = new System.Drawing.Point(198, 404);
            this.btnModificarValidacion.Name = "btnModificarValidacion";
            this.btnModificarValidacion.Size = new System.Drawing.Size(202, 48);
            this.btnModificarValidacion.TabIndex = 5;
            this.btnModificarValidacion.Text = "Modificar Validación";
            this.btnModificarValidacion.UseVisualStyleBackColor = true;
            this.btnModificarValidacion.Click += new System.EventHandler(this.btnModificarValidacion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(553, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(202, 48);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // VisualizarValidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 475);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificarValidacion);
            this.Controls.Add(this.dgvVisualizaciones);
            this.Controls.Add(this.gbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualizarValidaciones";
            this.Text = "VisualizarReemplazos";
            this.gbTitulo.ResumeLayout(false);
            this.gbTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvVisualizaciones;
        private System.Windows.Forms.Button btnModificarValidacion;
        private System.Windows.Forms.Button btnCancelar;
    }
}