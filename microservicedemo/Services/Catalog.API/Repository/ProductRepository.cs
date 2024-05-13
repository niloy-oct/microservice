using System.Linq.Expressions;
using Catalog.API.DatabaseContext;
using Catalog.API.Interfaces.Repository;
using Catalog.API.Models;
using MongoRepo.Interfaces.Repository;
using MongoRepo.Repository;

namespace Catalog.API.Repository;

public class ProductRepository : CommonRepository<Product>, IProductRepository
{
    public ProductRepository() : base(new CatalogDbContext())
    {
    }
}