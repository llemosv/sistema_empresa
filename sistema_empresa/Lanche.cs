using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_empresa
{
    class Lanche
    {
        public double tamanho;
        public double temperaturaIdeal;
        public string tipoDoPao;
        public double peso;

        public void setTamanho(double tam)
        {
            tamanho = tam;
        }

        public void setTemperatura(double tmpIdeal)
        {
            temperaturaIdeal = tmpIdeal;
        }
        public void setPao(string tipo)
        {
            tipoDoPao = tipo;
        }
        public void setPeso(double value)
        {
            peso = value;
        }
    }
}
