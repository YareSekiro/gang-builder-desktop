using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class PropertyItems
    {
        private List<Object> _id;
        private List<Object> _inventory_name;
        private List<Object> _name;
        private List<Object> _count;
        private List<Object> _owner;
        
        public List<object> Id { get => _id; set => _id = value; }
        public List<object> Inventory_name { get => _inventory_name; set => _inventory_name = value; }
        public List<object> Name { get => _name; set => _name = value; }
        public List<object> Count { get => _count; set => _count = value; }
        public List<object> Owner { get => _owner; set => _owner = value; }

        public PropertyItems(Dictionary<string, List<Object>> _d)
        {
            this.Hydrate(_d);
        }

        private void Hydrate(Dictionary<string, List<Object>> _d)
        {
            foreach (KeyValuePair<string, List<Object>> _k in _d)
            {
                Console.WriteLine("Testing method : {0}", Tools.UcFirst(_k.Key).Trim());
                var method = typeof(AccountData).GetProperty(Tools.UcFirst(_k.Key).Trim());
                if (method != null)
                {
                    Console.WriteLine("Method {0} exists", Tools.UcFirst(_k.Key));
                    method.SetValue(this, _k.Value);

                }
            }
        }
    }
}
