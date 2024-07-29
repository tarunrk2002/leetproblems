using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    internal class stu
    {
        private string name;
        private int age;
        


       public  stu(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name {  get { return name; } }
        public int Age { get { return age; }

            set 
            {
                if (value < 18)
                {
                    age = value;
                }

            }
        }
    }
}
