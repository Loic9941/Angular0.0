using Contracts;
using Services.Abstractions;


namespace Services
{
    public class BookableService : IBookableService
    {
        public Task<IEnumerable<BookableDTO>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<BookableDTO> GetByIdAsync(Guid Guid, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
