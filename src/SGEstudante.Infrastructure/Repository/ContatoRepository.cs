using SGEstudante.ApplicationCore.Entity;
using SGEstudante.ApplicationCore.Interface.Repository;
using SGEstudante.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGEstudante.Infrastructure.Repository
{
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository
    {
        public ContatoRepository(EstudanteContext dbContext):base(dbContext)
        {
            
        }

    }
}
