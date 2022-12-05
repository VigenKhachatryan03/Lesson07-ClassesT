using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson07_ClassesT
{
    static class TestClass2
    {
        public const string brend = "BMW";
        public static int x = 2;
        public static double doub = 2.5;
        public static string name = "Hakob";
        private static string job = "Facebook";
        public static void TestMethod()
        {
            Console.WriteLine(job);
            Console.WriteLine(name);
        }
    }
}
