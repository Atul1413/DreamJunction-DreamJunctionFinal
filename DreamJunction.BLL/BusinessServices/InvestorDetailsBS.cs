using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DreamJunction.BLL.BusinessServicesInterfaces;
using DreamJunction.DAL;
using DreamJunction.Entities;

namespace DreamJunction.BLL.BusinessServices
{
    public class InvestorDetailsBS : IInvestorDetails
    {
        private IDBContextInvestor _dbContextInvestor;
        public InvestorDetailsBS(IDBContextInvestor dbContextInvestor)
        {
            _dbContextInvestor = dbContextInvestor;
        }

        public void CreateInvestor(InvestorDetail mode)
        {
            using (var context = _dbContextInvestor.Create())
            {
                context.InvestorDetail.Add(new Entities.InvestorDetail()
                {
                    CreatedOn = DateTime.Now
                }
                );
                context.SaveChanges();
            }
        }
    }
}
