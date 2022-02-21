using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_Linq
{
    internal static class Extenssions
    {
        public static void AddTo(this string str, List<string> list)
        {
            list.Add(str);
        }
    }
}
