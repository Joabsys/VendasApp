using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasApp.Data;
using VendasApp.Models;
using VendasApp.Repository;

namespace VendasApp.Crud
{
    public partial class FrmUsuario : Form
    {
        private UsuarioRepository usuarioRepository;

        public FrmUsuario()
        {
            InitializeComponent();
            usuarioRepository = new UsuarioRepository(new Contexto());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Salva/Atualiza o registro
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente deletar o usuario?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Pega o registro corrente
                Usuario usuario = Bs_Usuario.Current as Usuario; 
                //Exclui o usuario pelo Id do usuario no banco de dados
                usuarioRepository.Excluir(usuario.Id.GetValueOrDefault());
                //Remove o usuario da lista de usuarios que estão no BindingSource
                Bs_Usuario.Remove(usuario);
                MessageBox.Show("Usuario deletado com sucesso!", "Sucesso!");
            
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void FrmUsuario_Shown(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados() {
            Bs_Usuario.DataSource = usuarioRepository.BuscarTodos();
        }

        private void Bindings() {

            //Associa o componente ao meu bindingSource e a minha propriedade da minha classe Usuario 
            maskedTextBoxCodigo.DataBindings.Add(new Binding("Text", Bs_Usuario, nameof(Usuario.Id), true));
            maskedTextBoxLogin.DataBindings.Add(new Binding("Text", Bs_Usuario, nameof(Usuario.Login), true));
            maskedTextBoxSenha.DataBindings.Add(new Binding("Text", Bs_Usuario, nameof(Usuario.Senha), true));
            checkBoxAtivo.DataBindings.Add(new Binding("Checked", Bs_Usuario, nameof(Usuario.Ativo), true));
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Bindings();
        }
    }
}
