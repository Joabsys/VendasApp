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

            //Associa o componente ao meu bindingSource e a minha propriedade da minha classe Produto 
            maskedTextBoxCodigo.DataBindings.Add(new Binding("Text", BS_Produto, nameof(Produto.Id), true));
            maskedTextBoxPreco.DataBindings.Add(new Binding("Text", BS_Produto, nameof(Produto.Preco), true));
            maskedTextBoxQuantidade.DataBindings.Add(new Binding("Text", BS_Produto, nameof(Produto.Quantidade), true));
            maskedTextBoxDescricao.DataBindings.Add(new Binding("Text", BS_Produto, nameof(Produto.Descricao), true));
            checkBoxAtivo.DataBindings.Add(new Binding("Checked", BS_Produto, nameof(Produto.Ativo), true));
            dateTimePickerDTValidade.DataBindings.Add(new Binding("Value", BS_Produto, nameof(Produto.DataValidade), true));
            dateTimePickerDTInclusao.DataBindings.Add(new Binding("Value", BS_Produto, nameof(Produto.DataInclusao), true));

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

        private void maskedTextBoxDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Produto produto = BS_Produto.Current as Produto;
            BS_Produto.AddNew();
            dateTimePickerDTInclusao.Value = DateTime.Now;
            produto.DataInclusao = dateTimePickerDTInclusao.Value;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Produto produto = BS_Produto.Current as Produto;
            if (produto.Id == null)
            {
                produto.DataInclusao = dateTimePickerDTInclusao.Value;
               
                produtoRepository.Inserir(produto);

               
            }
            else
            {
                produtoRepository.Atualizar(produto);
            }
            MessageBox.Show("Produto salvo com sucesso!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
