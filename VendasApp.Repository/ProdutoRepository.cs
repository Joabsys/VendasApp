using System.Collections.Generic;
using System.Linq;
using VendasApp.Data;
using VendasApp.Models;

namespace VendasApp.Repository
{
    public class ProdutoRepository
    {
        private readonly Contexto _contexto;

        /// <summary>
        /// Construtor que força passar o contexto na instancia da classe
        /// </summary>
        /// <param name="contexto"></param>
        public ProdutoRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Inseri o registro na tabela
        /// </summary>
        /// <param name="usuario"></param>
        public void Inserir(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Atualiza o registro na tabela
        /// </summary>
        /// <param name="usuario"></param>
        public void Atualizar(Produto produto)
        {
            _contexto.Produtos.Update(produto);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Excluir o registro na tabela
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            var produto = _contexto.Produtos.Find(id);
            if (produto != null)
            {
                _contexto.Produtos.Remove(produto);
                _contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Realiza a busca a partir de um id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Usuario BuscarPorId(int id)
        {
            return _contexto.Usuarios.Find(id);
        }

        /// <summary>
        /// Seleciona todos os registros da tabela
        /// </summary>
        /// <returns></returns>
        public List<Usuario> BuscarTodos()
        {
            return _contexto.Usuarios.ToList();
        }

        /// <summary>
        /// Seleciona o registro da tabela pelo login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Usuario BuscarPorLogin(string login)
        {
            return _contexto.Usuarios.FirstOrDefault(u => u.Login == login);
        }
    }
}