using DataAccess.Abstract;
using Entities.Concrete; 

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        // The implementations will be completed in v2
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
