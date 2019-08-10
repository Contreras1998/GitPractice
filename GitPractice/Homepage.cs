using System;
using System.Collections.Generic;
using System.Text;

namespace GitPractice
{
    public class Homepage
    {
        public Homepage(string header, string userInput)
        {
            Header = header;
            UserInput = userInput;
        }
        public string Header { get; set; }
        public string UserInput { get; set; }

        public void GetProperties()
        {
            Console.WriteLine(Header,UserInput);
        }
    }
}
