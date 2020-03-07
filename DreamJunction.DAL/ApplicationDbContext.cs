using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using DreamJunction.Entities;
namespace DreamJunction.DAL
{
    public class ApplicationDbContext: IdentityDbContext, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<InvestorDetail>().Property(t => t.FirstName).IsOptional();
            //modelBuilder.Entity<InvestorDetail>().Property(t => t.Gender).IsOptional();

            base.OnModelCreating(modelBuilder);
        }
        public virtual IDbSet<InvestorDetail> InvestorDetail { get; set; }
    }
}
