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
            this.gbTitulo = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTitulo
            // 
            this.gbTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTitulo.Controls.Add(this.lblTitulo);
            this.gbTitulo.Location = new System.Drawing.Point(12, 4);
            this.gbTitulo.Name = "gbTitulo";
            this.gbTitulo.Size = new System.Drawing.Size(858, 63);
            this.gbTitulo.TabIndex = 3;
            this.gbTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(350, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "VALIDACIONES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VisualizarValidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 555);
            this.Controls.Add(this.gbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VisualizarValidaciones";
            this.Text = "VisualizarReemplazos";
            this.gbTitulo.ResumeLayout(false);
            this.gbTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}