
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        //Tipos

        bool verdade = true;
        char c = 'F';
        int numero = 1;
        long numero_grande = 1010101010101010010;
        float numero_quebrado = 1;
        double numero_redondo = 2.3;
        decimal numero_decimal = 0;
        string palavra = "oi";
        byte b = 1;

        //Expressoes

        int num = 1;
        int num2 = 2;
        int soma = num + num2;
        Console.WriteLine(soma);
        soma++;
        Console.WriteLine(soma);
        soma--;
        Console.WriteLine(soma);

        //Inputs 

        Console.Write("Informe seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine(nome + "Voce é foda");
        Console.WriteLine($"Voce é o batman mannn {nome}");
        int ano = int.Parse(Console.ReadLine());
        int ano_correto = 2026 - ano;
        Console.WriteLine($"Sua idade é {ano}");

        //Estrutura de repeticao

        if (ano >= 18)
        //&& e
        // || ou
        // > < = ==
        {
            Console.WriteLine("Voce é maior de idade");
        }
        else if (ano == 100)
        {
            Console.WriteLine("voce é vei");
        }

        else
        {
            Console.WriteLine("Seu mentiroso");
        }

        //Arrays

        string[] frutas = { "banana", "maca", "manga" };
        Console.WriteLine(frutas[0]);

        //Estrutura de repeticao

        for (int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine(frutas[i]);
        }

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

    }
}