namespace VendasApp.Crud
{
    partial class FrmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.maskedTextBoxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_Produto = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxDescricao = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDTValidade = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDTInclusao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBoxCodigo
            // 
            this.maskedTextBoxCodigo.Location = new System.Drawing.Point(12, 40);
            this.maskedTextBoxCodigo.Name = "maskedTextBoxCodigo";
            this.maskedTextBoxCodigo.ReadOnly = true;
            this.maskedTextBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCodigo.TabIndex = 0;
            // 
            // maskedTextBoxQuantidade
            // 
            this.maskedTextBoxQuantidade.Location = new System.Drawing.Point(12, 160);
            this.maskedTextBoxQuantidade.Name = "maskedTextBoxQuantidade";
            this.maskedTextBoxQuantidade.Size = new System.Drawing.Size(213, 20);
            this.maskedTextBoxQuantidade.TabIndex = 1;
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(12, 103);
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(213, 20);
            this.maskedTextBoxPreco.TabIndex = 2;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.Location = new System.Drawing.Point(154, 42);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(50, 17);
            this.checkBoxAtivo.TabIndex = 3;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ativoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.dataInclusaoDataGridViewTextBoxColumn,
            this.dataValidadeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.BS_Produto;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 184);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ativoDataGridViewTextBoxColumn
            // 
            this.ativoDataGridViewTextBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewTextBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewTextBoxColumn.Name = "ativoDataGridViewTextBoxColumn";
            this.ativoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ativoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ativoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.precoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInclusaoDataGridViewTextBoxColumn
            // 
            this.dataInclusaoDataGridViewTextBoxColumn.DataPropertyName = "DataInclusao";
            this.dataInclusaoDataGridViewTextBoxColumn.HeaderText = "DataInclusao";
            this.dataInclusaoDataGridViewTextBoxColumn.Name = "dataInclusaoDataGridViewTextBoxColumn";
            this.dataInclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataInclusaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            this.dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "DataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.HeaderText = "DataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            this.dataValidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BS_Produto
            // 
            this.BS_Produto.DataSource = typeof(VendasApp.Models.Produto);
            this.BS_Produto.CurrentChanged += new System.EventHandler(this.BS_Produto_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preço";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descrição";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maskedTextBoxDescricao
            // 
            this.maskedTextBoxDescricao.Location = new System.Drawing.Point(337, 42);
            this.maskedTextBoxDescricao.Name = "maskedTextBoxDescricao";
            this.maskedTextBoxDescricao.Size = new System.Drawing.Size(187, 20);
            this.maskedTextBoxDescricao.TabIndex = 11;
            this.maskedTextBoxDescricao.TextChanged += new System.EventHandler(this.maskedTextBoxDescricao_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Novo Cadastro";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data de Validade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data de Inclusão";
            // 
            // dateTimePickerDTValidade
            // 
            this.dateTimePickerDTValidade.Location = new System.Drawing.Point(337, 103);
            this.dateTimePickerDTValidade.Name = "dateTimePickerDTValidade";
            this.dateTimePickerDTValidade.Size = new System.Drawing.Size(187, 20);
            this.dateTimePickerDTValidade.TabIndex = 17;
            // 
            // dateTimePickerDTInclusao
            // 
            this.dateTimePickerDTInclusao.AllowDrop = true;
            this.dateTimePickerDTInclusao.Enabled = false;
            this.dateTimePickerDTInclusao.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerDTInclusao.Location = new System.Drawing.Point(337, 161);
            this.dateTimePickerDTInclusao.Name = "dateTimePickerDTInclusao";
            this.dateTimePickerDTInclusao.Size = new System.Drawing.Size(187, 20);
            this.dateTimePickerDTInclusao.TabIndex = 18;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerDTInclusao);
            this.Controls.Add(this.dateTimePickerDTValidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.maskedTextBoxDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBoxAtivo);
            this.Controls.Add(this.maskedTextBoxPreco);
            this.Controls.Add(this.maskedTextBoxQuantidade);
            this.Controls.Add(this.maskedTextBoxCodigo);
            this.Name = "FrmProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.Shown += new System.EventHandler(this.FrmProduto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maskedTextBoxDescricao;
        private System.Windows.Forms.BindingSource BS_Produto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDTValidade;
        private System.Windows.Forms.DateTimePicker dateTimePickerDTInclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidadeDataGridViewTextBoxColumn;
    }
}