using ASP.NETCoreRepositoryPattern.Models;
namespace ASP.NETCoreRepositoryPattern.Data.EFCoreLayer
{
    public class EfCoreProductRepository : EfCoreRepository<Product,DBcontext>
    {
        public EfCoreProductRepository(DBcontext dBcontext):base(dBcontext)
        {

        }
    }
}
