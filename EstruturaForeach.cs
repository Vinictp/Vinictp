using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar () {

            var palavra = "opa!";

            foreach (var letra in palavra)
            {

                Console.WriteLine(letra);

            }



        }
    }
}
