using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Infrastructure;


namespace CodeBasedEntity
{
    public class Configuracao : DbConfiguration
    {
        public Configuracao()
        {
            SetProviderServices(SqlProviderServices.ProviderInvariantName,SqlProviderServices.Instance);
            SetDefaultConnectionFactory(new SqlConnectionFactory());
        }
    }
}
