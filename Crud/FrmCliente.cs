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
using VendasApp.Models.Enums;
using VendasApp.Repository;
using VendasApp.Validacoes;
using static VendasApp.Models.Enums.TipoDocumentoEnums;

namespace VendasApp.Crud
{
    public partial class FrmCliente : Form
    {

        private ClienteRepository clienteRepository;
        

        public FrmCliente()
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Contexto());
            


        }

        private void Bindings()
        {
            //Associa o componente ao meu bindingSource e a minha propriedade da minha classe Cliente 
            maskedTextBoxCodigo.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Id), true));
            checkBoxAtivo.DataBindings.Add(new Binding("Checked", Bs_Cliente, nameof(Cliente.Ativo), true));
            textBoxNome.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Nome), true));
            comboBoxTipoDocumento.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Tipodocumento), true));
            maskedTextBoxDocumento.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Documento), true));
            textBoxEndereco.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Endereco), true));
            maskedTextBoxCep.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Cep), true));
            textBoxCidade.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Cidade), true));
            textBoxBairro.DataBindings.Add(new Binding("Text", Bs_Cliente, nameof(Cliente.Bairro), true));
        }

        private void FrmCliente_Shown(object sender, EventArgs e)
        {
            CarregaDados();
           


        }
        private void CarregaDados()
        {
            Bs_Cliente.DataSource = clienteRepository.BuscarTodos();
        }


        private void FrmCliente_Load(object sender, EventArgs e)
        {

            Bindings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente deletar o cliente?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Pega o registro corrente (foco da seleção em tela) do cliente a ser excluido
                Cliente cliente = Bs_Cliente.Current as Cliente;
                //Exclui o cliente pelo Id do cliente no banco de dados
                clienteRepository.Excluir(cliente.Id.GetValueOrDefault());
                //Remove o cliente da lista de clientes que estão no BindingSource
                Bs_Cliente.Remove(cliente);
                MessageBox.Show("Cliente deletado com sucesso!", "Sucesso!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Bs_Cliente.AddNew();
            checkBoxAtivo.CheckState = CheckState.Unchecked;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = Bs_Cliente.Current as Cliente;
            if (cliente.Cep == "" || cliente.Nome == "" || cliente.Bairro == "" ||
                cliente.Tipodocumento == null || cliente.Documento == ""
                || cliente.Cidade == "" || cliente.Endereco == "" || cliente.Ativo == false)
            {
                MessageBox.Show("Existem campos não preenchidos, Verifique!");
            }
            else
            {
                if (Validacao(cliente))
                {


                    if (cliente.Id == null)
                    {
                        clienteRepository.Inserir(cliente);
                     
                    }
                    else
                    {
                        clienteRepository.Atualizar(cliente);
                    }
                    MessageBox.Show("Cliente salvo com sucesso!");

                    button3.Enabled = true;
                }
            }

        }
        private bool Validacao(Cliente cliente)
        {
            ValidacaoCliente validacaoCliente = new ValidacaoCliente();
            if (!validacaoCliente.Documento(cliente))
            {
                MessageBox.Show("Documento selecionado Invalido!");
                return false;
            }
            return true;

        }
        private void comboBoxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoDocumento.SelectedIndex == 0)
            {
                maskedTextBoxDocumento.Text = "";
                maskedTextBoxDocumento.Mask = "999,999,999-99";
            }
            else
            {
                maskedTextBoxDocumento.Text = "";
                maskedTextBoxDocumento.Mask = "99,999,999/9999-99";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}