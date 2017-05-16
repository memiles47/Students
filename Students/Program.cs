using System;
using System.Collections.Generic;

namespace Students
{
    static class Program
    {
        private static void Main()
        {
            var students = new Dictionary<string, Dictionary<string, string>>()
            {
                {"Alison", new Dictionary<string, string>{ { "ID", "ID0001" }, { "Age", "26" }, {"Grade", "A" } } },
                {"Bob", new Dictionary<string, string>{ { "ID", "ID0001" }, { "Age", "26" }, {"Grade", "A" } } },
                {"Claire", new Dictionary<string, string>{ { "ID", "ID0001" }, { "Age", "26" }, {"Grade", "A" } } },
                {"Dan", new Dictionary<string, string>{ { "ID", "ID0001" }, { "Age", "26" }, {"Grade", "A" } } },
                {"Emma", new Dictionary<string, string>{ { "ID", "ID0001" }, { "Age", "26" }, {"Grade", "A" } } }
            };

            Console.WriteLine($"Alison's ID is: {students["Alison"]["ID"]}\n");
            Console.WriteLine($"Dan's ID is: {students["Dan"]["ID"]} and he is {students["Dan"]["Age"]} years old.");
        }
    }
}
