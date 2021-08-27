using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Polimorfismo
{
    class Programa
    {
         static void Main(string[] args)
        {
        Animal b = new Tigre();
        c.Raca = "Tigre de Bengala";
        c.Correr();
            
        Animal c = new Cachorro();
        c.Raca = "Dalmata";
        c.Correr();

        Animal a = new Gato();
        a.Raca = "Angora";
        a.Correr();
        Console.ReadLine();
        }
    }
}