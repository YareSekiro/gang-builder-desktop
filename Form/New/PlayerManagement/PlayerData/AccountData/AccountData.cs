using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class AccountData
    {
        private Object _id;
        private Object _account_name;
        private Object _money;
        private Object _owner;
        public AccountData(Dictionary<string, Object> _d)
        {
            this.Hydrate(_d);
        }
        

        private void Hydrate(Dictionary<string, Object> _d)
        {
            foreach(KeyValuePair<string, Object> _k in _d)
            {
                Console.WriteLine("Testing method : {0}", Tools.UcFirst(_k.Key).Trim());
                var method = typeof(AccountData).GetProperty(Tools.UcFirst(_k.Key).Trim());
                if(method != null)
                {
                    Console.WriteLine("Method {0} exists", Tools.UcFirst(_k.Key));
                    method.SetValue(this, _k.Value);
                    
                }
            }
        }



        public Object Id { get => _id; set => _id = value; }
        public Object Account_name { get => _account_name; set => _account_name = value; }
        public Object Money { get => _money; set => _money = value; }
        public Object Owner { get => _owner; set => _owner = value; }
    }
}
