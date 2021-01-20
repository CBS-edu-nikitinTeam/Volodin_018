using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass { Change = "Не изменено" };
            MyStruct myStruct = new MyStruct { Change = "Не изменено" };

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine(myClass.Change);
            Console.WriteLine(myStruct.Change);
        }

        private static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "Изменено";
        }

        private static void StructTaker(MyStruct myStruct)
        {
            myStruct.Change = "Изменено";
        }
    }

    struct MyStruct
    {
        public string Change { get; set; }
    }

    class MyClass
    {
        public string Change { get; set; }
    }
}
