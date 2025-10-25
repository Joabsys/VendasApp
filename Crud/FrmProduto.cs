using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasApp.Data;
using VendasApp.Models;
using VendasApp.Repository;

namespace VendasApp.Crud
{
    public partial class FrmProduto : Form
    {
        private ProdutoRepository produtoRepository;
        public FrmProduto()
        {
            InitializeComponent();
            produtoRepository = new ProdutoRepository(new Contexto());
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Bindings();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BS_Produto_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Shown(object sender, EventArgs e)
        {
            CarregaDados();
        }
        private void CarregaDados()
        {
            BS_Produto.DataSource = produtoRepository.BuscarTodos();
        }

        private void Bindings()
        {

            //Associa o componente ao meu bindingSource e a minha propriedade da minha classe Usuario 
            maskedTextBoxCodigo.DataBindings.Add(new Binding("Text", BS_Produto, nameof(Produto.Id), true));
            maskedTextBoxPreco.DataBindings.Add(new Binding("Text", BS_Produto, nameof(Produto.Preco), true));
            maskedTextBoxQuantidade.DataBindings.Add(new Binding("Text", BS_Produto, nameof(Produto.Quantidade), true));
            maskedTextBoxDescricao.DataBindings.Add(new Binding("Text", BS_Produto, nameof(Produto.Descricao), true));
            checkBoxAtivo.DataBindings.Add(new Binding("Checked", BS_Produto, nameof(Usuario.Ativo), true));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente deletar o produto?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Pega o registro corrente do produto
                Produto produto = BS_Produto.Current as Produto;
                //Exclui o produto pelo Id do produto no banco de dados
                produtoRepository.Excluir(produto.Id.GetValueOrDefault());
                //Remove o produto da lista de Produtos que estão no BindingSource
                BS_Produto.Remove(produto);
                MessageBox.Show("Produto deletado com sucesso!", "Sucesso!");

            }
        }
    }
}
