namespace poo
{
    public class Pessoa
    {
        public double peso;

        public double altura;


        public double imc()
        {
            return peso/(altura*altura);
        }

        public string status(double imc)
        {
            string retorno;

            if (imc < 18.5)
            {
                retorno = "abaixo do peso";
            }
            else if(imc < 25)
            {
                retorno = "peso normal";
            }
            else if (imc < 30)
            {
                retorno = "acima do peso normal";
            }
            else if (imc < 35)
            {
                retorno = "obeso";
            }
            else if (imc < 40)
            {
                retorno = "obeso 2";
            }
            else
            {
                retorno = "obeso 3";
            }
            return retorno;
        }
        public void mensagem()
        {
            double obterCalculo = imc();

            string obterSituacao = status(obterCalculo);

            Console.WriteLine($"Seu imc é {obterCalculo}, sua situacao é {obterSituacao}");
        }
    }

  
}