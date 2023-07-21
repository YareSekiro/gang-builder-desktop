using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class UserInventory
    {
        private List<Object> _id;
        private List<Object> _identifier;
        private List<Object> _item;
        private List<Object> _count;

        public List<object> Id { get => _id; set => _id = value; }
        public List<object> Identifier { get => _identifier; set => _identifier = value; }
        public List<object> Item { get => _item; set => _item = value; }
        public List<object> Count { get => _count; set => _count = value; }

        public UserInventory(Dictionary<string, List<Object>> _d)
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
