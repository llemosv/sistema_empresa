using System;
using System.Globalization;

namespace sistema_empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Lanche lanche = new Lanche();
            CachorroQuente cachorro = new CachorroQuente();
            Sanduiche sanduba = new Sanduiche();

            Console.Write("Informe o lanche desejado (1 = Cachorro quente, 2 = Sanduiche): ");
            int tpLanche = Convert.ToInt32(Console.ReadLine());

            if (tpLanche != 1 && tpLanche != 2) Console.WriteLine("Informe um lanche válido.");

            switch (tpLanche)
            {
                case 1:
                   CachorroQuente(cachorro);
                    break;
                case 2:
                    Sanduiche(sanduba);
                    break;
            }
        }

        static public string CachorroQuente(CachorroQuente cachorro)
        {
            Console.Write("Informe o tamanho do pão (15cm ou 30cm): ");
            double tamanho = Convert.ToDouble(Console.ReadLine());
            if (tamanho != 15 && tamanho != 30) 
            {  
                string errPao =  "Informe um tamanho de pão válido.";
                Console.WriteLine(errPao);
                return errPao;
            }
            cachorro.setTamanho(tamanho);

            Console.Write("Informe a temperatura ideal (em ºC) do lanche: ");
            double tmpIdeal = Convert.ToDouble(Console.ReadLine());
            cachorro.setTemperatura(tmpIdeal);

            Console.Write("Informe o pão desejado: ");
            string pao = Console.ReadLine();
            cachorro.setPao(pao);

            Console.Write("Salsicha fatiada? ");
            char salsichaFatiada = Convert.ToChar(Console.ReadLine());
            if (salsichaFatiada != 's' && salsichaFatiada != 'n')
            {
                string errSalsicha = "Informe uma opção válida.";
                Console.WriteLine(errSalsicha);
                return errSalsicha;
            }
            if (salsichaFatiada == 's' || salsichaFatiada == 'S') cachorro.setSalsichaFatiada();

            Console.Write("Quantidade de salsichas? ");
            int qtdSalsicha = Convert.ToInt32(Console.ReadLine());
            cachorro.setQtdSalsicha(qtdSalsicha);

            Console.Write("Adicionar queijo? ");
            char addQueijo = Convert.ToChar(Console.ReadLine());
            if (addQueijo != 's' && addQueijo != 'n')
            {
                string errQueijo = "Informe uma opção válida.";
                Console.WriteLine(errQueijo);
                return errQueijo;
            }
            if (addQueijo == 's' || addQueijo == 'S') cachorro.setQueijo();

            Console.Write("Informe o peso do lanche (em gramas): ");
            double peso = Convert.ToDouble(Console.ReadLine());
            cachorro.setPeso(peso);

            double valor = cachorro.calcularPrecoCachorroQuente();
            string message = $"O valor do cachorro quente é de R${valor} .";
            Console.WriteLine(message);
            return message;
        }
       static public string Sanduiche(Sanduiche sanduba)
        {
            Console.Write("Informe a quantidade de fatias de queijo: ");
            int fatiaQueijo = Convert.ToInt32(Console.ReadLine());
            sanduba.qtdQueijo(fatiaQueijo);

            Console.Write("Informe a quantidade de fatias de presunto: ");
            int fatiaPresunto = Convert.ToInt32(Console.ReadLine());
            sanduba.qtdPresunto(fatiaPresunto);

            Console.Write("Adicionar alface? ");
            char addAlface = Convert.ToChar(Console.ReadLine());
            if (addAlface != 's' && addAlface != 'n')
            {
                string errAlface = "Informe uma opção válida.";
                Console.WriteLine(errAlface);
                return errAlface;
            }
            if (addAlface == 's' || addAlface == 'S') sanduba.setAlface();

            Console.Write("Informe o peso do lanche (em gramas): ");
            double peso = Convert.ToDouble(Console.ReadLine());
            sanduba.setPeso(peso);

            double valor = sanduba.calcularPrecoSanduiche();
            string message = $"O valor do sanduiche é de R${valor} .";
            Console.WriteLine(message);
            return message;
        }
    }
}
