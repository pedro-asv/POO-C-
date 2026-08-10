namespace ProjetoFluxograma
{
    partial class FrmFluxo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblsolicitar = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(37, 129);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(123, 54);
            this.btnResultado.TabIndex = 0;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblsolicitar
            // 
            this.lblsolicitar.AutoSize = true;
            this.lblsolicitar.Location = new System.Drawing.Point(34, 34);
            this.lblsolicitar.Name = "lblsolicitar";
            this.lblsolicitar.Size = new System.Drawing.Size(76, 13);
            this.lblsolicitar.TabIndex = 1;
            this.lblsolicitar.Text = "Raiz quadrada";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(37, 73);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(123, 20);
            this.txtresultado.TabIndex = 2;
            // 
            // FrmFluxo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 277);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lblsolicitar);
            this.Controls.Add(this.btnResultado);
            this.Name = "FrmFluxo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblsolicitar;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

