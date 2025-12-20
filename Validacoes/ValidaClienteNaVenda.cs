using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasApp.Models;
using VendasApp.Repository;

namespace VendasApp.Validacoes
{
    public class ValidaClienteNaVenda
    {
        private ClienteRepository clienteRepository;
        private List<Cliente> validarCliente;
        public ValidaClienteNaVenda()
        {
            clienteRepository = new ClienteRepository(new Data.Contexto());
        }
        public bool ValidarCLienteNaVenda(int? cliente)
        {
            validarCliente = clienteRepository.BuscarId(cliente);
            if (validarCliente.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
