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
using VendasApp.Models.Enums;
using VendasApp.Repository;
using static VendasApp.Models.Enums.TipoDocumentoEnums;

namespace VendasApp.Relatorios.FiltroRelatorio
{
    public partial class FrmRelatorioClienteRelatorio : Form
    {
        private ClienteRepository clienteRepository;
        private TipoDocumentoEnums.Tipodocumento _tipodocumento;
        private FiltraClientesAtivos _filtraClientesAtivos;
        private FiltraClientesPorCidade _filtraClientesPorCidade;
        private FiltraClientePorBairro _filtraClientePorBairro;
        private FiltraClientesAtivosPorCidade _filtraClienteAtivoPorClidade;
        private FiltraClientesAtivosPorBairro _filtraClientesAtivosPorBairro;
        public FrmRelatorioClienteRelatorio()
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
        }
        public FrmRelatorioClienteRelatorio(TipoDocumentoEnums.Tipodocumento tipodocumento)
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            _tipodocumento = tipodocumento;
        }
        public FrmRelatorioClienteRelatorio(FiltraClientesAtivos filtraClientesAtivos)
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            _filtraClientesAtivos = filtraClientesAtivos;
        }
        public FrmRelatorioClienteRelatorio(FiltraClientesPorCidade filtraClientesPorCidade)
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            _filtraClientesPorCidade = filtraClientesPorCidade;
        }
        public FrmRelatorioClienteRelatorio(FiltraClientePorBairro filtraClientePorBairro)
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            _filtraClientePorBairro = filtraClientePorBairro;
        }
        public FrmRelatorioClienteRelatorio(FiltraClientesAtivosPorCidade filtraClientesAtivosPorCidade)
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            _filtraClienteAtivoPorClidade = filtraClientesAtivosPorCidade;

        }
        public FrmRelatorioClienteRelatorio(FiltraClientesAtivosPorBairro filtraClientesAtivosPorBairro)
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            _filtraClientesAtivosPorBairro = filtraClientesAtivosPorBairro;

        }

        private void FrmRelatorioClienteRelatorio_Load(object sender, EventArgs e)
        {


            if (_filtraClientesAtivos != null)
            {

                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportdatasource = new ReportDataSource("DataSetRelatorioTipoDocumento", clienteRepository.BuscarClienteAtivo(_filtraClientesAtivos));
                reportViewer1.LocalReport.DataSources.Add(reportdatasource);
                this.reportViewer1.RefreshReport();
            }


            else if (_filtraClienteAtivoPorClidade != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportdatasource = new ReportDataSource("DataSetRelatorioTipoDocumento", clienteRepository.BuscaClientesAtivosPorCidade(_filtraClienteAtivoPorClidade));
                reportViewer1.LocalReport.DataSources.Add(reportdatasource);
                this.reportViewer1.RefreshReport();
            }
            else if (_filtraClientesAtivosPorBairro != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportdatasource = new ReportDataSource("DataSetRelatorioTipoDocumento", clienteRepository.BuscaClientesAtivosPorBairro(_filtraClientesAtivosPorBairro));
                reportViewer1.LocalReport.DataSources.Add(reportdatasource);
                this.reportViewer1.RefreshReport();
            }
            else if (_filtraClientePorBairro != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportdatasource = new ReportDataSource("DataSetRelatorioTipoDocumento", clienteRepository.BuscarClienteBairro(_filtraClientePorBairro));
                reportViewer1.LocalReport.DataSources.Add(reportdatasource);
                this.reportViewer1.RefreshReport();
            }
            else if (_filtraClientesPorCidade != null)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportdatasource = new ReportDataSource("DataSetRelatorioTipoDocumento", clienteRepository.BuscarClienteCidade(_filtraClientesPorCidade));
                reportViewer1.LocalReport.DataSources.Add(reportdatasource);
                this.reportViewer1.RefreshReport();
            }

            else
            {
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportdatasource = new ReportDataSource("DataSetRelatorioTipoDocumento", clienteRepository.BuscarTodos());
                reportViewer1.LocalReport.DataSources.Add(reportdatasource);
                this.reportViewer1.RefreshReport();
            }


        }

    }
}
