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
        private ProdutoRepository produtoRepository;
        private FiltraProdutoPorData _filtraProdutoPorData;
        private FiltraProdutoPorDataValidade _filtraProdutoPorDataValidade;
        public FrmRelatorioProdutoRelatorio(FiltraProdutoAtivo filtraProdutoAtivo)
        {
            InitializeComponent();
            produtoRepository = new ProdutoRepository(new Data.Contexto());
            _filtraProdutoAtivo = filtraProdutoAtivo;

        }
        public FrmRelatorioProdutoRelatorio(FiltraProdutoPreco filtraProdutoPreco)
        {
            InitializeComponent();
            produtoRepository = new ProdutoRepository(new Data.Contexto());
            _filtraProdutoPreco = filtraProdutoPreco;

        }
        public FrmRelatorioProdutoRelatorio(FiltraProdutoPorDataValidade filtraProdutoPorDataValidade)
        {
            InitializeComponent();
            produtoRepository = new ProdutoRepository(new Data.Contexto());
            _filtraProdutoPorDataValidade = filtraProdutoPorDataValidade;

        }
        public FrmRelatorioProdutoRelatorio(FiltraProdutoPorData filtraProdutoPorData)
        {
            InitializeComponent();
            produtoRepository = new ProdutoRepository(new Data.Contexto());
            _filtraProdutoPorData = filtraProdutoPorData;

        }

        private void FrmRelatorioProdutoRelatorio_Load(object sender, EventArgs e)
        {
            if (_filtraProdutoAtivo != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSetProduto", produtoRepository.BuscaProdutosAtivos(_filtraProdutoAtivo));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            else if (_filtraProdutoPreco != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSetProduto", produtoRepository.BuscaProdutosPreco(_filtraProdutoPreco));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            else if (_filtraProdutoPorData != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSetProduto", produtoRepository.BuscaProdutosPorDataCadastro(_filtraProdutoPorData));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            else if (_filtraProdutoPorDataValidade != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource = new ReportDataSource("DataSetProduto", produtoRepository.BuscaProdutosPorDataValidade(_filtraProdutoPorDataValidade));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }


        }
    }
}
