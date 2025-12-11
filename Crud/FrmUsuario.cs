using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasApp.Data;
using VendasApp.Models;
using VendasApp.Models.Dto;
using VendasApp.Repository;
using VendasApp.Views;

namespace VendasApp.Crud
{
    public partial class FrmUsuario : Form
    {
        private UsuarioRepository usuarioRepository;
        private string _nome;

        public FrmUsuario(string nome)
        {
            InitializeComponent();
            _nome = nome;
            usuarioRepository = new UsuarioRepository(new Contexto());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = Bs_Usuario.Current as Usuario;
            if (textBoxLogin.Text == "" || textBoxSenha.Text == "" || checkBoxAtivo.Checked != true)
            {
                MessageBox.Show("Existem campos não preenchidos, verifique!");
            }
            else
            {//Salva/Atualiza o registro
                if (usuario.Id == null)
                {

                    usuarioRepository.Inserir(usuario);
                }
                else
                {

                    usuarioRepository.Atualizar(usuario);
                }
                MessageBox.Show("Usuario cadastrado/atualizado com sucesso");
                Bs_Usuario.ResetCurrentItem();
                checkBoxAtivo.Checked = true;
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = Bs_Usuario.Current as Usuario;
           
            if (usuario.Login == _nome)
            {
                MessageBox.Show("Não é possivel deletar o usuario logado!", "Atenção");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realmente deletar o usuario?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Pega o registro corrente
                    usuario = Bs_Usuario.Current as Usuario;
                    //Exclui o usuario pelo Id do usuario no banco de dados
                    usuarioRepository.Excluir(usuario.Id.GetValueOrDefault());
                    //Remove o usuario da lista de usuarios que estão no BindingSource
                    Bs_Usuario.Remove(usuario);
                    MessageBox.Show("Usuario deletado com sucesso!", "Sucesso!");

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuario_Shown(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados()
        {
            Bs_Usuario.DataSource = usuarioRepository.BuscarTodos();

        }

        private void Bindings()
        {

            //Associa o componente ao meu bindingSource e a minha propriedade da minha classe Usuario 
            maskedTextBoxCodigo.DataBindings.Add(new Binding("Text", Bs_Usuario, nameof(Usuario.Id), true));
            textBoxLogin.DataBindings.Add(new Binding("Text", Bs_Usuario, nameof(Usuario.Login), true));
            textBoxSenha.DataBindings.Add(new Binding("Text", Bs_Usuario, nameof(Usuario.Senha), true));
            checkBoxAtivo.DataBindings.Add(new Binding("Checked", Bs_Usuario, nameof(Usuario.Ativo), true));
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Bindings();
        }

        private void Bs_Usuario_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bs_Usuario.AddNew();
            checkBoxAtivo.Checked = false;
            button2.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
