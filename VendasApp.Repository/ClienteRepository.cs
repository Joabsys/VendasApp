using System.Collections.Generic;
using System.Linq;
using VendasApp.Data;
using VendasApp.Models;
using VendasApp.Models.Dto;
using static VendasApp.Models.Enums.TipoDocumentoEnums;

namespace VendasApp.Repository
{
    public class ClienteRepository
    {
        private readonly Contexto _contexto;

        /// <summary>
        /// Construtor que força passar o contexto na instancia da classe
        /// </summary>
        /// <param name="contexto"></param>
        public ClienteRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Inseri o registro na tabela
        /// </summary>
        /// <param name="usuario"></param>
        public void Inserir(Cliente cliente)
        {
            _contexto.Clientes.Add(cliente);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Atualiza o registro na tabela
        /// </summary>
        /// <param name="usuario"></param>
        public void Atualizar(Cliente cliente)
        {
            _contexto.Clientes.Update(cliente);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Excluir o registro na tabela
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            var cliente = _contexto.Clientes.Find(id);
            if (cliente != null)
            {
                _contexto.Clientes.Remove(cliente);
                _contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Realiza a busca a partir de um id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Cliente BuscarPorId(int id)
        {
            return _contexto.Clientes.Find(id);
        }

        /// <summary>
        /// Seleciona todos os registros da tabela
        /// </summary>
        /// <returns></returns>
        public List<Cliente> BuscarTodos()
        {
            return _contexto.Clientes.ToList();
        }

        public List<Cliente> BuscarPorDocumento(Models.Enums.TipoDocumentoEnums.Tipodocumento tipodocumento)
        {
            return _contexto.Clientes.Where(b => b.Tipodocumento == tipodocumento).ToList();
        }
        public List<Cliente> BuscarClienteAtivo(FiltraClientesAtivos filtraClientesAtivos)
        {
            return _contexto.Clientes.Where(b => b.Tipodocumento == filtraClientesAtivos.Tipodocumento && b.Ativo == filtraClientesAtivos.Ativo).ToList();
        }
        public List<Cliente> BuscarClienteCidade(FiltraClientesPorCidade filtraClientesPorCidade)
        {
            return _contexto.Clientes.Where(b => b.Cidade == filtraClientesPorCidade.Cidade).ToList();
        }
        public List<Cliente> BuscarClienteBairro(FiltraClientePorBairro filtraClientePorBairro)
        {
            return _contexto.Clientes.Where(b => b.Bairro == filtraClientePorBairro.Bairro).ToList();
        }
        public List<Cliente> BuscaClientesAtivosPorCidade(FiltraClientesAtivosPorCidade filtraClientesAtivosPorCidade)
        {
            return _contexto.Clientes.Where(b => b.Ativo == filtraClientesAtivosPorCidade.Ativo && b.Tipodocumento == filtraClientesAtivosPorCidade.Tipodocumento && b.Cidade == filtraClientesAtivosPorCidade.Cidade).ToList();
        }
        public List<Cliente> BuscaClientesAtivosPorBairro(FiltraClientesAtivosPorBairro filtraClientesAtivosPorBairro)
        {
            return _contexto.Clientes.Where(b => b.Ativo == filtraClientesAtivosPorBairro.Ativo && b.Tipodocumento == filtraClientesAtivosPorBairro.Tipodocumento && b.Bairro == filtraClientesAtivosPorBairro.Bairro).ToList();
        }
        public List<Cliente> BuscaClientesInativos(FiltraClientesInativos clientesInativos)
        {

            return _contexto.Clientes.Where(b => b.Ativo == clientesInativos.Ativo).ToList();
        }
        public List<Produto> BuscaProdutosAtivos(FiltraProdutoAtivo filtraProdutoAtivo)     
        {
            return _contexto.Produtos.Where(b => b.Ativo == filtraProdutoAtivo.Ativo && b.Quantidade >= filtraProdutoAtivo.Quantidade).ToList();

        }

    }
}