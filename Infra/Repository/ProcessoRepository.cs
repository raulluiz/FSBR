using Core.Entities;
using Core.Interfaces.Repository;
using Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository;

public class ProcessoRepository : BaseRepository<Processo>, IProcessoRepository
{
    protected ProcessoRepository(IbgeContext dbContext) : base(dbContext)
    {
    }

}
