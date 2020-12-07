﻿using System.Collections.Generic;

namespace FinalProject.Models
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List(QueryOptions<T> options);
        T Get(int id);
        T Get(QueryOptions<T> queryOptions);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
