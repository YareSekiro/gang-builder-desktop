using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class UserWhitelist
    {

        private List<Object> _identifier;
        public List<object> Identifier { get => _identifier; set => _identifier = value; }

        public UserWhitelist(Dictionary<string, List<Object>> _d)
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
