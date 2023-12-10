﻿using System.Collections.Generic;

namespace VezeetaAPI.Interfaces
{
    public interface ICrudRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
