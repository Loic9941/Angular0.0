using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Bookable
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }

    }
}
