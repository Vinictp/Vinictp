using System;
using System.Collections.Generic;
using System.Text;

namespace VIniciuscsharp.Fundamentos 
{
    class VariavesEConstantes 
    {

        public static void Executar() {
            //area de uma circunferencia 
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Aréa é " + area);


            //Tipos Internos
            bool estachovendo = true;
            Console.WriteLine(" Esta chovendo " + estachovendo);

            byte idade = 45;
            Console.WriteLine(" idade " + idade);

            sbyte saldodegols = sbyte.MinValue;
            Console.WriteLine(" Saldo de Gols " + saldodegols);


            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);


            int MenorValorInt = int.MinValue;// Mais usados dos inteiros!
            Console.WriteLine(" menor inteiro " + MenorValorInt);

            uint populacaobrasileira = 207_600_000;
            Console.WriteLine(" População Brasileira " + populacaobrasileira);


            long menorValorLong = long.MinValue;
            Console.WriteLine (" Menor long " + menorValorLong);

            ulong populacaomundial = 7_600_000_000;
            Console.WriteLine(" População Mundial " + populacaomundial);

            float precocomputador = 1299.99f;
            Console.WriteLine(" Preço do computador " + precocomputador);

            double ValorDeMercadoDaApple = 1000000000000.00; //Mais usados dos Reais 
            Console.WriteLine(" Valor Apple " + ValorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine(" distancia entre as estrelas " + distanciaEntreEstrelas);


            char letra = 'b';
            Console.WriteLine(" Letra " + letra);


            string texto = "Seja Bem vindo ao Csharp";
            Console.WriteLine(texto);


            


            

        }
    }
}
