namespace AppLista03
{
    partial class FrmExercico02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercico02));
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblExercico = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.pnlTopo.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblResultado.Location = new System.Drawing.Point(14, 127);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(137, 29);
            this.lblResultado.TabIndex = 21;
            this.lblResultado.Text = "Valor a pagar";
            // 
            // lblExercico
            // 
            this.lblExercico.AutoSize = true;
            this.lblExercico.BackColor = System.Drawing.Color.Transparent;
            this.lblExercico.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercico.ForeColor = System.Drawing.Color.Yellow;
            this.lblExercico.Location = new System.Drawing.Point(8, 9);
            this.lblExercico.Name = "lblExercico";
            this.lblExercico.Size = new System.Drawing.Size(111, 25);
            this.lblExercico.TabIndex = 16;
            this.lblExercico.Text = "Exercício02";
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(51, 96);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(207, 32);
            this.txtNum2.TabIndex = 15;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.ForeColor = System.Drawing.Color.Yellow;
            this.lblNum2.Location = new System.Drawing.Point(37, 150);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(101, 25);
            this.lblNum2.TabIndex = 14;
            this.lblNum2.Text = "Valor Litro";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(51, 178);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(207, 32);
            this.txtNum1.TabIndex = 13;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.Yellow;
            this.lblNum1.Location = new System.Drawing.Point(37, 54);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(125, 25);
            this.lblNum1.TabIndex = 12;
            this.lblNum1.Text = "Valor a Pagar";
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.Yellow;
            this.btnResultado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResultado.BackgroundImage")));
            this.btnResultado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnResultado.Location = new System.Drawing.Point(100, 28);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(117, 60);
            this.btnResultado.TabIndex = 18;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // pnlTopo
            // 
            this.pnlTopo.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlTopo.Controls.Add(this.txtNum1);
            this.pnlTopo.Controls.Add(this.txtNum2);
            this.pnlTopo.Controls.Add(this.lblNum2);
            this.pnlTopo.Controls.Add(this.lblExercico);
            this.pnlTopo.Controls.Add(this.lblNum1);
            this.pnlTopo.Location = new System.Drawing.Point(-2, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(368, 224);
            this.pnlTopo.TabIndex = 22;
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.Yellow;
            this.pnlBase.Controls.Add(this.btnResultado);
            this.pnlBase.Controls.Add(this.lblResultado);
            this.pnlBase.Location = new System.Drawing.Point(-2, 216);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(368, 234);
            this.pnlBase.TabIndex = 23;
            // 
            // FrmExercico02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.pnlBase);
            this.Name = "FrmExercico02";
            this.Text = "FrmExercico02";
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblExercico;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel pnlBase;
    }
}