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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = maskedTextBoxUsuario.Text;
            string senha = maskedTextBoxSenha.Text;

            if (usuario == "master" && senha == "123456")
            {
             
            }
            else
            {
                MessageBox.Show("usuario invalido");
            }
        }
    }
}
