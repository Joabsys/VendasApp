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
using VendasApp.Repository;

namespace VendasApp.Crud
{
    public partial class FrmCliente : Form
    {
        private ClienteRepository clienteRepository;

        public FrmCliente()
        {
            InitializeComponent();
            clienteRepository = new ClienteRepository(new Data.Contexto());
        }
    }
}
