using System;
using System.Collections.Generic;
using System.Text;
using VendasApp.Data;
using VendasApp.Models;

namespace VendasApp.Repository
{
    public class FornecedorRepository
    {
        private readonly Contexto _contexto;
        public FornecedorRepository(Contexto contexto) {
            _contexto = contexto;
        
        }
        public void Inserir(Fornecedor fornecedor)
        {
            _contexto.Fornecedores.Add(fornecedor);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Atualiza o registro na tabela
        /// </summary>
        /// <param name="fornecedor"></param>
        public void Atualizar(Fornecedor fornecedor)
        {
            _contexto.Fornecedores.Update(fornecedor);
            _contexto.SaveChanges();
        }

        /// <summary>
        /// Excluir o registro na tabela
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id)
        {
            var fornecedor = _contexto.Fornecedores.Find(id);
            if (fornecedor != null)
            {
                _contexto.Fornecedores.Remove(fornecedor);
                _contexto.SaveChanges();
            }
        }
    }
}
