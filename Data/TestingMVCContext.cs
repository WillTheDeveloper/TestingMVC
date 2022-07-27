using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestingMVC.Models;

namespace Post.Data
{
    public class TestingMVCContext : DbContext
    {
        public TestingMVCContext (DbContextOptions<TestingMVCContext> options)
            : base(options)
        {
        }

        public DbSet<TestingMVC.Models.Post> Post { get; set; } = default!;
    }
}
