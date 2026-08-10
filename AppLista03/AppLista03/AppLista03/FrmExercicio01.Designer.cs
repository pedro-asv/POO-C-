namespace AppLista03
{
    partial class FrmExercico1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercico1));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.lblRSoma = new System.Windows.Forms.Label();
            this.lblRMedia = new System.Windows.Forms.Label();
            this.lblRPorcentagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(66, 19);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(60, 25);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num1";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(71, 47);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(126, 32);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(223, 47);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(126, 32);
            this.txtNum2.TabIndex = 3;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(218, 19);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(60, 25);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Num2";
            // 
            // txtNum3
            // 
            this.txtNum3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum3.Location = new System.Drawing.Point(378, 47);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(119, 32);
            this.txtNum3.TabIndex = 5;
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.BackColor = System.Drawing.Color.Transparent;
            this.lblNum3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum3.Location = new System.Drawing.Point(373, 19);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(60, 25);
            this.lblNum3.TabIndex = 4;
            this.lblNum3.Text = "Num3";
            // 
            // btnSoma
            // 
            this.btnSoma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoma.BackgroundImage")));
            this.btnSoma.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSoma.Location = new System.Drawing.Point(80, 163);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(117, 60);
            this.btnSoma.TabIndex = 6;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPorcentagem.BackgroundImage")));
            this.btnPorcentagem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentagem.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnPorcentagem.Location = new System.Drawing.Point(389, 163);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(117, 60);
            this.btnPorcentagem.TabIndex = 7;
            this.btnPorcentagem.Text = "Porcentagem";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMedia.BackgroundImage")));
            this.btnMedia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnMedia.Location = new System.Drawing.Point(237, 163);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(117, 60);
            this.btnMedia.TabIndex = 8;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // lblRSoma
            // 
            this.lblRSoma.AutoSize = true;
            this.lblRSoma.BackColor = System.Drawing.Color.Transparent;
            this.lblRSoma.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSoma.Location = new System.Drawing.Point(12, 319);
            this.lblRSoma.Name = "lblRSoma";
            this.lblRSoma.Size = new System.Drawing.Size(167, 29);
            this.lblRSoma.TabIndex = 9;
            this.lblRSoma.Text = "Resultado Soma";
            // 
            // lblRMedia
            // 
            this.lblRMedia.AutoSize = true;
            this.lblRMedia.BackColor = System.Drawing.Color.Transparent;
            this.lblRMedia.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMedia.Location = new System.Drawing.Point(12, 355);
            this.lblRMedia.Name = "lblRMedia";
            this.lblRMedia.Size = new System.Drawing.Size(168, 29);
            this.lblRMedia.TabIndex = 10;
            this.lblRMedia.Text = "Resultado Média";
            // 
            // lblRPorcentagem
            // 
            this.lblRPorcentagem.AutoSize = true;
            this.lblRPorcentagem.BackColor = System.Drawing.Color.Transparent;
            this.lblRPorcentagem.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPorcentagem.Location = new System.Drawing.Point(12, 394);
            this.lblRPorcentagem.Name = "lblRPorcentagem";
            this.lblRPorcentagem.Size = new System.Drawing.Size(239, 29);
            this.lblRPorcentagem.TabIndex = 11;
            this.lblRPorcentagem.Text = "Resultado Porcentagem";
            // 
            // FrmExercico1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.lblRPorcentagem);
            this.Controls.Add(this.lblRMedia);
            this.Controls.Add(this.lblRSoma);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.lblNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum1);
            this.Name = "FrmExercico1";
            this.Text = "FrmApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Label lblRSoma;
        private System.Windows.Forms.Label lblRMedia;
        private System.Windows.Forms.Label lblRPorcentagem;
    }
}

