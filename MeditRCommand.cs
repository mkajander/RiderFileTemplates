using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace $NAMESPACE$
{
    public class $CLASS$Command : IRequest<int>
    {
        public int ListId { get; set; }

        public string Title { get; set; }
    }

    public class $CLASS$CommandHandler : IRequestHandler<$CLASS$Command, int>
    {
        private readonly IApplicationDbContext _context;

        public $CLASS$CommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle($CLASS$Command request, CancellationToken cancellationToken)
        {
            var entity = new TodoItem
            {
                ListId = request.ListId,
                Title = request.Title,
                Done = false
            };

            entity.DomainEvents.Add(new $CLASS$CreatedEvent(entity));

            _context.$CLASS$s.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
