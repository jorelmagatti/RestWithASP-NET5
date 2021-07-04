using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Pomelo.EntityFrameworkCore.MySql;
using Entidades;

namespace DAO_MySql.ADO
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {

        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }
        
        public DbSet<TB_PERSON> TB_PERSON { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = getConnection();
            optionsBuilder.UseMySql(connectionString);
        }

        public static string getConnection()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["cslog"].ConnectionString;
        }


    }
}
