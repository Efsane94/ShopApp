using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        int GetCountByCategory(string category);

        IEnumerable<Product> GetProductsByCategory(string category,int page, int pageSize);

        Product GetProductDetails(int id);
        Product GetByIdWithCategories(int id);
        void Update(Product entity, int[] categoryIds);
    }
}