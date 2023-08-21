using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace Calculadora_CSharp
{
    class Operacoes
    {
        public Double ResultadoOperacao;

        //operações da calculadora
        //operação de soma
        public void Somar(Double x, Double y)
        {
            this.ResultadoOperacao = x + y;
            Console.WriteLine(ResultadoOperacao);
        }
        //operação de subtração
        public void Subtrair(Double x, Double y)
        {
            this.ResultadoOperacao = x - y;
            Console.WriteLine(ResultadoOperacao);
        }
        //operação de divisão
        public void Dividir(Double x, Double y)
        {
            this.ResultadoOperacao = x / y;
            Console.WriteLine(ResultadoOperacao);
        }
        //operação de multiplicação
        public void Multiplicar(Double x, Double y)
        {
            this.ResultadoOperacao = x * y;
            Console.WriteLine(ResultadoOperacao);
        }

    }
}
