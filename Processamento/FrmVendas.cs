using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasApp.Models;
using VendasApp.Repository;

namespace VendasApp.Processamento
{
    public partial class FrmVendas : Form
    {
        private ClienteRepository clienteRepository;
        private VendasRepository vendasRepository;
        public ProdutoRepository produtoRepository;
        
        public FrmVendas()
        {
            InitializeComponent();

            clienteRepository = new ClienteRepository(new Data.Contexto());
            produtoRepository = new ProdutoRepository(new Data.Contexto());
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            Bindings();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataMember = nameof(Vendas.VendasItem);
            dataGridView1.DataSource = Bs_Vendas;

        }

        private void Bindings()
        {
            // maskedTextBoxCodigo.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Id), true));
            maskedTextBoxIdCliente.DataBindings.Add(new Binding("Text", Bs_Vendas, nameof(Vendas.IdCliente), true));
            maskedTextBoxNomeCliente.DataBindings.Add(new Binding("Text", Bs_Vendas, nameof(Vendas.NomeDoCliente), true));
            maskedTextBoxValorTotal.DataBindings.Add(new Binding("Text", Bs_Vendas, nameof(Vendas.ValorTotal), true));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendas vendas = Bs_Vendas.Current as Vendas;
            if (vendas.IdCliente != 0)
            {
              
                Cliente vendasCliente = clienteRepository.BuscarPorId(vendas.IdCliente);
                vendas.NomeDoCliente = vendasCliente.Nome;

                foreach (var i in vendas.VendasItem)
                {
                    vendas.ValorTotal += (i.Valor * i.Quantidade);

                }

                Bs_Vendas.ResetCurrentItem();
                MessageBox.Show($"Pedido com valor de R${vendas.ValorTotal} Reais salvo com sucesso!");
            }
        }

        private void FrmVendas_Shown(object sender, EventArgs e)
        {
            Bs_Vendas.AddNew();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {

                //pegar o valor dentro da linha/coluna
                Object valorOfIndex = dataGridView1.Rows[e.RowIndex].Cells[columnName: ColumnCodigo.Name].Value;
                VendasItem vendasItem = new VendasItem();
                
                if (valorOfIndex != null)
                {
                    vendasItem.IdProduto = Convert.ToInt32(valorOfIndex);
                    Produto NomeDoProduto = produtoRepository.BuscarPorId(vendasItem.IdProduto);
                    //atribui o valor "pego" em  valorOfIndex e passa para a columnName desejada
                    dataGridView1.Rows[e.RowIndex].Cells[columnName: ColumnProduto.Name].Value = NomeDoProduto.Descricao;

                }

            }


        }
    }
}
