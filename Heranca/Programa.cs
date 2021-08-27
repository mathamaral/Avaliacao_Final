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
            Veiculo1 veiculo1 = new Veiculo1();
            veiculo1.Modelo = "Huracan";
            veiculo1.Empresa = "Lamborghini"
            veiculo1.Pais = "Italia";
            veiculo1.Motor = "V12";
            veiculo1.Cavalos = "850";
            veiculo1.Registrar();

            Veiculo2 veiculo2 = new Veiculo2();
            veiculo2.Modelo = "Onix";
            veiculo2.Empresa = "Chevrolet"
            veiculo2.Pais = "Estados Unidos";
            veiculo2.Motor = "V4";
            veiculo2.Cavalos = "170";
            veiculo2.Registrar();
           
           
            Console.ReadLine();
        }
    }
}