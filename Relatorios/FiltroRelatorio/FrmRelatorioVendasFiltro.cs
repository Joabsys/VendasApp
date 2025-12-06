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

namespace VendasApp.Relatorios.FiltroRelatorio
{
    public partial class FrmRelatorioVendasFiltro : Form
    {
        private FiltraClientePorCodigo filtraClientePorCodigo;
        public FrmRelatorioVendasFiltro()
        {
            InitializeComponent();
            filtraClientePorCodigo = new FiltraClientePorCodigo();
        }
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            filtraClientePorCodigo.Codigo = Convert.ToInt32(textBoxCodigoCliente.Text);
            FrmRelatorioVendas form = new FrmRelatorioVendas(filtraClientePorCodigo);
            form.ShowDialog();
        }
    }
}
