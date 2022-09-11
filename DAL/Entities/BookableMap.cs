using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class BookableMap
    {
        public BookableMap(EntityTypeBuilder<Bookable> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Guid);
            entityBuilder.Property(p => p.Name);
        }
    }
}
