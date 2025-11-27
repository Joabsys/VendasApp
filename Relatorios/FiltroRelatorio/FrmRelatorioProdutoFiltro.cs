using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasApp.Models.Dto;

namespace VendasApp.Relatorios.FiltroRelatorio
{
    public partial class FrmRelatorioProdutoFiltro : Form
    {
        private FiltraProdutoAtivo filtraProdutoAtivo;
        private FiltraProdutoPreco filtraProdutoPreco;
        public FrmRelatorioProdutoFiltro()
        {
            InitializeComponent();
            filtraProdutoAtivo = new FiltraProdutoAtivo();
            filtraProdutoPreco = new FiltraProdutoPreco();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (maskedTextBoxQuantidade.Text != string.Empty && checkBoxAtivo.Checked != false && maskedTextBoxPreco.Text == string.Empty)
            {
                filtraProdutoAtivo.Quantidade = Convert.ToInt32(maskedTextBoxQuantidade.Text);
                filtraProdutoAtivo.Ativo = checkBoxAtivo.Checked;
                FrmRelatorioProdutoRelatorio form = new FrmRelatorioProdutoRelatorio(filtraProdutoAtivo);
                form.ShowDialog();
            }
            else if (maskedTextBoxPreco.Text != string.Empty && maskedTextBoxQuantidade.Text == string.Empty && checkBoxAtivo.Checked != false)
            {
                filtraProdutoPreco.Preco = Convert.ToDecimal(maskedTextBoxPreco.Text);
                filtraProdutoPreco.Ativo = checkBoxAtivo.Checked;
                FrmRelatorioProdutoRelatorio form = new FrmRelatorioProdutoRelatorio(filtraProdutoPreco);
                form.ShowDialog();
            }
            

        }
    }
}
