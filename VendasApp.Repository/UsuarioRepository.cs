using System.Collections.Generic;
using System.Linq;
using VendasApp.Data;
using VendasApp.Models;


namespace VendasApp.Repository
{
    public class UsuarioRepository
    {
        private readonly Contexto _contexto;

        /// <summary>
        /// Construtor que força passar o contexto na instancia da classe
        /// </summary>
        /// <param name="contexto"></param>
        public UsuarioRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        /// <summary>
        /// Inseri o registro na tabela
        /// </summary>
        /// <param name="usuario"></param>
        public void Inserir(Usuario usuario)
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Atualiza o registro na tabela
        /// </summary>
        /// <param name="usuario"></param>
        public void Atualizar(Usuario usuario)
        {
            _contexto.Usuarios.Update(usuario);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Excluir o registro na tabela
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            var usuario = _contexto.Usuarios.Find(id);
            if (usuario != null)
            {
                _contexto.Usuarios.Remove(usuario);
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

        /// <summary>
        /// Seleciona o registro da tabela pelo login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public Usuario Login(string login, string senha)
        {
            return _contexto.Usuarios.FirstOrDefault(u => u.Login == login && u.Senha == senha && u.Ativo == true);
        }
        
    }
}