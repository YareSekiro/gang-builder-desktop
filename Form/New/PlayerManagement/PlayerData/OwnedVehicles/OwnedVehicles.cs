using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class OwnedVehicles
    {
        private Object _id;
        private Object _vehicle;
        private Object _owner;
        private Object _state;
        private Object _stored;
        private Object _plate;
        private Object _type;
        private Object _job;

        public Object Id { get => _id; set => _id = value; }
        public Object Vehicle { get => _vehicle; set => _vehicle = value; }
        public Object Owner { get => _owner; set => _owner = value; }
        public Object State { get => _state; set => _state = value; }
        public Object Stored { get => _stored; set => _stored = value; }
        public Object Plate { get => _plate; set => _plate = value; }
        public Object Type { get => _type; set => _type = value; }
        public Object Job { get => _job; set => _job = value; }

        public OwnedVehicles(Dictionary<string, Object> _d)
        {
            this.Hydrate(_d);
        }



        private void Hydrate(Dictionary<string, Object> _d)
        {
            foreach (KeyValuePair<string, Object> _k in _d)
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
