namespace AppLista03
{
    partial class FrmExercico06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercico06));
            this.lblRSoma = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRSoma
            // 
            this.lblRSoma.AutoSize = true;
            this.lblRSoma.BackColor = System.Drawing.Color.Transparent;
            this.lblRSoma.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSoma.ForeColor = System.Drawing.Color.Indigo;
            this.lblRSoma.Location = new System.Drawing.Point(124, 350);
            this.lblRSoma.Name = "lblRSoma";
            this.lblRSoma.Size = new System.Drawing.Size(63, 29);
            this.lblRSoma.TabIndex = 13;
            this.lblRSoma.Text = "Cubo";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(114, 186);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(126, 32);
            this.txtNum1.TabIndex = 11;
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNum1.Location = new System.Drawing.Point(109, 158);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(78, 25);
            this.lblNum1.TabIndex = 10;
            this.lblNum1.Text = "Numero";
            // 
            // btnSoma
            // 
            this.btnSoma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSoma.BackgroundImage")));
            this.btnSoma.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.Color.Blue;
            this.btnSoma.Image = global::AppLista03.Properties.Resources.hayasaka_ai_hayasaka;
            this.btnSoma.Location = new System.Drawing.Point(114, 224);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(117, 60);
            this.btnSoma.TabIndex = 12;
            this.btnSoma.Text = "Calcular Cubo";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Exercício06";
            // 
            // FrmExercico06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppLista03.Properties.Resources.hayasaka_ai_hayasaka;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRSoma);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum1);
            this.Name = "FrmExercico06";
            this.Text = "FrmExercico06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRSoma;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label label1;
    }
}