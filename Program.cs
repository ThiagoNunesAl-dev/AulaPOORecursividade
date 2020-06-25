using System;

namespace AulaPOORecursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci: ");
            Recursividade rec = new Recursividade();
            rec.GerarFibonacci(0, 1, 10);

            Console.WriteLine("\nFatorial: ");
            Console.WriteLine(rec.GerarFatorial(5));

            Console.WriteLine("\nTribonacci: ");
            rec.GerarTribonacci(0, 1, 1, 10);
        }
    }
}
