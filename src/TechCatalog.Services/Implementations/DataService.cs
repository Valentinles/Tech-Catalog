using System;
using System.Collections.Generic;
using System.Text;
using TechCatalog.Data;

namespace TechCatalog.Services.Implementations
{
    public class DataService
    {
        protected readonly TechCatalogDbContext context;

        public DataService(TechCatalogDbContext context)
        {
            this.context = context;
        }
    }
}
