using MedicalBilingMicroservice.Core.Models.Entities;
using MedicalBilingMicroservice.Core.Repositories;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}