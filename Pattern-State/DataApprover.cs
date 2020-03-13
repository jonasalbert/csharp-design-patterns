using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_State
{
    public class DataApprover
    {
        private static DataApprover _instance=null;
        private List<ModelApprover> _dataSource = null;
        private DataApprover() { }

        public static DataApprover Instance
        {
            get
            {
                if (_instance == null) _instance = new DataApprover();
                return _instance;
            }
        }

        public List<ModelApprover> DataSource
        {
            get
            {
                if (_dataSource == null)
                {
                    _dataSource = new List<ModelApprover>();
                    _dataSource.Add(new ModelApprover() { Name = "", Prime = 2, Order = 1, Action = "Approve" });
                    _dataSource.Add(new ModelApprover() { Name = "", Prime = 3, Order = 2, Action = "Approve" });
                    _dataSource.Add(new ModelApprover() { Name = "", Prime = 5, Order = 3, Action = "Approve" });
                    _dataSource.Add(new ModelApprover() { Name = "", Prime = 7, Order = 4, Action = "Approve" });
                }
                return _dataSource;
            }
        }

    }
}