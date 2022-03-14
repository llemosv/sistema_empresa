using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_empresa
{
    class Sanduiche : Lanche
    {
        public int fatiasQueijo;
        public int fatiasPresunto;
        public bool alface = false;

        public void qtdQueijo(int qtd)
        {
            fatiasQueijo = qtd;
        }
        public void qtdPresunto(int qtd)
        {
            fatiasPresunto = qtd;
        }
        public void setAlface()
        {
            alface = true;
        }
        public double calcularPrecoSanduiche()
        {
            double preco;
            double precoQueijo = fatiasQueijo * 0.50;
            double precoPresunto = fatiasPresunto * 0.65;
            preco = precoQueijo + precoPresunto;

            if (alface == true) preco += 0.75;

            return preco *= (peso / 1000);
        }
    }
}
