using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGEstudante.ApplicationCore.Interface.Services
{
   public interface ICursoService
    {
        Curso Adicionar(Curso entity);

        void Atualizar(Curso entity);

        IEnumerable<Curso> ObterTodos();

        Curso ObterPorId(int id);

        IEnumerable<Curso> Buscar(Expression<Func<Curso, bool>> predicado);

        void Remover(Curso entity);
    }
}
