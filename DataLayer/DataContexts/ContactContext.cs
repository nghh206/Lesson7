using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DataLayer.DataContexts
{
    internal class ContactContext:DbContext
    {
        private string connectionString = "Data Source=Nghh;Initial Catalog=Lesson7;Integrated Security=True;Trust Server Certificate=True";
        public DbSet<Contact> Contact { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        internal void waite()
        {
            throw new NotImplementedException();
        }
    }
}
