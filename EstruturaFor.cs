using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar() {



            for (int i = 1; i <= 10; i++)
            {


                Console.WriteLine($"O Valor de i é {i}.");
            }

            double somatorio = 0;
            string entrada;
            Console.Write(" Informe o Tamanho da Turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do Aluno  {0} : ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaatual);

                somatorio += notaatual;


            }


            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da Turma: {0}", media);


                
            
        }
    }
}
