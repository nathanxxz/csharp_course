using System;

namespace get_set
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("alemao");
            Console.WriteLine(pessoa.Nome);
        }
    }
}