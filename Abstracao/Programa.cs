using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Abstracao
{
    class Programa
    {
        static void Main(string[] args)
        {
            Trator trator = new Trator("Trator da marca Valtra");
            trator.Conecta1 = new Arado();
            var arado = new Arado();
            arado.Conectar();

            trator.Conecta2 = new Lamina();
            var lamina = new Lamina();
            lamina.Conectar();
            
            Console.ReadLine();
        }  
    }
}