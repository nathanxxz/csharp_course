namespace poo
{
    public class Aluno
    {
        public string nome;

        public double nota1,nota2,nota3;


        public double media()
        {
            return(nota1+nota2+nota3)/3;
        }

        public string situacao(double media)
        {
            return media>=7 ? "aprovado" : "reprovado";
        }

        public void mensagem()
        {
            double obterMedia = media();

            string obterMensagem = situacao(obterMedia);

            Console.WriteLine($"Seu nome é {nome} sua situacao é {obterMensagem} e sua media foi {obterMedia}");
        }
    }
}