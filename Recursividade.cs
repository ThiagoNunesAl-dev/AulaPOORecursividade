namespace AulaPOORecursividade
{
    using System;
    public class Recursividade
    {
        public void GerarFibonacci (int num1, int num2, int vezes) {
            if (vezes > 0) {
                Console.WriteLine (num1);
                GerarFibonacci(num2, num1 + num2, vezes - 1);
            }
        }

        public int GerarFatorial (int numero) {
            if (numero == 1) {
                return 1;
            } else {
                //Console.WriteLine(numero);
                return numero * GerarFatorial (numero - 1);
            }
        }

        public void GerarTribonacci (int num1, int num2, int num3, int vezes) {
            if (vezes > 0) {
                Console.WriteLine(num1);
                GerarTribonacci(num2, num3, num1 + num2 + num3, vezes -1);
            }

        }
    }
}