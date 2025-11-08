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
            string login = maskedTextBoxUsuario.Text;
            string senha = maskedTextBoxSenha.Text;
            Contexto contexto = new Contexto();
            UsuarioRepository usuarioRepository = new UsuarioRepository(contexto);
            Usuario usuario = usuarioRepository.Login(login, senha);
            if (usuario != null)
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
                    ExemploCriacaoUsuario(login, senha);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Usuario ou Senha incorreto(s), Verifique!");

                }

            }
        }
        private void ExemploCriacaoUsuario(string usuario, string senha)
        {
            Data.Contexto contexto = new Data.Contexto();
            UsuarioRepository usuarioRepository = new UsuarioRepository(contexto);
            Usuario usuarioInserir = new Usuario();
            usuarioInserir.Ativo = true;
            usuarioInserir.Login = usuario;
            usuarioInserir.Senha = senha;
            usuarioInserir.DataUltimoLogin = DateTime.Now;
            usuarioRepository.Inserir(usuarioInserir);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBoxUsuario_Click(object sender, EventArgs e)
        {
            maskedTextBoxUsuario.Text = "";
        }

        private void pictureBoxFechar_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void maskedTextBoxSenha_Enter(object sender, EventArgs e)
        {
            maskedTextBoxSenha.Text = "";
        }
    }
}
