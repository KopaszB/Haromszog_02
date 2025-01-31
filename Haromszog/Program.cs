using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    public class HaromszogTipus
    {
        public string HaromszogTipusEllenorzes(int a, int b, int c)
        {
            if (a + b > c && b + c > a && c + a > b)
            {
                if (a == b && a == c && b == c)
                {
                    return "Szabályos háromszög!";
                }
                else if (a == b || b == c || a == c)
                {
                    return "Egyenlő szárú háromszög";
                }
                else
                {
                    return "Általános háromszög";
                }
            }
            else
            {
                return "Nem háromszög!";
            }
                
        }

        static void Main(string[] args)
        {
            
        }
    }
}
