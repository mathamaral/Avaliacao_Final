using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Encapsulamento
{
    public class Tamanho{}
    }
    public class Cor
    {
    }
    public class Navio
    {
    // Encapsulando Detalhes
    //Composição
    private Tamanho tamanho;
    private Cor cor;
    private string _nome;
    public string nome
    {
        get {
        return _nome;
            }
    }
    private void Helice()
    {
        Console.WriteLine("As helices foram acionadas");
    }
     public int NumHelices()
    {
        return 1;

    }
    //Construtor
    public Navio(string nome)
    {

    }
        Console.WriteLine("Criando objeto Navio");
        tamanho = new tamanho();
        cor = new cor();
        _nome = nome;
    }
    public void Ligar()
    {
        Console.WriteLine("Ligando o navio");
        Ignicao();
    }
    public void Mover()
    {
        Console.WriteLine("Movendo o navio");
    }
    public void Carrega()
    {
        Console.WriteLine("Carregando o navio");
    }
     public void Destino()
    {
        Console.WriteLine("Navio chegou ao destino");
    }
    }
}