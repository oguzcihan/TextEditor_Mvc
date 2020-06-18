using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace texteditor.Models
{
    public class EgitimContext:DbContext
    {
        public EgitimContext():base("egitimDb2")
        {
            Database.SetInitializer(new EgitimInitializer());
        }
        public DbSet<Blog> Bloglar { get; set; }
    }
}