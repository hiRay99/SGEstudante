using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGEstudante.ApplicationCore.Interface.Services
{
   public interface IEstudanteService
    {
        Estudante Adicionar(Estudante entity);

        void Atualizar(Estudante entity);

        IEnumerable<Estudante> ObterTodos();

        Estudante ObterPorId(int id);

        IEnumerable<Estudante> Buscar(Expression<Func<Estudante, bool>> predicado);

        void Remover(Estudante entity);
    }
}
