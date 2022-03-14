using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_empresa
{
    class CachorroQuente : Lanche
    {
        public int qtdSalsicha;
        public bool EhFatiada = false;
        public bool queijo = false;

        public void setQtdSalsicha(int qtd)
        {
             qtdSalsicha = qtd;
        }
        public void setSalsichaFatiada()
        {
             EhFatiada = true;
        }
        public void setQueijo()
        {
             queijo = true;
        }

        public double calcularPrecoCachorroQuente()
        {
            double preco = qtdSalsicha;

            if (queijo == true) preco += 0.75;

           return preco *= (peso / 1000);
        }
    }
}
