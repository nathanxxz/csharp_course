using System;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.peso = 80;
            pessoa.altura = 1.80;
            pessoa.mensagem();
        }
    }
}