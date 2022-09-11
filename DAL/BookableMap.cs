﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookableMap
    {
        public BookableMap(EntityTypeBuilder<Bookable> entityBuilder)
        { 
            entityBuilder.HasKey(p => p.Id);              
            entityBuilder.Property(p => p.Name);
        }
    }
}
