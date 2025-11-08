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
using VendasApp.Repository;

namespace VendasApp.Relatorios
{
    public partial class FrmRelatorioProduto : Form
    {
        private ProdutoRepository produtorepository;
        public FrmRelatorioProduto()
        {
            InitializeComponent();
            produtorepository = new ProdutoRepository(new Data.Contexto());
        }

        private void FrmRelatorioProduto_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportdatasource = new ReportDataSource("dsProduto", produtorepository.BuscarTodos());
            reportViewer1.LocalReport.DataSources.Add(reportdatasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
