namespace get_set
{
    public class Pessoa
    {
        private string nome;

        public Pessoa(string nome)
        {
            Console.WriteLine(this.nome);
        }

        public string Nome
        {
            get{return nome;}
            set{nome=value;}
        }
    }
}