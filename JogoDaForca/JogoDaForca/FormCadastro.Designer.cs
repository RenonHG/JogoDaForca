namespace JogoDaForca
{
    partial class FormCadastro
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
            this.ListViewCadastro = new System.Windows.Forms.ListView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbCadastro = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.txbRemover = new System.Windows.Forms.TextBox();
            this.txbAlterar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListViewCadastro
            // 
            this.ListViewCadastro.HideSelection = false;
            this.ListViewCadastro.Location = new System.Drawing.Point(33, 23);
            this.ListViewCadastro.Name = "ListViewCadastro";
            this.ListViewCadastro.Size = new System.Drawing.Size(319, 297);
            this.ListViewCadastro.TabIndex = 0;
            this.ListViewCadastro.UseCompatibleStateImageBehavior = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(256, 335);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 25);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbCadastro
            // 
            this.txbCadastro.Location = new System.Drawing.Point(33, 335);
            this.txbCadastro.Name = "txbCadastro";
            this.txbCadastro.Size = new System.Drawing.Size(200, 20);
            this.txbCadastro.TabIndex = 0;
            this.txbCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCadastro_KeyPress);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(256, 399);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(96, 25);
            this.btn.TabIndex = 2;
            this.btn.Text = "ALTERAR";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(256, 366);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(96, 25);
            this.BtnRemover.TabIndex = 3;
            this.BtnRemover.Text = "REMOVER";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // txbRemover
            // 
            this.txbRemover.Location = new System.Drawing.Point(33, 369);
            this.txbRemover.Name = "txbRemover";
            this.txbRemover.Size = new System.Drawing.Size(200, 20);
            this.txbRemover.TabIndex = 4;
            // 
            // txbAlterar
            // 
            this.txbAlterar.Location = new System.Drawing.Point(33, 402);
            this.txbAlterar.Name = "txbAlterar";
            this.txbAlterar.Size = new System.Drawing.Size(200, 20);
            this.txbAlterar.TabIndex = 5;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 436);
            this.Controls.Add(this.txbAlterar);
            this.Controls.Add(this.txbRemover);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txbCadastro);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ListViewCadastro);
            this.Name = "FormCadastro";
            this.Text = "FormCadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbCadastro;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.TextBox txbRemover;
        private System.Windows.Forms.TextBox txbAlterar;
    }
}