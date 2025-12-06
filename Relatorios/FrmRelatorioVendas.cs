using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
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

namespace VendasApp.Relatorios
{
    public partial class FrmRelatorioVendas : Form
    {
        private VendasItemRepository vendasItemRepository;
        private VendasRepository vendasRepository;
        private FiltraClientePorCodigo _filtraClientePorCodigo;
        
        public FrmRelatorioVendas()
        {
            InitializeComponent();
            vendasItemRepository = new VendasItemRepository(new Data.Contexto());
            vendasRepository = new VendasRepository(new Data.Contexto());
        }
        public FrmRelatorioVendas(FiltraClientePorCodigo filtraClientePorCodigo)
        {
            InitializeComponent();
            _filtraClientePorCodigo = filtraClientePorCodigo;
            vendasItemRepository = new VendasItemRepository(new Data.Contexto());
            vendasRepository = new VendasRepository(new Data.Contexto());
        }

        private void FrmVendasItens_Load(object sender, EventArgs e)
        {
            if (_filtraClientePorCodigo != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource;
                reportDataSource = new ReportDataSource("dsVenda", vendasItemRepository.BuscaTodoPorId(_filtraClientePorCodigo));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
                ReportDataSource reportDataSource1;
                reportDataSource1 = new ReportDataSource("DataSetVenda", vendasRepository.BuscarPorId(_filtraClientePorCodigo.Codigo));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
