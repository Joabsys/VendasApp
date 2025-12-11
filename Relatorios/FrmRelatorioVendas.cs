using Microsoft.EntityFrameworkCore.Internal;
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
        private FiltraVenda _filtraVenda;
        
       
        
        public FrmRelatorioVendas()
        {
            InitializeComponent();
            vendasItemRepository = new VendasItemRepository(new Data.Contexto());
            vendasRepository = new VendasRepository(new Data.Contexto());
        }
        public FrmRelatorioVendas(FiltraVenda filtraVenda)
        {
            InitializeComponent();
            _filtraVenda = filtraVenda;
            vendasItemRepository = new VendasItemRepository(new Data.Contexto());
            vendasRepository = new VendasRepository(new Data.Contexto());
            
        }

        private void FrmVendasItens_Load(object sender, EventArgs e)
        {
            if (_filtraVenda.CodigoPedido !=0)
            {
              
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource reportDataSource1;
                reportDataSource1 = new ReportDataSource("DataSetVendas", vendasRepository.ListaTodoPorId(_filtraVenda.CodigoPedido));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

                ReportDataSource reportDataSource;
                reportDataSource = new ReportDataSource("DataSetVendas2", vendasItemRepository.BuscaTodoPorId(_filtraVenda.CodigoPedido));
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.RefreshReport();

            }
        }
    }
}
