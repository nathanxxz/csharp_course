using System;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nome = "Nathan";
            aluno.nota1 = 10;
            aluno.nota2 = 10;
            aluno.nota3 = 10;
            aluno.mensagem();
        }
    }
}
