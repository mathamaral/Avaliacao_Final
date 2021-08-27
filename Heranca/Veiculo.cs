using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Herança
{
    public class Pessoa
    {
        public string Modelo;
        public string Empresa;
        public string Pais;
        public string Motor;
        public string Cavalos;

        public void Dormir()
        {
            Console.Writeline("todos dormem");
        }
    }
}