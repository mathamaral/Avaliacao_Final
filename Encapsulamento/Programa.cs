using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Encapsulamento
{
    public class Programa
    {
        static void Main(string[] args){
            Navio Cargueiro = new Navio();
            Cargueiro.Carrega();
            Cargueiro.Ligar();
            Cargueiro.Mover();
            Cargueiro.Destino();
            Console.ReadLine();
        }
 
    }