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
        public FrmRelatorioVendasFiltro()
        {
            InitializeComponent();
            filtraVenda = new FiltraVenda();
            vendasRepository = new VendasRepository(new Data.Contexto());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCodigoDoPedido.Text != "")
            {
                filtraVenda.CodigoPedido = Convert.ToInt32(textBoxCodigoDoPedido.Text);
            }
            else if (comboBoxConsultaPedidos.SelectedItem != null) {
                //captura o item selecionado pelo usuario no combobox
                filtraVenda.CodigoPedido = Convert.ToInt32(comboBoxConsultaPedidos.SelectedItem);
            }
               
            FrmRelatorioVendas form = new FrmRelatorioVendas(filtraVenda);
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRelatorioVendasFiltro_Shown(object sender, EventArgs e)
        {
            foreach (var i in vendasRepository.BuscartodosPorID())
            {

                comboBoxConsultaPedidos.Items.Add(i.Id);
            }
        }

        private void comboBoxConsultaPedidos_MouseHover(object sender, EventArgs e)
        {
            textBoxCodigoDoPedido.Text = "";
            textBoxCodigoDoPedido.Enabled = false;
            
        }

        private void textBoxCodigoDoPedido_MouseHover(object sender, EventArgs e)
        {
            comboBoxConsultaPedidos.Enabled = false;
            comboBoxConsultaPedidos.SelectedItem = null;
            
        }

        private void textBoxCodigoDoPedido_MouseLeave(object sender, EventArgs e)
        {
            comboBoxConsultaPedidos.Enabled = true;
        }

        private void comboBoxConsultaPedidos_MouseLeave(object sender, EventArgs e)
        {
            textBoxCodigoDoPedido.Text = "";
            textBoxCodigoDoPedido.Enabled = true;
        }

        private void textBoxCodigoDoPedido_Click(object sender, EventArgs e)
        {
            comboBoxConsultaPedidos.SelectedItem = null;
            comboBoxConsultaPedidos.Enabled = false;
        }

        private void comboBoxConsultaPedidos_Click(object sender, EventArgs e)
        {
            textBoxCodigoDoPedido.Text = "";
            textBoxCodigoDoPedido.Enabled = false;
        }

        private void comboBoxConsultaPedidos_MouseLeave_1(object sender, EventArgs e)
        {
            textBoxCodigoDoPedido.Enabled = true;
        }

        private void textBoxCodigoDoPedido_MouseLeave_1(object sender, EventArgs e)
        {
            comboBoxConsultaPedidos.Enabled = true;
        }
    }
}
