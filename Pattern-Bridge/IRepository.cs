using System;
using System.Collections.Generic;

namespace Pattern_Bridge
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        public int Current { get; set; }
        public List<TEntity> List { get; set; }
        public void Next();
        public void Prev();
        public void Add(TEntity t);
        public void Delete(TEntity t);
        public void Show();
        public void ShowAll();
    }

}