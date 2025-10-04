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

            //Validar se o usuario existe no banco de dados
            if (usuario == "xxx")
            {
                
                FrmPrincipal form = new FrmPrincipal();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja criar o usuario?", "Usuario invalido", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Deseja criar o usuario 
                    ExemploCriacaoUsuario(usuario, senha);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("usuario invalido");
                    
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
