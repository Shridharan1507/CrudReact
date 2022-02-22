﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class EmplContext:DbContext
    {

        public EmplContext(DbContextOptions<EmplContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
 
        public DbSet<Department> Departments { get; set; }
    }
}
