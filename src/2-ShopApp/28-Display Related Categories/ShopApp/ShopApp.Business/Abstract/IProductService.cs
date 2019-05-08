using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetByIdWithCategories(int id);
        Product GetProductDetails(int id);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(string category,int page, int pageSize);
        int GetCountByCategory(string category);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
