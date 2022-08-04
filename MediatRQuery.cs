using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace $NAMESPACE$
{
    public class $CLASS$Query : IRequest<TodosVm>
    {
    }

    public class $CLASS$QueryHandler : IRequestHandler<$CLASS$Query, TodosVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public $CLASS$QueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TodosVm> Handle($CLASS$Query request, CancellationToken cancellationToken)
        {
            return new TodosVm();
        }
    }
}
