namespace ValidarCpf
{
    partial class Form1
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
            this.btnValidarCpf = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidarCpf
            // 
            this.btnValidarCpf.FlatAppearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnValidarCpf.FlatAppearance.BorderSize = 5;
            this.btnValidarCpf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnValidarCpf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidarCpf.Location = new System.Drawing.Point(89, 122);
            this.btnValidarCpf.Name = "btnValidarCpf";
            this.btnValidarCpf.Size = new System.Drawing.Size(129, 57);
            this.btnValidarCpf.TabIndex = 0;
            this.btnValidarCpf.Text = "Verificar";
            this.btnValidarCpf.UseVisualStyleBackColor = true;
            this.btnValidarCpf.Click += new System.EventHandler(this.btnValidarCpf_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCpf.Location = new System.Drawing.Point(59, 69);
            this.txtCpf.MaxLength = 11;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(178, 20);
            this.txtCpf.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freshman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um CPF.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(306, 316);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnValidarCpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidarCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label1;
    }
}

