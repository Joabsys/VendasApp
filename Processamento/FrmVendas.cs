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
        


        public FrmVendas()
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            produtoRepository = new ProdutoRepository(new Data.Contexto());
            vendasRepository = new VendasRepository(new Data.Contexto());
            filtraVenda = new FiltraVenda();
            

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
                vendas.NomeDoCliente = clienteRepository.BuscarPorId(vendas.IdCliente).Nome;
                Bs_Vendas.ResetCurrentItem();
            }
            else
            {
                MessageBox.Show("Codigo do cliente inexistente, Verifique!");
            }
        }

        private void FrmVendas_Shown(object sender, EventArgs e)
        {
           maskedTextBoxNrPedido.Text = vendasRepository.BuscartodosPorID().Last().Id.ToString();
            Bs_Vendas.AddNew();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3)
                {

                    Vendas vendas = Bs_Vendas.Current as Vendas;
                    vendas.ValorTotal = vendas.VendasItem.Sum(a => a.Quantidade * a.Valor);
                    Bs_Vendas.ResetCurrentItem();
                }
                if (e.ColumnIndex == 0)
                {
                    Vendas vendas = Bs_Vendas.Current as Vendas;
                    int rcCodigo = vendas.VendasItem[e.RowIndex].IdProduto;
                    vendas.VendasItem[e.RowIndex].NomeDoProduto = produtoRepository.BuscarPorId(rcCodigo).Descricao;


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

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.Cell.ColumnIndex == 1)
            {
                Vendas vendas = Bs_Vendas.Current as Vendas;
                int rcCodigo = vendas.VendasItem[e.Cell.RowIndex].IdProduto;
                vendas.VendasItem[e.Cell.RowIndex].Valor = produtoRepository.BuscarPrecoPorId(rcCodigo).Preco;
            }

        }
    }
}
