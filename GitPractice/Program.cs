using System;

namespace GitPractice
{
    class Program
    {
        public void SetProperties()
        {
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var homePage = new Homepage("Headphones", "Huawey Freebudds");
            homePage.GetProperties();

        }
    }
}
