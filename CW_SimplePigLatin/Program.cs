using System;

namespace CW_SimplePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Kata();
            Console.WriteLine(a.PigIt("Pig latin is cool"));
            Console.ReadKey();
        }
    }
}
