using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    internal class longsubstring
    {
        public void sub()
        {
            List<string> list = new List<string>();
            list.Add("d");
            list.Add("e");
            list.Add("f");
            list.Add("g");
            list.Add("e");
            list.Add("f");
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");

            foreach (string s in list)
            {
                Console.WriteLine(s);

            }


            list.Append("ehjhj");

            Console.WriteLine("\n");
            foreach (string s in list)
            {
                Console.WriteLine(s);

            }

            List<string> strings = new List<string>();
            strings.Append("a");
            strings.Append("b");
            
            Console.WriteLine();

            foreach (string s in strings)
            {
                Console.WriteLine(s);

            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n a");
            stringBuilder.Append("\n b");
            stringBuilder.Append("\n c");
                
            stringBuilder.Append("\n d");
            stringBuilder.Clear();

            Console.WriteLine(stringBuilder);
            list.Clear();
            foreach (string s in list)
            {
                Console.WriteLine(s);

            }

        }
    }
}
