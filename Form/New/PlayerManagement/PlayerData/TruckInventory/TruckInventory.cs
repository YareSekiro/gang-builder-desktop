using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class TruckInventory
    {
        private List<Object> _id;
        private List<Object> _item;
        private List<Object> _itemt;
        private List<Object> _count;
        private List<Object> _plate;
        private List<Object> _owned;
        private List<Object> _ammo;

        public List<object> Id { get => _id; set => _id = value; }
        public List<object> Item { get => _item; set => _item = value; }
        public List<object> Itemt { get => _itemt; set => _itemt = value; }
        public List<object> Count { get => _count; set => _count = value; }
        public List<object> Plate { get => _plate; set => _plate = value; }
        public List<object> Owned { get => _owned; set => _owned = value; }
        public List<object> Ammo { get => _ammo; set => _ammo = value; }

        public TruckInventory(Dictionary<string, List<Object>> _d)
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
