using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Decorator
{
    public class CollectionLocation
    {
        private static CollectionLocation _instance = null;
        private List<ModelLocation> _list = null;

        private CollectionLocation() { }


        public static CollectionLocation Instance
        {
            get
            {
                if (_instance == null) _instance = new CollectionLocation();
                return _instance;
            }
        }

        public List<ModelLocation> List
        {
            get
            {
                if (_list == null)
                {
                    _list = new List<ModelLocation>();
                    _list.Add(new ModelLocation() { Name = "H.O.", Prime = 2 });
                    _list.Add(new ModelLocation() { Name = "Manila", Prime = 3 });
                    _list.Add(new ModelLocation() { Name = "Cebu", Prime = 5 });
                    _list.Add(new ModelLocation() { Name = "Davao", Prime = 7 });
                }
                return _list;
            }
        }

    }
}