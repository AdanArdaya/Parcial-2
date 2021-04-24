using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DataContext :DbContext
    {

        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApplication1.Models.Friend> Friends { get; set; }
    }
}