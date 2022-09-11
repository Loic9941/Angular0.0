using Contracts;
using Domain.Entities;
using Domain.Repository;
using Services.Abstractions;


namespace Services
{
    public class BookableService : IBookableService
    {
        private readonly IGenericRepository<Bookable> _bookable;

        public BookableService(IGenericRepository<Bookable> bookable)
        {
            _bookable = bookable;
        }

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
