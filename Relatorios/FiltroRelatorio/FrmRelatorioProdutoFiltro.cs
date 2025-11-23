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
        public FrmRelatorioProdutoFiltro()
        {
            InitializeComponent();
            filtraProdutoAtivo = new FiltraProdutoAtivo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(maskedTextBoxQuantidade.Text) >= 0 && checkBoxAtivo.Checked != false) {
                filtraProdutoAtivo.Quantidade = Convert.ToInt32(maskedTextBoxQuantidade.Text);
                filtraProdutoAtivo.Ativo = checkBoxAtivo.Checked;
                FrmRelatorioProdutoRelatorio form = new FrmRelatorioProdutoRelatorio(filtraProdutoAtivo);
                form.ShowDialog();
            }
        }
    }
}
