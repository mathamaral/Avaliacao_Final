using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    class Programa
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 20;
           
            Calculadora calc = new Calculadora();
            int r = calc.Div(a, b);
            
            Console.Writeline("A divisão de a com b é igual a: " a, b, r);
            
            Console.ReadLine();
        }
        private static int Div(int n1, int n2)
        {
            return n1/n2;
        }
    }
}