namespace VendasApp.Processamento
{
    partial class FrmVendas
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
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBoxIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBoxNomeCliente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxValorTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Bs_Vendas = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bs_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBoxIdCliente
            // 
            this.maskedTextBoxIdCliente.Location = new System.Drawing.Point(12, 58);
            this.maskedTextBoxIdCliente.Name = "maskedTextBoxIdCliente";
            this.maskedTextBoxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxIdCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digitação do Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnProduto,
            this.ColumnValor,
            this.ColumnQuantidade,
            this.CdCliente,
            this.ClienteNome});
            this.dataGridView1.Location = new System.Drawing.Point(16, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 263);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "IdProduto";
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            // 
            // ColumnProduto
            // 
            this.ColumnProduto.DataPropertyName = "NomeDoProduto";
            this.ColumnProduto.HeaderText = "Produto";
            this.ColumnProduto.Name = "ColumnProduto";
            // 
            // ColumnValor
            // 
            this.ColumnValor.DataPropertyName = "Valor";
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.DataPropertyName = "Quantidade";
            this.ColumnQuantidade.HeaderText = "Quantidade";
            this.ColumnQuantidade.Name = "ColumnQuantidade";
            // 
            // CdCliente
            // 
            this.CdCliente.DataPropertyName = "IdCliente";
            this.CdCliente.HeaderText = "Codigo  do CLiente";
            this.CdCliente.Name = "CdCliente";
            this.CdCliente.Visible = false;
            // 
            // ClienteNome
            // 
            this.ClienteNome.DataPropertyName = "NomeDoCliente";
            this.ClienteNome.HeaderText = "CLiente";
            this.ClienteNome.Name = "ClienteNome";
            this.ClienteNome.Visible = false;
            // 
            // maskedTextBoxNomeCliente
            // 
            this.maskedTextBoxNomeCliente.Location = new System.Drawing.Point(118, 58);
            this.maskedTextBoxNomeCliente.Name = "maskedTextBoxNomeCliente";
            this.maskedTextBoxNomeCliente.ReadOnly = true;
            this.maskedTextBoxNomeCliente.Size = new System.Drawing.Size(224, 20);
            this.maskedTextBoxNomeCliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ValorTotal";
            // 
            // maskedTextBoxValorTotal
            // 
            this.maskedTextBoxValorTotal.Enabled = false;
            this.maskedTextBoxValorTotal.Location = new System.Drawing.Point(16, 124);
            this.maskedTextBoxValorTotal.Name = "maskedTextBoxValorTotal";
            this.maskedTextBoxValorTotal.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxValorTotal.TabIndex = 14;
            this.maskedTextBoxValorTotal.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bs_Vendas
            // 
            this.Bs_Vendas.DataSource = typeof(VendasApp.Models.Vendas);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBoxValorTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxIdCliente);
            this.Controls.Add(this.button1);
            this.Name = "FrmVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.Shown += new System.EventHandler(this.FrmVendas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bs_Vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maskedTextBoxValorTotal;
        private System.Windows.Forms.BindingSource Bs_Vendas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNome;
    }
}