using System;

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

            switch (tpLanche)
            {
                case 1:
                   CachorroQuente();
                    break;
                case 2:
                    Sanduiche();
                    break;
            }

            double CachorroQuente()
            {
                Console.Write("Informe o tamanho do pão (15cm ou 30cm): ");
                double tamanho = Convert.ToDouble(Console.ReadLine());
                cachorro.setTamanho(tamanho);

                Console.Write("Informe a temperatura ideal (em ºC) do lanche: ");
                double tmpIdeal = Convert.ToDouble(Console.ReadLine());
                cachorro.setTemperatura(tmpIdeal);

                Console.Write("Informe o pão desejado: ");
                string pao = Console.ReadLine();
                cachorro.setPao(pao);

                Console.Write("Salsicha fatiada? ");
                char salsichaFatiada = Convert.ToChar(Console.ReadLine());
                if (salsichaFatiada == 's' || salsichaFatiada == 'S') cachorro.setSalsichaFatiada();

                Console.Write("Quantidade de salsichas? ");
                int qtdSalsicha = Convert.ToInt32(Console.ReadLine());
                cachorro.setQtdSalsicha(qtdSalsicha);

                Console.Write("Adicionar queijo? ");
                char addQueijo = Convert.ToChar(Console.ReadLine());
                if (addQueijo == 's' || addQueijo == 'S') cachorro.setQueijo();

                Console.Write("Informe o peso do lanche: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                cachorro.setPeso(peso);

                double valor = cachorro.calcularPrecoCachorroQuente();
                Console.Write($"O valor do cachorro quente é de R${valor} .");
                return valor;
            }

            void Sanduiche()
            {

            }
        }
    }
}
