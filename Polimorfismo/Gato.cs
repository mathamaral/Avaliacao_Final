using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Polimorfismo
{
    public class Gato: Animal
    {
        public string Familia;

        public override void Correr()
        {
        Console.WriteLine($" {Familia} {Raca} andando...");

        }
    }
}