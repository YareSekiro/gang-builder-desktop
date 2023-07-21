using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GangBuilderV2
{
    public class Tools
    {
        public static string UcFirst(string s)
        {
            var str = s.ToCharArray(0, s.Length);
            var charUpper = char.Parse(str[0].ToString().ToUpper());
            str[0] = charUpper;
            return string.Join("", str);
        }
    }
}
