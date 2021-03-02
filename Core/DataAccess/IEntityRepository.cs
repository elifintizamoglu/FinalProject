using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //filtreleyerek ürünlerin listelenmesini sağlar
                                                                 //filter=null filtre vermeyedebilirsin demektir
        T Get(Expression<Func<T, bool>> filter);   //örn: bir bankacılık sisteminde tek bir kredinin ayrıntılarına gitmek için 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);     
    }
}
