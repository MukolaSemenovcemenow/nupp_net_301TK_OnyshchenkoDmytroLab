using System;
using System.Collections.Generic;
using System.Linq;
using Lab1_0110D4.Models;

namespace Lab1_0110D4.Services
{
    public class CrudService<T> : ICrudService<T> where T : IEntity
    {
        private readonly List<T> _items = new List<T>();

        public void Create(T element)
        {
            _items.Add(element);
        }

        public T Read(Guid id)
        {
            return _items.FirstOrDefault(item => item.Id == id);
        }

        public IEnumerable<T> ReadAll()
        {
            return _items;
        }

        public void Update(T element)
        {
            var index = _items.FindIndex(item => item.Id == element.Id);
            if (index != -1)
            {
                _items[index] = element;
            }
        }

        public void Remove(T element)
        {
            _items.RemoveAll(item => item.Id == element.Id);
        }
    }
}
