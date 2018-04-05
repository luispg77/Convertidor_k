namespace Convertidor_K
{
    partial class ModificarValidacion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbTitulo = new System.Windows.Forms.GroupBox();
            this.rtbReemplazo = new System.Windows.Forms.RichTextBox();
            this.rtbOriginal = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTituloReemplazo = new System.Windows.Forms.Label();
            this.lblTituloOriginal = new System.Windows.Forms.Label();
            this.gbTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(103, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(265, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MODIFICAR VALIDACIONES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTitulo
            // 
            this.gbTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbTitulo.Controls.Add(this.lblTitulo);
            this.gbTitulo.Location = new System.Drawing.Point(2, 12);
            this.gbTitulo.Name = "gbTitulo";
            this.gbTitulo.Size = new System.Drawing.Size(479, 63);
            this.gbTitulo.TabIndex = 3;
            this.gbTitulo.TabStop = false;
            // 
            // rtbReemplazo
            // 
            this.rtbReemplazo.Location = new System.Drawing.Point(128, 235);
            this.rtbReemplazo.Name = "rtbReemplazo";
            this.rtbReemplazo.Size = new System.Drawing.Size(305, 111);
            this.rtbReemplazo.TabIndex = 16;
            this.rtbReemplazo.Text = "";
            this.rtbReemplazo.TextChanged += new System.EventHandler(this.rtbReemplazo_TextChanged);
            // 
            // rtbOriginal
            // 
            this.rtbOriginal.Enabled = false;
            this.rtbOriginal.Location = new System.Drawing.Point(128, 94);
            this.rtbOriginal.Name = "rtbOriginal";
            this.rtbOriginal.Size = new System.Drawing.Size(305, 111);
            this.rtbOriginal.TabIndex = 15;
            this.rtbOriginal.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(284, 399);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 40);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(65, 399);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 40);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTituloReemplazo
            // 
            this.lblTituloReemplazo.AutoSize = true;
            this.lblTituloReemplazo.Location = new System.Drawing.Point(37, 247);
            this.lblTituloReemplazo.Name = "lblTituloReemplazo";
            this.lblTituloReemplazo.Size = new System.Drawing.Size(83, 17);
            this.lblTituloReemplazo.TabIndex = 12;
            this.lblTituloReemplazo.Text = "Reemplazo:";
            // 
            // lblTituloOriginal
            // 
            this.lblTituloOriginal.AutoSize = true;
            this.lblTituloOriginal.Location = new System.Drawing.Point(37, 106);
            this.lblTituloOriginal.Name = "lblTituloOriginal";
            this.lblTituloOriginal.Size = new System.Drawing.Size(61, 17);
            this.lblTituloOriginal.TabIndex = 11;
            this.lblTituloOriginal.Text = "Original:";
            // 
            // ModificarValidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 475);
            this.Controls.Add(this.rtbReemplazo);
            this.Controls.Add(this.rtbOriginal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTituloReemplazo);
            this.Controls.Add(this.lblTituloOriginal);
            this.Controls.Add(this.gbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarValidacion";
            this.Text = "Modificar Validación";
            this.gbTitulo.ResumeLayout(false);
            this.gbTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbTitulo;
        private System.Windows.Forms.RichTextBox rtbReemplazo;
        private System.Windows.Forms.RichTextBox rtbOriginal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTituloReemplazo;
        private System.Windows.Forms.Label lblTituloOriginal;
    }
}