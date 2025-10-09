using SQLitePCL;
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

namespace VendasApp.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = maskedTextBoxUsuario.Text;
            string senha = maskedTextBoxSenha.Text;
            Contexto contexto = new Contexto();
            // bool valida = VerificaSeUsuarioExiste(usuario, senha);
            
            UsuarioRepository usuarioRepository = new UsuarioRepository(contexto);
            Usuario usuarioInserir = new Usuario();
            var val = usuarioInserir;
            usuarioInserir = usuarioRepository?.BuscarPorLogin(usuario);
            val = usuarioInserir;
            if ( val != null )
            {
                

                    FrmPrincipal form = new FrmPrincipal();


                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Usuário não existe!.Deseja criar um novo usuario?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Deseja criar o usuario 
                    ExemploCriacaoUsuario(usuario, senha);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("TCHAU!!");
                    
                }
                
            }
        }
            private void ExemploCriacaoUsuario(string usuario, string senha) {
            Data.Contexto contexto = new Data.Contexto();
            UsuarioRepository usuarioRepository = new UsuarioRepository(contexto);
            Usuario usuarioInserir = new Usuario();
            usuarioInserir.Ativo = true;
            usuarioInserir.Login = usuario;
            usuarioInserir.Senha = senha;
            usuarioInserir.DataUltimoLogin = DateTime.Now;
            usuarioRepository.Inserir(usuarioInserir);
        }

               
    }
}
