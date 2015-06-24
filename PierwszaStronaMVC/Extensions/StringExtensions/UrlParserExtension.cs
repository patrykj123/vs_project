using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.StringExtensions
{
    public static class UrlParserExtension
    {
        public static Dictionary<string, string> ParseUrl(this string str)
        {
            return str.Contains('=') ?
                str.Split('&').Select(x => x.Split('=')).ToDictionary(x => x[0], y => y[1])
                : new Dictionary<string, string>();
        }


    }
}
