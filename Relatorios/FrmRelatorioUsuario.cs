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
    public partial class FrmRelatorioUsuario : Form
    {
        private UsuarioRepository usuariorepository;   
        public FrmRelatorioUsuario()
        {
            InitializeComponent();
            usuariorepository = new UsuarioRepository(new Data.Contexto());
        }

        private void FrmRelatorioUsuario_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportdatasource = new ReportDataSource("dsUsuario", usuariorepository.BuscarTodos());
            reportViewer1.LocalReport.DataSources.Add(reportdatasource);
            reportViewer1.RefreshReport();
        }

        
    }
}
