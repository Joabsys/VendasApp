using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendasApp.Data;
using VendasApp.Models;

namespace VendasApp.Repository
{
    public class VendasRepository
    {
        private readonly Contexto _contexto;

        /// <summary>
        /// Construtor que força passar o contexto na instancia da classe
        /// </summary>
        /// <param name="contexto"></param>
        public VendasRepository(Contexto contexto)
        {
            _contexto = contexto;
        }
        /// <summary>
        /// Inseri o registro na tabela
        /// </summary>
        /// <param name="Vendas"></param>
        public void Inserir(Vendas Vendas)
        {
            _contexto.Vendas.Add(Vendas);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Atualiza o registro na tabela
        /// </summary>
        /// <param name="Vendas"></param>
        public void Atualizar(Vendas Vendas)
        {
            _contexto.Vendas.Update(Vendas);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Excluir o registro na tabela
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            var Vendas = _contexto.Vendas.Find(id);
            if (Vendas != null)
            {
                _contexto.Vendas.Remove(Vendas);
                _contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Realiza a busca a partir de um id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Vendas BuscarPorId(int id)
        {
            return _contexto.Vendas.FirstOrDefault(a => a.Id == id);
        }
        public Vendas BuscaTodoPorId(int id)
        {
            return _contexto.Vendas.Include(a => a.VendasItem).ThenInclude(a => a.Produto).Include(a => a.Cliente).FirstOrDefault(a => a.Id == id);
        }

        /// <summary>
        /// Seleciona todos os registros da tabela
        /// </summary>
        /// <returns></returns>
        public List<Vendas> BuscarTodos()
        {
            return _contexto.Vendas.ToList();
        }
        

    }
}
