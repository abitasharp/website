﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Abitasharp.Models
{
    public class ExampleContext : DbContext
    {
        public ExampleContext (DbContextOptions<ExampleContext> options)
            : base(options)
        {
        }

        public DbSet<Abitasharp.Models.Example> Example { get; set; }
    }
}
