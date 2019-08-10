using System;

namespace GitPractice
{
    class Program
    {
        public void SetProperties()
        {
            Console.WriteLine();
        }

        public static Homepage SetObjectPorperties()
        {
            return new Homepage("Phone", "Huawey Freebudds");
        }
        static void Main(string[] args)
        {
            var home = new Homepage("Phone", "Huawey Freebudds");
            Console.WriteLine(home.Header, home.UserInput);
            Console.ReadLine();
        }
    }
}
