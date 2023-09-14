using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment4.Models;

namespace Assignment4.Data
{
    public class AssignmentDbContext : DbContext
    {
        public AssignmentDbContext (DbContextOptions<AssignmentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment4.Models.Student> Student { get; set; } = default!;
    }
}
