using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Bridge
{
    public class LocationBase
    {
        private IRepository<Location> _data;

        public IRepository<Location> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public virtual void Add(Location t)
        {
            _data.Add(t);
        }
        public virtual void Delete(Location t)
        {
            _data.Delete(t);
        }
        public virtual void Next()
        {
            _data.Next();
        }
        public virtual void Prev()
        {
            _data.Prev();
        }
        public virtual void Show()
        {
            _data.Show();
        }
        public virtual void ShowAll()
        {
            _data.ShowAll();
        }

    }
}