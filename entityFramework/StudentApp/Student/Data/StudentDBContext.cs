using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class StudentDBContext : DbContext
{
    private string connectionString { get; set; }
    public DbSet<StudentMe> Students { get; set; }
    public StudentDBContext()
    {
        connectionString = ConfigurationManager.AppSettings["connectionString"];
    }

    protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
    {
        modelBuilder.UseSqlServer(connectionString);
    }
}