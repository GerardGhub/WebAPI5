﻿using System.Collections;
using System.Collections.Generic;

namespace WebAPI5.Contracts
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetOne (int id);
        void Add(T user);
        void Update(T user);
        void Delete(int id);
    }
}
