using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class OwnedProperties
    {
        private List<object> _id;
        private List<object> _name;
        private List<object> _price;
        private List<object> _rented;
        private List<object> _owner;

        public List<object> Id { get => _id; set => _id = value; }
        public List<object> Name { get => _name; set => _name = value; }
        public List<object> Price { get => _price; set => _price = value; }
        public List<object> Rented { get => _rented; set => _rented = value; }
        public List<object> Owner { get => _owner; set => _owner = value; }

        public OwnedProperties(Dictionary<string, List<Object>> _d)
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
