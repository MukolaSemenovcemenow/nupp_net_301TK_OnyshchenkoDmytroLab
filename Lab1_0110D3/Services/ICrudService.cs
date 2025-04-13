using System;
using System.Collections.Generic;
using Lab1_0110D3.Models;

namespace Lab1_0110D3.Services
{
    public interface ICrudService<T> where T : IEntity
    {
        void Create(T element);
        T Read(Guid id);
        IEnumerable<T> ReadAll();
        void Update(T element);
        void Remove(T element);
    }
}
