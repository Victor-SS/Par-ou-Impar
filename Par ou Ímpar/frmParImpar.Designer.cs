namespace Par_ou_Ímpar
{
    partial class frmParImpar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParImpar));
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblPar = new System.Windows.Forms.Label();
            this.lblImpar = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(35, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(283, 20);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Digite um número inteiro entre 1 e 100:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(353, 22);
            this.txtNumero.MaxLength = 3;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(66, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblPar
            // 
            this.lblPar.BackColor = System.Drawing.Color.Red;
            this.lblPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPar.Location = new System.Drawing.Point(16, 64);
            this.lblPar.Name = "lblPar";
            this.lblPar.Size = new System.Drawing.Size(440, 49);
            this.lblPar.TabIndex = 3;
            this.lblPar.Text = "Par";
            this.lblPar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImpar
            // 
            this.lblImpar.BackColor = System.Drawing.Color.Green;
            this.lblImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblImpar.Location = new System.Drawing.Point(16, 64);
            this.lblImpar.Name = "lblImpar";
            this.lblImpar.Size = new System.Drawing.Size(440, 49);
            this.lblImpar.TabIndex = 4;
            this.lblImpar.Text = "Ímpar";
            this.lblImpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Image = global::Par_ou_Ímpar.Properties.Resources.checks;
            this.btnVerificar.Location = new System.Drawing.Point(249, 124);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(207, 60);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "&Verificar Campos";
            this.btnVerificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::Par_ou_Ímpar.Properties.Resources.eraser2;
            this.btnLimpar.Location = new System.Drawing.Point(16, 124);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(227, 60);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "&Limpar Campos";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmParImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 196);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblImpar);
            this.Controls.Add(this.lblPar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParImpar";
            this.Text = "Par ou Ímpar ?";
            this.Load += new System.EventHandler(this.frmParImpar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblPar;
        private System.Windows.Forms.Label lblImpar;
        private System.Windows.Forms.Button btnVerificar;
    }
}

