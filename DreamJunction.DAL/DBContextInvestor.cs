using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
namespace DreamJunction.DAL
{
    public class DBContextInvestor : IDBContextInvestor
    {
        private readonly ILifetimeScope _container;

        public DBContextInvestor()
        {

        }
        public DBContextInvestor(ILifetimeScope container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }
            _container = container;
        }
        public virtual IApplicationDbContext Create()
        {
            return _container.Resolve<IApplicationDbContext>();
        }
    }
}
