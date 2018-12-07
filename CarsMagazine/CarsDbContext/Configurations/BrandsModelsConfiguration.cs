using CarsDbContext.Management.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDbContext.Management.Configurations
{
    public class BrandsModelsConfiguration : EntityTypeConfiguration<BrandsModels>
    {

        public void Configure()
        {
            this.HasKey(table => new { table.Brand, table.Model });
        }
    }
}
