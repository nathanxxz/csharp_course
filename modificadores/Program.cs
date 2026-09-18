using System;

namespace modificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.nome = "Batman";
            //preco nao tem como atribuir valor pq ta private
        }
    }
}