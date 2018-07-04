using SGEstudante.ApplicationCore.Entity;
using SGEstudante.ApplicationCore.Interface.Repository;
using SGEstudante.ApplicationCore.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGEstudante.ApplicationCore.Service
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public Contato Adicionar(Contato entity)
        {
            //TODO: add regra de negocio 

            return _contatoRepository.Adicionar(entity);
        }

        public void Atualizar(Contato entity)
        {
            _contatoRepository.Atualizar(entity);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
        {
            return _contatoRepository.Buscar(predicado);
        }

        public Contato ObterPorId(int id)
        {
            return _contatoRepository.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return _contatoRepository.ObterTodos();
        }

        public void Remover(Contato entity)
        {
            _contatoRepository.Remover(entity);
        }
    }
}
