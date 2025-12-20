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
using VendasApp.Models.Dto;
using VendasApp.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VendasApp.Relatorios.FiltroRelatorio
{
    public partial class FrmRelatorioVendasFiltro : Form
    {
        private VendasRepository vendasRepository;
        private FiltraVenda filtraVenda;
        private Vendas vendas;
        public FrmRelatorioVendasFiltro()
        {
            InitializeComponent();
            filtraVenda = new FiltraVenda();
            vendasRepository = new VendasRepository(new Data.Contexto());
            vendas = new Vendas();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCodigoDoPedido.Text != "")
            {
                filtraVenda.CodigoPedido = Convert.ToInt32(textBoxCodigoDoPedido.Text);
            }
             
            FrmRelatorioVendas form = new FrmRelatorioVendas(filtraVenda);
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
