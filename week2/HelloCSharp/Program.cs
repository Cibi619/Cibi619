// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
string myName = "";
Console.WriteLine("Please enter your name : ");
try {
     myName = Console.ReadLine();
}
catch (Exception e) {
    Console.WriteLine(e.Message);
}
Console.WriteLine(myName);*/

using System;

namespace SamplePrograms {
    class Program {
        public static void Main(String[] args) {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} - {DateTime.Now}");
        }
    }
}

