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
        private decimal total = 0;
        public FrmVendas()
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            Bindings();
            dataGridView1.DataSource = Bs_Vendas;
            dataGridView1.DataMember = nameof(Vendas.VendasItem);
        }

        private void Bindings()
        {
            // maskedTextBoxCodigo.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Id), true));
            maskedTextBoxIdCliente.DataBindings.Add(new Binding("Text", Bs_Vendas, nameof(Vendas.IdCliente), true));
            maskedTextBoxNomeCliente.DataBindings.Add(new Binding("Text", Bs_Vendas, nameof(Vendas.NomeDoCliente), true));
            maskedTextBoxValorTotal.DataBindings.Add(new Binding("Text", Bs_Vendas, nameof(Vendas.ValorTotal), true));

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendas vendas = Bs_Vendas.Current as Vendas;
            if (vendas.IdCliente != 0)
            {

                Cliente vendasCliente = clienteRepository.BuscarPorId(vendas.IdCliente);
                vendas.NomeDoCliente = vendasCliente.Nome;
                VendasItem vendasItem = new VendasItem();

                foreach (var i in vendas.VendasItem)
                {
                    vendas.ValorTotal += (i.Valor * i.Quantidade);
                }

                Bs_Vendas.ResetCurrentItem();

            }
        }

        private void FrmVendas_Shown(object sender, EventArgs e)
        {
            Bs_Vendas.AddNew();
        }
    }
}
