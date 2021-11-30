namespace _3A1LAURA26.Ui
{
    partial class FrmUsuario
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
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.linkCrudDados = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(25, 65);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(31, 13);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF*";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(62, 62);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(132, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Text = "99999999999";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(249, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(200, 65);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "EMAIL*";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(457, 62);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(114, 20);
            this.txtSenha.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(403, 65);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(48, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "SENHA*";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(182, 111);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(104, 20);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(137, 114);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "NOME";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(313, 114);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(63, 13);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Location = new System.Drawing.Point(35, 183);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(162, 37);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAlterar.Location = new System.Drawing.Point(223, 183);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(162, 37);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluir.Location = new System.Drawing.Point(409, 183);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(162, 37);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvListar
            // 
            this.dgvListar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Location = new System.Drawing.Point(12, 237);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.Size = new System.Drawing.Size(570, 213);
            this.dgvListar.TabIndex = 29;
            this.dgvListar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListar_CellClick);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(382, 111);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(104, 20);
            this.txtTelefone.TabIndex = 30;
            // 
            // linkCrudDados
            // 
            this.linkCrudDados.AutoSize = true;
            this.linkCrudDados.Location = new System.Drawing.Point(9, 9);
            this.linkCrudDados.Name = "linkCrudDados";
            this.linkCrudDados.Size = new System.Drawing.Size(85, 13);
            this.linkCrudDados.TabIndex = 43;
            this.linkCrudDados.TabStop = true;
            this.linkCrudDados.Text = "CRUD de dados";
            this.linkCrudDados.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCrudDados_LinkClicked);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(594, 462);
            this.Controls.Add(this.linkCrudDados);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblCPF);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.LinkLabel linkCrudDados;
    }
}