using Microsoft.Reporting.WinForms;
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
using VendasApp.Repository;

namespace VendasApp.Relatorios.FiltroRelatorio
{

    public partial class FrmRelatorioProdutoRelatorio : Form
    {
        private FiltraProdutoAtivo _filtraProdutoAtivo;
        private FiltraProdutoPreco _filtraProdutoPreco;
        private ClienteRepository clienteRepository;
        public FrmRelatorioProdutoRelatorio(FiltraProdutoAtivo filtraProdutoAtivo)
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            _filtraProdutoAtivo = filtraProdutoAtivo;

        }
        public FrmRelatorioProdutoRelatorio(FiltraProdutoPreco filtraProdutoPreco)
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            _filtraProdutoPreco = filtraProdutoPreco;

        }

        private void FrmRelatorioProdutoRelatorio_Load(object sender, EventArgs e)
        {
            if (_filtraProdutoAtivo != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSetProduto", clienteRepository.BuscaProdutosAtivos(_filtraProdutoAtivo));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            else if (_filtraProdutoPreco != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSetProduto", clienteRepository.BuscaProdutosPreco(_filtraProdutoPreco));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }


        }
    }
}
