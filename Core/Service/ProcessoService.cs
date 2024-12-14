using Core.Entities;
using Core.Interfaces.Repository;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service;

public class ProcessoService : BaseService<Processo>, IProcessoService
{
    private readonly IProcessoRepository _processoRepository;
    public ProcessoService(IProcessoRepository processoRepository) : base(processoRepository)
        => _processoRepository = processoRepository;

}
