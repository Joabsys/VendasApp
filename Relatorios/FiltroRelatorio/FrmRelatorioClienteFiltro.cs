using Microsoft.Reporting.WinForms;
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
using System.Xml.Linq;
using VendasApp.Data;
using VendasApp.Models;
using VendasApp.Models.Dto;
using VendasApp.Models.Enums;
using VendasApp.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace VendasApp.Relatorios.FiltroRelatorio
{
    public partial class FrmRelatorioClienteFiltro : Form

    {
        private FiltraClientesPorCidade filtraClientePorCidade;
        private FiltraClientePorBairro filtraClientePorBairro;
        private FiltraClientesAtivos filtraClientesAtivos;
        private FiltraClientesAtivosPorCidade filtraClientesAtivosPorCidade;
        private FiltraClientesAtivosPorBairro filtraClientesAtivosPorBairro;
        private FiltraClientesInativos clientesInativos;
        public FrmRelatorioClienteFiltro()
        {
            InitializeComponent();
            filtraClientesAtivos = new FiltraClientesAtivos();
            filtraClientePorBairro = new FiltraClientePorBairro();
            filtraClientePorCidade = new FiltraClientesPorCidade();
            filtraClientesAtivosPorBairro = new FiltraClientesAtivosPorBairro();
            filtraClientesAtivosPorCidade = new FiltraClientesAtivosPorCidade();
            clientesInativos = new FiltraClientesInativos();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && CheckBoxAtivo.Checked && textBoxCidade.Text == string.Empty && textBoxBairro.Text == string.Empty)
            {

                filtraClientesAtivos.Ativo = CheckBoxAtivo.Checked;
                filtraClientesAtivos.Tipodocumento = TipoDocumentoEnums.Tipodocumento.CPF;

                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientesAtivos);
                form.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 1 && CheckBoxAtivo.Checked && textBoxCidade.Text == string.Empty && textBoxBairro.Text == string.Empty)
            {

                filtraClientesAtivos.Ativo = CheckBoxAtivo.Checked;
                filtraClientesAtivos.Tipodocumento = TipoDocumentoEnums.Tipodocumento.CNPJ;

                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientesAtivos);
                form.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 0 && CheckBoxAtivo.Checked == true && textBoxCidade.Text != string.Empty)
            {
                filtraClientesAtivosPorCidade.Cidade = textBoxCidade.Text;
                filtraClientesAtivosPorCidade.Ativo = CheckBoxAtivo.Checked;
                filtraClientesAtivosPorCidade.Tipodocumento = TipoDocumentoEnums.Tipodocumento.CPF;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientesAtivosPorCidade);
                form.ShowDialog();

            }
            else if (comboBox1.SelectedIndex == 1 && CheckBoxAtivo.Checked == true && textBoxCidade.Text != string.Empty)
            {
                filtraClientesAtivosPorCidade.Cidade = textBoxCidade.Text;
                filtraClientesAtivosPorCidade.Ativo = CheckBoxAtivo.Checked;
                filtraClientesAtivosPorCidade.Tipodocumento = TipoDocumentoEnums.Tipodocumento.CNPJ;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientesAtivosPorCidade);
                form.ShowDialog();

            }
            else if (comboBox1.SelectedIndex == 0 && CheckBoxAtivo.Checked == true && textBoxBairro.Text != string.Empty)
            {
                filtraClientesAtivosPorBairro.Bairro = textBoxBairro.Text;
                filtraClientesAtivosPorBairro.Ativo = CheckBoxAtivo.Checked;
                filtraClientesAtivosPorBairro.Tipodocumento = TipoDocumentoEnums.Tipodocumento.CPF;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientesAtivosPorBairro);
                form.ShowDialog();

            }
            else if (comboBox1.SelectedIndex == 1 && CheckBoxAtivo.Checked == true && textBoxBairro.Text != string.Empty)
            {
                filtraClientesAtivosPorBairro.Bairro = textBoxBairro.Text;
                filtraClientesAtivosPorBairro.Ativo = CheckBoxAtivo.Checked;
                filtraClientesAtivosPorBairro.Tipodocumento = TipoDocumentoEnums.Tipodocumento.CNPJ;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientesAtivosPorBairro);
                form.ShowDialog();

            }
            else if (comboBox1.SelectedIndex == -1 && CheckBoxAtivo.Checked != true && textBoxCidade.Text == string.Empty && textBoxBairro.Text == string.Empty && checkBoxInativos.Checked == false)
            {
                DialogResult dialogResult = MessageBox.Show("Nenhum campo foi preenchido, portanto a consulta retornará todos os dados. Confirma?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio();
                    form.ShowDialog();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Preencha os campos para nova consulta!");
                }
            }
            else if (textBoxCidade.Text != "")
            {
                filtraClientePorCidade.Cidade = textBoxCidade.Text;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientePorCidade);
                form.ShowDialog();

            }
            else if (textBoxBairro.Text != "")
            {
                filtraClientePorBairro.Bairro = textBoxBairro.Text;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientePorBairro);
                form.ShowDialog();
            }
            else if (checkBoxInativos.Checked == true)
            {
                clientesInativos.Ativo = false;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(clientesInativos);
                form.ShowDialog();

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckBoxAtivo.Checked = true;
            CheckBoxAtivo.Enabled = false;
        }

        private void checkBoxInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInativos.Checked == true)
            {

                comboBox1.Enabled = false;
                CheckBoxAtivo.Enabled = false;
                textBoxCidade.Enabled = false;
                textBoxBairro.Enabled = false;

            }
            else
            {
                comboBox1.Enabled = true;
                CheckBoxAtivo.Enabled = true;
                textBoxCidade.Enabled = true;
                textBoxBairro.Enabled = true;

            }
        }
    }
}
