using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class Billing
    {

        private Object _id;
        private Object _identifier;
        private Object _sender;
        private Object _target_type;
        private Object _target;
        private Object _label;
        private Object _amount;

        public Object Id { get => _id; set => _id = value; }
        public Object Identifier { get => _identifier; set => _identifier = value; }
        public Object Sender { get => _sender; set => _sender = value; }
        public Object Target_type { get => _target_type; set => _target_type = value; }
        public Object Target { get => _target; set => _target = value; }
        public Object Label { get => _label; set => _label = value; }
        public Object Amount { get => _amount; set => _amount = value; }


        public Billing(Dictionary<string, Object> _d)
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
