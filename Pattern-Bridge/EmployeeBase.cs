using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Bridge
{
    public class EmployeeBase
    {
        private IRepository<Employee> _data;
        
        public IRepository<Employee> Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public virtual void Add(Employee t)
        {
            _data.Add(t);
        }
        public virtual void Delete(Employee t)
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