namespace construtor
{
    public class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("executado");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine($"Seu nome é {nome}");
        }
    }
}