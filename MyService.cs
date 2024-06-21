using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    internal class MyService : IMyService
    {
        public string getData()
        {
            return "Hello World";
        }

        public string greet(string name)
        {
            return "Hello" + name;
        }

        public int[] sortArray(int[] ar)
        {
            Array.Sort(ar);
            return ar;
        }

        public int totalMarks(Student s)
        {
            return s.marks1 + s.marks2;
        }
    }
}
