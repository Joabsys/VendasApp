using System.Collections.Generic;
using System.Linq;
using VendasApp.Data;
using VendasApp.Models;

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


    }
}