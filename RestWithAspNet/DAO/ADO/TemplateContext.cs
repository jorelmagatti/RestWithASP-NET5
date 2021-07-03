using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Text;

namespace DAO.ADO
{
    public class TemplateContext : DbContext
    {

        public DbSet<TB_PERSON> TB_PERSON { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = getConnection().ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }

        public static OdbcConnection getConnection()
        {
            OdbcConnection con = new OdbcConnection();
            con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cslog"].ConnectionString;
            return con;
        }
    }
}
