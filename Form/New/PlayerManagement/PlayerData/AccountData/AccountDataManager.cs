using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class AccountDataManager : Estarossa
    {
        public AccountDataManager()
        {
            this.Initialize();
        }

        //public AccountData GetAccountData(object steam)
        //{
        //    var _acc = this.GetData(
        //        QueryConfig.QueryForAccountData,
        //        new List<string>(new string[] { "?steam" }),
        //        new List<object>(new object[] { steam })
        //        );

        //    Dictionary<string, object> _return = new Dictionary<string, object>();
        //    foreach(KeyValuePair<string , List<object>> _k in _acc)
        //    {
        //        foreach(object _obj in _k.Value)
        //        {
                    
        //        }
        //    }

        //}
    }
}
