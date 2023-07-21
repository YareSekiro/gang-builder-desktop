using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class OwnedBoats
    {

        private List<Object> _id;
        private List<Object> _vehicle;
        private List<Object> _owner;
        private List<Object> _state;
        private List<Object> _stored;
        private List<Object> _plate;
        private List<Object> _type;
        private List<Object> _job;

        public List<object> Id { get => _id; set => _id = value; }
        public List<object> Vehicle { get => _vehicle; set => _vehicle = value; }
        public List<object> Owner { get => _owner; set => _owner = value; }
        public List<object> State { get => _state; set => _state = value; }
        public List<object> Stored { get => _stored; set => _stored = value; }
        public List<object> Plate { get => _plate; set => _plate = value; }
        public List<object> Type { get => _type; set => _type = value; }
        public List<object> Job { get => _job; set => _job = value; }

        public OwnedBoats(Dictionary<string, List<object>> _d)
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
