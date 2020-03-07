using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DreamJunction.Entities;
namespace DreamJunction.DAL
{
    public interface IApplicationDbContext : IDisposable
    {
        IDbSet<InvestorDetail> InvestorDetail { get; set; }
        int SaveChanges();
    }
}
