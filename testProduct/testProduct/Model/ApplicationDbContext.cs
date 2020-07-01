using System;
using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Web;

namespace testProduct.Model
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext() : base("WebApiCS")
        {
        }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}