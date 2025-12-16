using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasApp.Models.Enums;
using VendasApp.Repository;

namespace VendasApp.Relatorios
{
    public partial class FrmRelatorioCliente : Form
    {
        private ClienteRepository clienteRepository;
        private TipoDocumentoEnums.Tipodocumento? tipodocumentoParametro;
        private LocalReport report;
        public FrmRelatorioCliente()
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
            report = new LocalReport();
        }
        public FrmRelatorioCliente(TipoDocumentoEnums.Tipodocumento? tipodocumento)
        {
            tipodocumentoParametro = tipodocumento;
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
        }
        private void FrmRelatorioCliente_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource;
            if (tipodocumentoParametro == null)
            {
                reportDataSource = new ReportDataSource("dsCliente", clienteRepository.BuscarTodos());
            }
            else
            {
                reportDataSource = new ReportDataSource("dsCliente", clienteRepository.BuscarPorDocumento(tipodocumentoParametro.Value));
            }
           
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
