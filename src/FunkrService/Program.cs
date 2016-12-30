using System;

namespace ConsoleApplication
{
    public class Program
    {

        public static void Main(string[] args)
        {
            FunkrService f = new FunkrService();
            Console.WriteLine("Hello World!");
            
            f.PingJamBase();      
        }
    }
}
