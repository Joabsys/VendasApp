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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBoxIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxNomeCliente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxValorTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bs_Vendas = new System.Windows.Forms.BindingSource(this.components);
            this.bs_NrPedido = new System.Windows.Forms.BindingSource(this.components);
            this.maskedTextBoxNrPedido = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bs_Vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_NrPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(441, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBoxIdCliente
            // 
            this.maskedTextBoxIdCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxIdCliente.Location = new System.Drawing.Point(13, 92);
            this.maskedTextBoxIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxIdCliente.Mask = "00000";
            this.maskedTextBoxIdCliente.Name = "maskedTextBoxIdCliente";
            this.maskedTextBoxIdCliente.Size = new System.Drawing.Size(116, 26);
            this.maskedTextBoxIdCliente.TabIndex = 0;
            this.maskedTextBoxIdCliente.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digitação do Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnProduto,
            this.ColumnValor,
            this.ColumnQuantidade,
            this.CdCliente,
            this.ClienteNome,
            this.Id});
            this.dataGridView1.Location = new System.Drawing.Point(19, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 344);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridView1_CellStateChanged);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // maskedTextBoxNomeCliente
            // 
            this.maskedTextBoxNomeCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNomeCliente.Location = new System.Drawing.Point(137, 92);
            this.maskedTextBoxNomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxNomeCliente.Name = "maskedTextBoxNomeCliente";
            this.maskedTextBoxNomeCliente.ReadOnly = true;
            this.maskedTextBoxNomeCliente.Size = new System.Drawing.Size(261, 26);
            this.maskedTextBoxNomeCliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "ValorTotal";
            // 
            // maskedTextBoxValorTotal
            // 
            this.maskedTextBoxValorTotal.Enabled = false;
            this.maskedTextBoxValorTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxValorTotal.Location = new System.Drawing.Point(19, 162);
            this.maskedTextBoxValorTotal.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxValorTotal.Name = "maskedTextBoxValorTotal";
            this.maskedTextBoxValorTotal.ReadOnly = true;
            this.maskedTextBoxValorTotal.Size = new System.Drawing.Size(116, 26);
            this.maskedTextBoxValorTotal.TabIndex = 14;
            this.maskedTextBoxValorTotal.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::VendasApp.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(642, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 24);
            this.panel1.TabIndex = 16;
            // 
            // Bs_Vendas
            // 
            this.Bs_Vendas.DataSource = typeof(VendasApp.Models.Vendas);
            // 
            // bs_NrPedido
            // 
            this.bs_NrPedido.DataSource = typeof(VendasApp.Models.Vendas);
            // 
            // maskedTextBoxNrPedido
            // 
            this.maskedTextBoxNrPedido.Enabled = false;
            this.maskedTextBoxNrPedido.Location = new System.Drawing.Point(551, 89);
            this.maskedTextBoxNrPedido.Name = "maskedTextBoxNrPedido";
            this.maskedTextBoxNrPedido.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxNrPedido.TabIndex = 17;
            this.maskedTextBoxNrPedido.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "N° Ultimo Ped. Digitado";
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.DataPropertyName = "IdProduto";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.ColumnCodigo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            // 
            // ColumnProduto
            // 
            this.ColumnProduto.DataPropertyName = "NomeDoProduto";
            this.ColumnProduto.HeaderText = "Produto";
            this.ColumnProduto.Name = "ColumnProduto";
            this.ColumnProduto.ReadOnly = true;
            // 
            // ColumnValor
            // 
            this.ColumnValor.DataPropertyName = "Valor";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.ColumnValor.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            // 
            // ColumnQuantidade
            // 
            this.ColumnQuantidade.DataPropertyName = "Quantidade";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.ColumnQuantidade.DefaultCellStyle = dataGridViewCellStyle6;
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(670, 588);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxNrPedido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBoxValorTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxIdCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diditação de Pedidos";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.Shown += new System.EventHandler(this.FrmVendas_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bs_Vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_NrPedido)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bs_NrPedido;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNrPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}