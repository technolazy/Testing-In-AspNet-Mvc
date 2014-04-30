using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03
{
    public class FizzBuzz
    {
        public IEnumerable<string> Generate(int count = 100)
        {
            for (var ii = 1; ii <= count; ii++)
            {
                var is3 = ii % 3 == 0;
                var is5 = ii % 5 == 0;

                if (!is3 && !is5)
                {
                    yield return Convert.ToString(ii);
                }
                else if (is3 && is5)
                {
                    yield return "FizzBuzz";
                }
                else if (is3)
                {
                    yield return "Fizz";
                }
                else 
                {
                    yield return "Buzz";
                }
            }
        }
    }
}
