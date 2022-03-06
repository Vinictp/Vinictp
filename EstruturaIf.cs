using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf
    {

      public static void Executar()
        {
            bool bomcomportamento = false;
            string entrada;

            Console.Write("Digite a nota do Aluno");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N):");
            entrada = Console.ReadLine();

            if (entrada == "S" || entrada == "s")
                bomcomportamento = true;
            if (nota >= 9.0 && bomcomportamento) {
                Console.WriteLine("Quadro de honra");

            }
        }
    }
}
