using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
    interface ICategoryDal
    {
        Category GetById(int id);
        Category GetOne(Expression<Func<Category, bool>> filter);
        IQueryable<Category> GetAll(Expression<Func<Product, bool>> filter);

        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
