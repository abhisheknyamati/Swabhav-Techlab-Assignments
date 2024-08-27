using ContactWebApp.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactWebApp.Data
{
    public class ContactDBContext : DbContext
    {
        public string ConnectionString { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }    

        public ContactDBContext()
        {
            ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContactRestApp;Integrated Security=True;Connect Timeout=30;Trust Server Certificate=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}
