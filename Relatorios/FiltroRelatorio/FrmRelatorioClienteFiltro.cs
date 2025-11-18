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
        public FrmRelatorioClienteFiltro()
        {
            InitializeComponent();
            filtraClientesAtivos = new FiltraClientesAtivos();
            filtraClientePorBairro = new FiltraClientePorBairro();
            filtraClientePorCidade = new FiltraClientesPorCidade();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && CheckBoxAtivo.Checked == true)
            {

                filtraClientesAtivos.Ativo = CheckBoxAtivo.Checked;
                filtraClientesAtivos.Tipodocumento = TipoDocumentoEnums.Tipodocumento.CPF;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientesAtivos);
                form.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == 1 && CheckBoxAtivo.Checked == true)
            {

                filtraClientesAtivos.Ativo = CheckBoxAtivo.Checked;
                filtraClientesAtivos.Tipodocumento = TipoDocumentoEnums.Tipodocumento.CNPJ;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientesAtivos);
                form.ShowDialog();
            }
            else if (comboBox1.SelectedIndex == -1 && CheckBoxAtivo.Checked != true && textBoxCidade.Text == "" && textBoxBairro.Text == "")
            {
                filtraClientesAtivos.Cidade = textBoxCidade.Text;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio();
                form.ShowDialog();

            }
            else if (textBoxCidade.Text != "")
            {
                filtraClientePorCidade.Cidade = textBoxCidade.Text;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientePorCidade);
                form.ShowDialog();

            }
            else if (textBoxBairro.Text != "") {
               filtraClientePorBairro.Bairro = textBoxBairro.Text;
                FrmRelatorioClienteRelatorio form = new FrmRelatorioClienteRelatorio(filtraClientePorBairro);
                form.ShowDialog();
            }










        }
    }
}
