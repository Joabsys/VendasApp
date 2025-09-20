using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (usuario == "master" && senha == "123456")
            {
                FrmPrincipal form = new FrmPrincipal();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("usuario invalido");
            }
        }
    }
}
