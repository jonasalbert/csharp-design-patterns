using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class CollectionApprover
    {
        private static CollectionApprover _instance=null;
        private List<ModelApprover> _list = null;
        private CollectionApprover() { }

        public static CollectionApprover Instance
        {
            get
            {
                if (_instance == null) _instance = new CollectionApprover();
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