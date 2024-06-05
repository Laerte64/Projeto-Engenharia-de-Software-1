using System;
using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Microsoft.EntityFrameworkCore;


namespace Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }

}
