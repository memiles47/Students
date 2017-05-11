using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    static class Program
    {
        //VS unuseable offline after 15.2 update
        private static void Main()
        {
            var alison = new ArrayList() {"ID0001", 26, "A"};
            var bob = new ArrayList() {"ID0002", 27, "B"};
            var claire = new ArrayList() {"ID0003", 17, "C"};
            var dan = new ArrayList() {"ID0004", 21, "D"};
            var emma = new ArrayList() {"ID0005", 22, "E"};


            foreach (var item in alison)
                Console.WriteLine(item);

            var students = new Dictionary<string, ArrayList>
            {
                {"Alison", alison},
                { "Bob", bob},
                { "Claire", claire},
                { "Dan", dan},
                { "Emma", emma}
            };
        }
    }
}
