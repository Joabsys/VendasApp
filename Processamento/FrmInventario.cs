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
using VendasApp.Models.Dto;
using VendasApp.Repository;

namespace VendasApp.Processamento
{
    public partial class FrmInventario : Form
    {
        private ProdutoRepository produtoRepository;
        public FrmInventario()
        {
            InitializeComponent();
            produtoRepository = new ProdutoRepository(new Data.Contexto());
        }

        private void FrmInventario_Shown(object sender, EventArgs e)
        {
            CarregaDados();
        }
        private void CarregaDados()
        {
            produtoBindingSource.DataSource = produtoRepository.BuscarTodos();
        }
        private void Bindings()
        {

            //Associa o componente ao meu bindingSource e a minha propriedade da minha classe Produto 
            maskedTextBoxQuantidade.DataBindings.Add(new Binding("Text", bs_Inventario, nameof(Inventario.Quantidade), true));
            comboBoxOperacao.DataBindings.Add(new Binding("Text", bs_Inventario, nameof(Inventario.Operacao), true));
            bs_Inventario.AddNew();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            Bindings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventario inventario = bs_Inventario.Current as Inventario;
            if (inventario != null) { 
                Produto produto = produtoBindingSource.Current as Produto;
                DialogResult dialogResult = MessageBox.Show($"Deseja realmente atualizar o estoque do produto {produto.Id} - {produto.Descricao} ?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Aqui eu faço a operação
                    if (inventario.Operacao == Models.Enums.OperacaoEnum.Operacao.Soma)
                    {
                        var teste = 0;
                    }
                    else {
                        var teste = 0;
                    }
                }
            }
            return;
        }
        

    }
}
