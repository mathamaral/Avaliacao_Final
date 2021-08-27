using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Abstracao
{
    public class Trator
    {
        private string _nome;
        public Conexao Conecta1 { get; set; }
        public Conexao Conecta2 { get; set; }
      
        public string getNome()
    {
            return _nome;

    }
        public Trator(string nome)
    {
            _nome = nome;

    }

    }

    }
    public abstract class Conexao
    {
     public abstract void Conectar();
    }
    public class Arado : Conexao
    {
    public override void Conectar()
    {
        Console.WriteLine("Arado conectado ao trator..");
    }
    }
    public class Lamina: Conexao
    {
    public override void Conectar()
    {
        Console.WriteLine("Lamina conectado ao trator..");
    }
    }
    }  