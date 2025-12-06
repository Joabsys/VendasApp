using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
        private ProdutoRepository produtoRepository;

        public FrmVendas()
        {
            InitializeComponent();

            clienteRepository = new ClienteRepository(new Data.Contexto());
            produtoRepository = new ProdutoRepository(new Data.Contexto());
            vendasRepository = new VendasRepository(new Data.Contexto());
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
                if (vendasCliente != null)
                {
                    vendas.NomeDoCliente = vendasCliente.Nome;
                }
                else
                {
                    MessageBox.Show("Cliente não existe verifique!");
                }
                
                Bs_Vendas.ResetCurrentItem();
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
                Object rcCodigo = dataGridView1.Rows[e.RowIndex].Cells[columnName: ColumnCodigo.Name].Value;
                //Object rcValor = dataGridView1.Rows[e.RowIndex].Cells[columnName: ColumnValor.Name].Value;
                //Object rcQuantidade = dataGridView1.Rows[e.RowIndex].Cells[columnName: ColumnQuantidade.Name].Value;
                VendasItem vendasItem = new VendasItem();

                if (rcCodigo != null)
                {
                    vendasItem.IdProduto = Convert.ToInt32(rcCodigo);
                    Produto nomeDoProduto = produtoRepository.BuscarPorId(vendasItem.IdProduto);
                    //atribui o valor "pego" em  valorOfIndex e passa para a columnName desejada
                    dataGridView1.Rows[e.RowIndex].Cells[columnName: ColumnProduto.Name].Value = nomeDoProduto.Descricao;

                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Vendas vendas = Bs_Vendas.Current as Vendas;
            

                vendasRepository.Inserir(vendas);
                MessageBox.Show(" Pedido salvo com sucesso");
            
            Bs_Vendas.AddNew();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Object rcValor = dataGridView1.Rows[e.RowIndex].Cells[columnName: ColumnValor.Name].Value;
            Object rcQuantidade = dataGridView1.Rows[e.RowIndex].Cells[columnName: ColumnQuantidade.Name].Value;

            if (e.ColumnIndex == 3)
            {

                Vendas vendas = Bs_Vendas.Current as Vendas;
                VendasItem vendasItem = new VendasItem();
                

                    //faz o calculo somente da linha e soma no valor total
                    for (int i=e.RowIndex;i<= e.RowIndex;i++)
                    {
                        vendas.ValorTotal += Convert.ToInt32(rcValor)* Convert.ToInt32(rcQuantidade);

                    }
                    Bs_Vendas.ResetCurrentItem();
               
            }

        }
    }
}
