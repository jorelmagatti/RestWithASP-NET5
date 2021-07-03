using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DAO
{
    public class MyConfiguration : DbConfiguration
    {
        public MyConfiguration()
        {
            SetProviderServices(System.Data.Entity.SqlServer
                                    .SqlProviderServices
                                    .ProviderInvariantName,
                                    System.Data.Entity.SqlServer
                                    .SqlProviderServices.Instance);
        }
    }
}
