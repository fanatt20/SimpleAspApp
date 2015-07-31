using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleAspApp.Models
{
    public class SimpleAspAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SimpleAspAppContext() : base("name=SimpleAspAppContext")
        {
        }

        public System.Data.Entity.DbSet<SimpleAspApp.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<SimpleAspApp.Models.Book> Books { get; set; }
    
    }
}
