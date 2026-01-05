using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasApp.Crud;
using VendasApp.Data;
using VendasApp.Models;
using VendasApp.Models.Dto;
using VendasApp.Processamento;
using VendasApp.Relatorios;
using VendasApp.Relatorios.FiltroRelatorio;
using VendasApp.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VendasApp.Views
{
    public partial class FrmPrincipal : Form
    {
        private string _Nome;
        private ProdutoRepository produtoRepository;
        private ClienteRepository clienteRepository;
        private VendasRepository VendasRepository;
        public FrmPrincipal()
        {
            InitializeComponent();


        }
        public FrmPrincipal(FrmLogin frmLogin)
        {
            InitializeComponent();
            produtoRepository = new ProdutoRepository(new Data.Contexto());
            clienteRepository = new ClienteRepository(new Data.Contexto());
            VendasRepository = new VendasRepository(new Data.Contexto());
            _Nome = frmLogin.maskedTextBoxUsuario.Text;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRelatorioProduto Form = new FrmRelatorioProduto();
            Form.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario form = new FrmUsuario(_Nome);

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

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas frmVendas = new FrmVendas();
            frmVendas.Show();
        }


        private void vendasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRelatorioVendasFiltro FrmRelatorioVendasFiltro = new FrmRelatorioVendasFiltro();

            FrmRelatorioVendasFiltro.Show();
        }

        private void processamentosToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            i = produtoRepository.BuscarTodos().Count();
            j = clienteRepository.BuscarTodos().Count();

            if (i > 0 && j > 0)
            {
                InventarioToolStripMenuItem.Enabled = true;
                VendasToolStripMenuItem.Enabled = true;
            }
            else
            {
                InventarioToolStripMenuItem.Enabled = false;
                VendasToolStripMenuItem.Enabled = false;
            }
            
        }

        private void consultasToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            int k = 0;
            k = VendasRepository.BuscarTodos().Count();
            
                if (k > 0)
            {
                vendasToolStripMenuItem2.Enabled = true;
            }
            else
            {
                vendasToolStripMenuItem2.Enabled = false;
            }
        }
    }
}
