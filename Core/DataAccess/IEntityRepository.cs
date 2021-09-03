using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{
    //generic constraint
    //class:referans tip 
    //Ientity olabilir yada Ienitity implemente eden bir nesne olabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()

    {
             
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
