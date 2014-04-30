using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson02
{
    public class StringUtilities
    {
        public static string ReverseWordOrder(string value)
        {
            var words = Regex.Split(value, @"\s+")
                .Reverse()
                .ToArray();

            return string.Join(" ", words);
        }
    }
}
