using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class DataApprover
    {
        private static DataApprover _instance=null;
        private List<ModelApprover> _list = null;
        private DataApprover() { }

        public static DataApprover Instance
        {
            get
            {
                if (_instance == null) _instance = new DataApprover();
                return _instance;
            }
        }

        public List<ModelApprover> List
        {
            get
            {
                if (_list == null)
                {
                    _list = new List<ModelApprover>();
                    _list.Add(new ModelApprover() { Name = "Ryan Dahl", Prime = 2, Order = 1, Action = "Approve" });
                    _list.Add(new ModelApprover() { Name = "Yukihiro Matsumoto", Prime = 3, Order = 2, Action = "Approve" });
                    _list.Add(new ModelApprover() { Name = "Guido Van Rossum", Prime = 5, Order = 3, Action = "Approve" });
                    _list.Add(new ModelApprover() { Name = "Bjarne Stroustrup", Prime = 7, Order = 4, Action = "Approve" });
                }
                return _list;
            }
        }

    }
}