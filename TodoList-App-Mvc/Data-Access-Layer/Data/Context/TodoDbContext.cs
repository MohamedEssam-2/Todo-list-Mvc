using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Data_Access_Layer.Models;
namespace Data_Access_Layer.Data.Context
{
    public class TodoDbContext :DbContext 
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoDbContext).Assembly);
        }
        public DbSet<Todo> Todo { get; set; }
    }
}
