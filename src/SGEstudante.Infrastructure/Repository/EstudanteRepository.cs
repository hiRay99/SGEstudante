using SGEstudante.ApplicationCore.Entity;
using SGEstudante.ApplicationCore.Interface.Repository;
using SGEstudante.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGEstudante.Infrastructure.Repository
{
    public class EstudanteRepository : EFRepository<Estudante>, IEstudanteRepository
    {
        public EstudanteRepository(EstudanteContext dbContext):base(dbContext)
        {
            
        }


        public Estudante ObterPorCurso(int estudanteid)
        {
            return Buscar(x=> x.CursosEstudante.Any(c=> c.EstudanteId == estudanteid))
                .FirstOrDefault();
        }
    }
}
