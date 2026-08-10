namespace ProjetoMensagem
{
    partial class frmDiginhoMensagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiginhoMensagens));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblInteiro = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.txtInteiro = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtBooleano = new System.Windows.Forms.TextBox();
            this.lblBooleano = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackgroundImage = global::ProjetoMensagem.Properties.Resources.maxresdefault;
            this.btnMostrar.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnMostrar.Location = new System.Drawing.Point(12, 301);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(119, 64);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblInteiro
            // 
            this.lblInteiro.AutoSize = true;
            this.lblInteiro.BackColor = System.Drawing.Color.Transparent;
            this.lblInteiro.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteiro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInteiro.Location = new System.Drawing.Point(81, 26);
            this.lblInteiro.Name = "lblInteiro";
            this.lblInteiro.Size = new System.Drawing.Size(87, 25);
            this.lblInteiro.TabIndex = 1;
            this.lblInteiro.Text = "Inteiro";
            this.lblInteiro.Click += new System.EventHandler(this.lblInteiro_Click);
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.BackColor = System.Drawing.Color.Transparent;
            this.lblDecimal.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDecimal.Location = new System.Drawing.Point(81, 92);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(101, 25);
            this.lblDecimal.TabIndex = 2;
            this.lblDecimal.Text = "Decimal";
            // 
            // txtInteiro
            // 
            this.txtInteiro.Location = new System.Drawing.Point(85, 54);
            this.txtInteiro.Name = "txtInteiro";
            this.txtInteiro.Size = new System.Drawing.Size(176, 20);
            this.txtInteiro.TabIndex = 3;
            this.txtInteiro.TextChanged += new System.EventHandler(this.txtInteiro_TextChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(85, 177);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(185, 20);
            this.txtTexto.TabIndex = 5;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTexto.Location = new System.Drawing.Point(81, 149);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(71, 25);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Texto";
            // 
            // txtBooleano
            // 
            this.txtBooleano.Location = new System.Drawing.Point(85, 243);
            this.txtBooleano.Name = "txtBooleano";
            this.txtBooleano.Size = new System.Drawing.Size(185, 20);
            this.txtBooleano.TabIndex = 7;
            // 
            // lblBooleano
            // 
            this.lblBooleano.AutoSize = true;
            this.lblBooleano.BackColor = System.Drawing.Color.Transparent;
            this.lblBooleano.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooleano.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBooleano.Location = new System.Drawing.Point(81, 215);
            this.lblBooleano.Name = "lblBooleano";
            this.lblBooleano.Size = new System.Drawing.Size(114, 25);
            this.lblBooleano.TabIndex = 6;
            this.lblBooleano.Text = "Booleano";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(85, 120);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(176, 20);
            this.txtDecimal.TabIndex = 8;
            this.txtDecimal.TextChanged += new System.EventHandler(this.txtDecimal_TextChanged);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpa.BackgroundImage = global::ProjetoMensagem.Properties.Resources.maxresdefault;
            this.btnLimpa.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpa.ForeColor = System.Drawing.Color.Red;
            this.btnLimpa.Location = new System.Drawing.Point(210, 301);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(119, 64);
            this.btnLimpa.TabIndex = 9;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // frmDiginhoMensagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoMensagem.Properties.Resources.joao_kleber_e_o_convidado_do_the_noite_nesta_quinta_feira_25_5cc1d6220b11a__1_;
            this.ClientSize = new System.Drawing.Size(336, 405);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBooleano);
            this.Controls.Add(this.lblBooleano);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtInteiro);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblInteiro);
            this.Controls.Add(this.btnMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDiginhoMensagens";
            this.Text = "DiguinhoMensagens";
            this.Load += new System.EventHandler(this.frmDiginhoMensagens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblInteiro;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.TextBox txtInteiro;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtBooleano;
        private System.Windows.Forms.Label lblBooleano;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnLimpa;
    }
}

