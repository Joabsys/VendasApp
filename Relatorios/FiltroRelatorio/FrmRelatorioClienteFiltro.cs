using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendasApp.Relatorios.FiltroRelatorio
{
    public partial class FrmRelatorioClienteFiltro : Form
    {
        public FrmRelatorioClienteFiltro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRelatorioCliente frmRelatorioCliente = new FrmRelatorioCliente(Models.Enums.TipoDocumentoEnums.Tipodocumento.CPF);
            frmRelatorioCliente.ShowDialog();
        }
    }
}
