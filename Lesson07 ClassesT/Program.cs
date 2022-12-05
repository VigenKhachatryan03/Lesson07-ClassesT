using System;

namespace Lesson07_ClassesT
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1 obj = new TestClass1();
            obj.name = "Sasun";
            Console.WriteLine(obj.name);
            TestClass1 obj2 = new TestClass1();
            Console.WriteLine(obj2.name);
            obj.TestMethod();

            TestClass2.doub = 2.6;
            Console.WriteLine(TestClass2.doub);
            int a = (int)Enum_Class.Thursday;
            Console.WriteLine((int)Enum_Class.Sunday);
            Console.WriteLine((int)Enum_Class.Sunday);
            Console.WriteLine((int)Enum_Class.Tuesday);

        }
    }
}
