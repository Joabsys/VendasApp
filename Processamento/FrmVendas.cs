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
        private ValidaClienteNaVenda ValidaCliente;

        public FrmVendas()
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            produtoRepository = new ProdutoRepository(new Data.Contexto());
            vendasRepository = new VendasRepository(new Data.Contexto());
            filtraVenda = new FiltraVenda();
            validaProduto = new ValidaProduto();
            ValidaCliente = new ValidaClienteNaVenda();
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
            valida = ValidaCliente.ValidarCLienteNaVenda(vendas.IdCliente);

            if (valida)
            {
                vendas.NomeDoCliente = clienteRepository.BuscarPorId(vendas.IdCliente).Nome;
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
            

            Bs_Vendas.AddNew();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Vendas vendas = Bs_Vendas.Current as Vendas;
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3)
                {

                    vendas.ValorTotal = vendas.VendasItem.Sum(a => a.Quantidade * a.Valor);
                    Bs_Vendas.ResetCurrentItem();
                }
                if (e.ColumnIndex == 0)
                {

                    valida = validaProduto.ValidarProduto(vendas.VendasItem[e.RowIndex].IdProduto);

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
                        MessageBox.Show("Produto não encontrado!");
                        vendas.VendasItem[e.RowIndex].NomeDoProduto = "";
                        vendas.VendasItem[e.RowIndex].Valor = 0;

                    }

                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Vendas vendas = Bs_Vendas.Current as Vendas;
            vendasRepository.Inserir(vendas);
            MessageBox.Show(" Pedido salvo com sucesso");
            maskedTextBoxNrPedido.Text = vendasRepository.BuscartodosPorID().Last().Id.ToString();
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

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {

                dataGridView1.Columns[columnName: "ColumnCodigo"].DefaultCellStyle.Format = "###.##";
            }
           
        }
    }
}
