using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasApp.Crud;
using VendasApp.Models;
using VendasApp.Processamento;
using VendasApp.Relatorios;
using VendasApp.Relatorios.FiltroRelatorio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VendasApp.Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRelatorioProduto Form = new FrmRelatorioProduto();
            Form.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente Form = new FrmCliente();
            Form.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto Form = new FrmProduto();
            Form.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatorioCliente Form = new FrmRelatorioCliente();
            Form.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatorioUsuario Form = new FrmRelatorioUsuario();
            Form.Show();
        }

        private void InventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario Form = new FrmInventario();
            Form.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            
            
        }

        public void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRelatorioClienteFiltro form = new FrmRelatorioClienteFiltro();
            form.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelatorioProdutoFiltro Form = new FrmRelatorioProdutoFiltro();
            Form.Show();
        }
    }
}
