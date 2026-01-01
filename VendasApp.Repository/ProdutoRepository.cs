using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;
using System.Linq;
using VendasApp.Data;
using VendasApp.Models;
using VendasApp.Models.Dto;

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
        public Produto BuscarPorId(int id)
        {
            return _contexto.Produtos.Select(a => new Produto
            {
                Descricao = a.Descricao,
                Id=a.Id
            }).FirstOrDefault(b => b.Id == id);
        }
        public Produto BuscarPrecoPorId(int id)
        {
            return _contexto.Produtos.Select(a => new Produto
            {
                Preco = a.Preco,
                Id = a.Id
            }).FirstOrDefault(b => b.Id == id);
        }

        /// <summary>
        /// Seleciona todos os registros da tabela
        /// </summary>
        /// <returns></returns>
        public List<Produto> BuscarTodos()
        {
            return _contexto.Produtos.ToList();
        }
        public List<Produto> BuscarId(int produto)
        {
            return _contexto.Produtos.AsEnumerable().Where(a=>a.Id==produto && a.Id!=null).ToList();
        }
        public Produto BuscarQuantidadePorId(int ?produto)
        {
            return _contexto.Produtos.AsEnumerable().Select(a => new Produto()
            {

                Id = a.Id,
                Quantidade = a.Quantidade
            }).FirstOrDefault(b => b.Id == produto);
        }
        public List<Produto> BuscarQuantidade()
        {
            return _contexto.Produtos.AsEnumerable().Where(a=>a.Quantidade>0).ToList();
        }

        public List<Produto> BuscaProdutosAtivos(FiltraProdutoAtivo filtraProdutoAtivo)
        {
            return _contexto.Produtos.Where(b => b.Ativo == filtraProdutoAtivo.Ativo && b.Quantidade >= filtraProdutoAtivo.Quantidade).ToList();

        }
        public List<Produto> BuscaProdutosPreco(FiltraProdutoPreco filtraProdutoPreco)
        {
            //AsEnumerable atrasa o tempo de compilação de source de um tipo IEnumerable<T> para IEnumerable<T> si mesmo.
            return _contexto.Produtos.AsEnumerable().Where(b => b.Ativo == filtraProdutoPreco.Ativo && b.Preco >= filtraProdutoPreco.Preco).ToList();
        }
        public List<Produto> BuscaProdutosPorDataCadastro(FiltraProdutoPorData filtraProdutoPorData)
        {
            //AsEnumerable atrasa o tempo de compilação de source de um tipo IEnumerable<T> para IEnumerable<T> si mesmo.
            return _contexto.Produtos.AsEnumerable().Where(b => b.Ativo == filtraProdutoPorData.Ativo && b.DataInclusao >= filtraProdutoPorData.DataDeCadastro).ToList();
        }
        public List<Produto> BuscaProdutosPorDataValidade(FiltraProdutoPorDataValidade filtraprodutoPorDataValidade)
        {
            //AsEnumerable atrasa o tempo de compilação de source de um tipo IEnumerable<T> para IEnumerable<T> si mesmo.
            return _contexto.Produtos.AsEnumerable().Where(b => b.Ativo == filtraprodutoPorDataValidade.Ativo && b.DataValidade >= filtraprodutoPorDataValidade.DataDeValidade).ToList();
        }


    }
}