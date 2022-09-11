using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IBookableService
    {
        Task<IEnumerable<BookableDTO>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<BookableDTO> GetByIdAsync(Guid Guid, CancellationToken cancellationToken = default);

    }
}
