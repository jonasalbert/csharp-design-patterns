using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Pattern_Bridge
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private int _current = 1;
        private List<TEntity> _list = new List<TEntity>();
        public List<TEntity> List 
        { 
            get { return _list; }
            set { _list = value; }
        }
        public int Current 
        {
            get { return _current; }
            set { _current = value; }
        }

        public void Add(TEntity item)
        {
            this.List.Add(item);
        }

        public void Delete(TEntity item)
        {
            this.List.Remove(item);
        }

        public void Next()
        {
            if (_current <= _list.Count-1)
            {
                _current++;
            }
        }

        public void Prev()
        {
            if (_current > 0) _current++;
        }

        private PropertyInfo[] GetProperties(object obj)
        {
            return obj.GetType().GetProperties();
        }

        public void Show()
        {
            var obj = _list[_current];
            var properties = this.GetProperties(obj);
            string props = "";
            foreach (var prop in properties)
            {
                props = props + "\t" + prop.GetValue(obj, null);
            }
            Console.WriteLine(props);
        }
        public void ShowAll()
        {
            var obj = _list[_current];
            var properties = this.GetProperties(obj);
            string props = "";
            foreach (var row in _list)
            {
                props = "";
                obj = row;
                properties = this.GetProperties(obj);
                foreach (PropertyInfo prop in properties)
                {
                    props = props + "\t" + prop.GetValue(obj, null);
                }
                Console.WriteLine(props);
            }            
        }
    }
}