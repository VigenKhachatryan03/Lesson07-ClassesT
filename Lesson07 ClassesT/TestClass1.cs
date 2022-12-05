using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson07_ClassesT
{
    class TestClass1
    {
        public const string brend = "BMW";
        public int x = 2;
        public double doub = 2.5;
        public string name = "Hakob";
        private string job = "Facebook";
        public void TestMethod()
        {
            Console.WriteLine(job);
            Console.WriteLine(name);
        }
    }
}
