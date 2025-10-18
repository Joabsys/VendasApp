namespace VendasApp.Crud
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
            this.components = new System.ComponentModel.Container();
            this.maskedTextBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxLogin = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Bs_Usuario = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUltimoLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bs_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxCodigo
            // 
            this.maskedTextBoxCodigo.Location = new System.Drawing.Point(16, 59);
            this.maskedTextBoxCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxCodigo.Mask = "00000";
            this.maskedTextBoxCodigo.Name = "maskedTextBoxCodigo";
            this.maskedTextBoxCodigo.Size = new System.Drawing.Size(128, 22);
            this.maskedTextBoxCodigo.TabIndex = 0;
            this.maskedTextBoxCodigo.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // maskedTextBoxLogin
            // 
            this.maskedTextBoxLogin.Location = new System.Drawing.Point(16, 116);
            this.maskedTextBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxLogin.Name = "maskedTextBoxLogin";
            this.maskedTextBoxLogin.Size = new System.Drawing.Size(341, 22);
            this.maskedTextBoxLogin.TabIndex = 2;
            // 
            // maskedTextBoxSenha
            // 
            this.maskedTextBoxSenha.Location = new System.Drawing.Point(16, 167);
            this.maskedTextBoxSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            this.maskedTextBoxSenha.PasswordChar = '*';
            this.maskedTextBoxSenha.Size = new System.Drawing.Size(341, 22);
            this.maskedTextBoxSenha.TabIndex = 3;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(411, 167);
            this.checkBoxAtivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(59, 20);
            this.checkBoxAtivo.TabIndex = 4;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ativoDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.dataUltimoLoginDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.Bs_Usuario;
            this.dataGridView1.Location = new System.Drawing.Point(16, 220);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(933, 282);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(849, 510);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bs_Usuario
            // 
            this.Bs_Usuario.DataSource = typeof(VendasApp.Models.Usuario);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewTextBoxColumn
            // 
            this.ativoDataGridViewTextBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewTextBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewTextBoxColumn.Name = "ativoDataGridViewTextBoxColumn";
            this.ativoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ativoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ativoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ativoDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            this.senhaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataUltimoLoginDataGridViewTextBoxColumn
            // 
            this.dataUltimoLoginDataGridViewTextBoxColumn.DataPropertyName = "DataUltimoLogin";
            this.dataUltimoLoginDataGridViewTextBoxColumn.HeaderText = "DataUltimoLogin";
            this.dataUltimoLoginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataUltimoLoginDataGridViewTextBoxColumn.Name = "dataUltimoLoginDataGridViewTextBoxColumn";
            this.dataUltimoLoginDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataUltimoLoginDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 548);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.maskedTextBoxSenha);
            this.Controls.Add(this.maskedTextBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxCodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.Shown += new System.EventHandler(this.FrmUsuario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bs_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSenha;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource Bs_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUltimoLoginDataGridViewTextBoxColumn;
    }
}