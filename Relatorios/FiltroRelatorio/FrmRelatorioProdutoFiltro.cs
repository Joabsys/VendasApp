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
        private FiltraProdutoPorData filtraProdutoPorData;
        private FiltraProdutoPorDataValidade FiltraProdutoPorDataValidade;
        public FrmRelatorioProdutoFiltro()
        {
            InitializeComponent();
            filtraProdutoAtivo = new FiltraProdutoAtivo();
            filtraProdutoPreco = new FiltraProdutoPreco();
            filtraProdutoPorData = new FiltraProdutoPorData();
            FiltraProdutoPorDataValidade = new FiltraProdutoPorDataValidade();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (maskedTextBoxQuantidade.Text != string.Empty && checkBoxAtivo.Checked != false && maskedTextBoxPreco.Text == string.Empty && maskedTextBoxDTCadastro.Text == "  /  /" && maskedTextBoxDTvalidade.Text == "  /  /")
            {
                filtraProdutoAtivo.Quantidade = Convert.ToInt32(maskedTextBoxQuantidade.Text);
                filtraProdutoAtivo.Ativo = checkBoxAtivo.Checked;
                FrmRelatorioProdutoRelatorio form = new FrmRelatorioProdutoRelatorio(filtraProdutoAtivo);
                form.ShowDialog();
            }
            else if (maskedTextBoxPreco.Text != string.Empty && checkBoxAtivo.Checked != false && maskedTextBoxQuantidade.Text == string.Empty && maskedTextBoxDTCadastro.Text == "  /  /" && maskedTextBoxDTvalidade.Text == "  /  /")
            {
                filtraProdutoPreco.Preco = Convert.ToDecimal(maskedTextBoxPreco.Text);
                filtraProdutoPreco.Ativo = checkBoxAtivo.Checked;
                FrmRelatorioProdutoRelatorio form = new FrmRelatorioProdutoRelatorio(filtraProdutoPreco);
                form.ShowDialog();
            }
            else if (maskedTextBoxDTCadastro.Text != string.Empty && checkBoxAtivo.Checked != false && maskedTextBoxQuantidade.Text == string.Empty && maskedTextBoxPreco.Text == "" && maskedTextBoxDTvalidade.Text == "  /  /")
            {
                DateTime data = DateTime.Now;
                if (DateTime.TryParse((maskedTextBoxDTCadastro.Text), out data))
                {

                    filtraProdutoPorData.DataDeCadastro = Convert.ToDateTime(maskedTextBoxDTCadastro.Text);
                    filtraProdutoPorData.Ativo = checkBoxAtivo.Checked;
                    FrmRelatorioProdutoRelatorio form = new FrmRelatorioProdutoRelatorio(filtraProdutoPorData);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("O campo data está inválido, verifique!");
                }
            }
            else if (maskedTextBoxDTCadastro.Text == "  /  /" && checkBoxAtivo.Checked != false && maskedTextBoxQuantidade.Text == string.Empty && maskedTextBoxPreco.Text == "" && maskedTextBoxDTvalidade.Text != string.Empty)
            {
                DateTime data = DateTime.Now;
                if (DateTime.TryParse((maskedTextBoxDTvalidade.Text), out data))
                {

                    FiltraProdutoPorDataValidade.DataDeValidade = Convert.ToDateTime(maskedTextBoxDTvalidade.Text);
                    FiltraProdutoPorDataValidade.Ativo = checkBoxAtivo.Checked;
                    FrmRelatorioProdutoRelatorio form = new FrmRelatorioProdutoRelatorio(FiltraProdutoPorDataValidade);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("O campo data está inválido,verifique!");
                }
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBoxQuantidade_Click(object sender, EventArgs e)
        {
            checkBoxAtivo.CheckState = CheckState.Checked;
            maskedTextBoxPreco.Enabled = false;
            maskedTextBoxDTvalidade.Enabled = false;
            maskedTextBoxDTCadastro.Enabled = false;
            maskedTextBoxPreco.Text = "";
            maskedTextBoxDTvalidade.Text = "";
            maskedTextBoxDTCadastro.Text = "";


        }

        private void maskedTextBoxPreco_Click(object sender, EventArgs e)
        {
            checkBoxAtivo.CheckState = CheckState.Checked;
            maskedTextBoxQuantidade.Enabled = false;
            maskedTextBoxDTvalidade.Enabled = false;
            maskedTextBoxDTCadastro.Enabled = false;
            maskedTextBoxQuantidade.Text = "";
            maskedTextBoxDTCadastro.Text = "";
            maskedTextBoxDTvalidade.Text = "";
          

        }

        private void maskedTextBoxDTCadastro_Click(object sender, EventArgs e)
        {
            checkBoxAtivo.CheckState = CheckState.Checked;
            maskedTextBoxDTvalidade.Enabled = false;
            maskedTextBoxPreco.Enabled = false;
            maskedTextBoxQuantidade.Enabled = false;
            maskedTextBoxDTvalidade.Text = "";
            maskedTextBoxPreco.Text = "";
            maskedTextBoxQuantidade.Text = "";
        }

        private void maskedTextBoxDTvalidade_Click(object sender, EventArgs e)
        {
            checkBoxAtivo.CheckState = CheckState.Checked;
            maskedTextBoxPreco.Enabled = false;
            maskedTextBoxQuantidade.Enabled = false;
            maskedTextBoxDTCadastro.Enabled = false;
            maskedTextBoxPreco.Text = "";
            maskedTextBoxQuantidade.Text = "";
            maskedTextBoxDTCadastro.Text = "";

        }

        private void maskedTextBoxDTvalidade_MouseLeave(object sender, EventArgs e)
        {
            maskedTextBoxPreco.Enabled = true;
            maskedTextBoxQuantidade.Enabled = true;
            maskedTextBoxDTCadastro.Enabled = true;
        }

        private void maskedTextBoxQuantidade_MouseLeave(object sender, EventArgs e)
        {
            maskedTextBoxPreco.Enabled = true;
            maskedTextBoxDTCadastro.Enabled = true;
            maskedTextBoxDTvalidade.Enabled = true;
        }

        private void maskedTextBoxPreco_MouseLeave(object sender, EventArgs e)
        {
            maskedTextBoxDTCadastro.Enabled = true;
            maskedTextBoxDTvalidade.Enabled = true;
            maskedTextBoxQuantidade.Enabled = true;
        }

        private void maskedTextBoxDTCadastro_MouseLeave(object sender, EventArgs e)
        {
            maskedTextBoxPreco.Enabled = true;
            maskedTextBoxDTvalidade.Enabled = true;
            maskedTextBoxQuantidade.Enabled = true;
        }
    }
}
