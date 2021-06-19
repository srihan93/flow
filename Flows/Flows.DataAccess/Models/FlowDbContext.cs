﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flows.DataAccess.Models
{
    class FlowDbContext : DbContext
    {
        public FlowDbContext(DbContextOptions<FlowDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
