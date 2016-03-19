using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LayoutEdit
{
    class Group
    {
        //public Group();
        private string _name = "";
        private List<Int32> _databaseids = new List<Int32>();
        public string Name { get { return _name; } set { _name = value; } }
        public void AddItem(Int32 DatabaseID)
        {
            if (_databaseids.Contains(DatabaseID)) return;
            _databaseids.Add(DatabaseID);
        }
        public void RemoveItem(Int32 item)
        {
            _databaseids.Remove(item);
        }
        public List<Int32> GetItems()
        {
            return _databaseids;
        }
        
    }
}
