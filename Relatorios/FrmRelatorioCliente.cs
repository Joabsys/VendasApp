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
    public partial class FrmRelatorioCliente : Form
    {
        private ClienteRepository clienteRepository;
        public FrmRelatorioCliente()
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());

        }

        private void FrmRelatorioCliente_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("dsCliente", clienteRepository.BuscarTodos());
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }
    }
}
