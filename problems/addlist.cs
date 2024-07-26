using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    internal class addlist
    {
        public void list_sum()
        {
            int[] a = new int[3];
            int[] b = new int[3];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            b[0] = 4;
            b[1] = 5;
            b[2] = 6;
            int[] c = new int[3];
            c[0] = a[0] + b[0];
            c[1] = a[1] + b[1];
            c[2] = a[2] + b[2];

            foreach (int i in c)
            {
                Console.WriteLine(i);
            }
            
            
        }
        
    }
}
