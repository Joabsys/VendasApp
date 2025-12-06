using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendasApp.Data;
using VendasApp.Models;
using VendasApp.Models.Dto;

namespace VendasApp.Repository
{
    public class VendasItemRepository
    {
        private readonly Contexto _contexto;

        /// <summary>
        /// Construtor que força passar o contexto na instancia da classe
        /// </summary>
        /// <param name="contexto"></param>
        public VendasItemRepository(Contexto contexto)
        {
            _contexto = contexto;
        }
        

        

        /// <summary>
        /// Excluir o registro na tabela
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            var VendasItem = _contexto.VendasItem.Find(id);
            if (VendasItem != null)
            {
                _contexto.VendasItem.Remove(VendasItem);
                _contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Realiza a busca a partir de um id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VendasItem BuscarPorId(int id)
        {
            return _contexto.VendasItem.FirstOrDefault(a => a.Id == id);
        }
        public List<VendasItem> BuscaTodoPorId(FiltraClientePorCodigo filtraClientePorCodigo)
        {
            return _contexto.VendasItem.Where(a => a.IdVendas == filtraClientePorCodigo.Codigo).ToList();
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
