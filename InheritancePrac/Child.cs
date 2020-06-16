using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Child : Parent
    {
        public Child(int age):base(age)
        {
            Console.WriteLine("자식입니다");
        }
    }
}
