using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VendasApp.Models;
using VendasApp.Models.Dto;
using VendasApp.Relatorios;
using VendasApp.Repository;
using VendasApp.Validacoes;

namespace VendasApp.Processamento
{
    public partial class FrmVendas : Form
    {
        private ClienteRepository clienteRepository;
        private VendasRepository vendasRepository;
        private ProdutoRepository produtoRepository;
        private FiltraVenda filtraVenda;
        private ValidaProduto validaProduto;
        private bool valida;
        private ValidaClienteNaVenda validaCliente;
        private List<Produto> estDisponivel;
        private bool pesquisaEstoque = false;


        public FrmVendas()
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            produtoRepository = new ProdutoRepository(new Data.Contexto());
            vendasRepository = new VendasRepository(new Data.Contexto());
            filtraVenda = new FiltraVenda();
            validaProduto = new ValidaProduto();
            validaCliente = new ValidaClienteNaVenda();
            estDisponivel = new List<Produto>();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            Bindings();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.MultiSelect = false;
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
            valida = validaCliente.ValidarCLienteNaVenda(vendas.IdCliente);

            if (valida)
            {
                vendas.NomeDoCliente = clienteRepository.BuscarPorId(vendas.IdCliente).Nome;
                dataGridView1.Enabled = true;
                Bs_Vendas.ResetCurrentItem();
            }
            else
            {
                MessageBox.Show("Cliente não encontrado, Verifique!");
                vendas.NomeDoCliente = "";
                vendas.IdCliente = null;
                Bs_Vendas.ResetCurrentItem();
            }
        }

        private void FrmVendas_Shown(object sender, EventArgs e)
        {
            maskedTextBoxNrPedido.Text = vendasRepository.BuscartodosPorID().Last().Id.ToString();
            dataGridView1.Columns[columnName: "ColumnCodigo"].DefaultCellStyle.Format = "###.##";
            dataGridView1.Enabled = false;
            buttonSalvar.Enabled = false;
            Bs_Vendas.AddNew();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int indice = 0;
            Vendas vendas = Bs_Vendas.Current as Vendas;

            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == 3)
                {
                    if (!pesquisaEstoque)
                    {
                        estDisponivel = produtoRepository.BuscarTodos();
                    }
                    // resolve a questão de lista com ID faltantes no nosso caso a lista não tem/tinha o ID = 4
                    // localizando o ID do item, posteriormente atribuimos ele a proxima validação no caso o if
                    foreach (Produto p in estDisponivel)
                    {
                        indice = estDisponivel.FindIndex(b => b.Id == (vendas.VendasItem[e.RowIndex].IdProduto));
                    }

                    if (estDisponivel[indice].Quantidade >= vendas.VendasItem[e.RowIndex].Quantidade)
                    {
                        if (estDisponivel[indice].Quantidade - vendas.VendasItem[e.RowIndex].Quantidade >= 0)
                        {
                            vendas.ValorTotal = vendas.VendasItem.Sum(a => a.Quantidade * a.Valor);
                            Bs_Vendas.ResetCurrentItem();
                            estDisponivel[indice].Quantidade -= vendas.VendasItem[e.RowIndex].Quantidade;
                            buttonSalvar.Enabled = true;
                        }
                        else
                        {
                            buttonSalvar.Enabled = false;
                            MessageBox.Show($"Produto {vendas.VendasItem[e.RowIndex].IdProduto} sem saldo");
                        }
                    }
                    else
                    {
                        buttonSalvar.Enabled = false;
                        MessageBox.Show($"Produto {vendas.VendasItem[e.RowIndex].IdProduto} sem saldo");
                    }

                }

                if (e.ColumnIndex == 0)
                {
                    valida = validaProduto.ValidarProduto(vendas.VendasItem[e.RowIndex].IdProduto);//valida se o codigo digitado do produto existe no BD

                    if (valida)
                    {
                        int rcCodigo = vendas.VendasItem[e.RowIndex].IdProduto;
                        vendas.VendasItem[e.RowIndex].NomeDoProduto = produtoRepository.BuscarPorId(rcCodigo).Descricao;
                        vendas.VendasItem[e.RowIndex].Valor = produtoRepository.BuscarPrecoPorId(rcCodigo).Preco;
                        vendas.ValorTotal = vendas.VendasItem.Sum(a => a.Quantidade * a.Valor);
                        Bs_Vendas.ResetCurrentItem();
                    }
                    else
                    {
                        vendas.VendasItem[e.RowIndex].IdProduto = 0;
                        MessageBox.Show("Produto não encontrado!");
                    }

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Vendas vendas = Bs_Vendas.Current as Vendas;
            vendasRepository.Inserir(vendas);
            foreach (var i in estDisponivel)
            {
                produtoRepository.Atualizar(i);
            }
            MessageBox.Show(" Pedido salvo com sucesso");
            maskedTextBoxNrPedido.Text = vendasRepository.BuscartodosPorID().Last().Id.ToString();
            buttonSalvar.Enabled = false;
            dataGridView1.Enabled = false;
            Bs_Vendas.AddNew();

            DialogResult dialogResult = MessageBox.Show("Deseja emitir o pedido?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                filtraVenda.CodigoPedido = Convert.ToInt32(maskedTextBoxNrPedido.Text);
                FrmRelatorioVendas form = new FrmRelatorioVendas(filtraVenda);
                form.ShowDialog();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            Vendas vendas = Bs_Vendas.Current as Vendas;
            if (e.ColumnIndex == 0)
            {
                int i;
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("O campo de Código está invalido, verifique!");
                }
            }

            if (e.ColumnIndex == 2)
            {
                decimal i;
                if (!decimal.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("O campo de Valor está invalido, verifique!");
                }
            }
            if (e.ColumnIndex == 3)
            {
                int i;
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("O campo de quantidade está invalido, verifique!");
                }
            }

        }
    }
}