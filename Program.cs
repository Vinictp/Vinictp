using System;
using System.Collections.Generic;

using VIniciuscsharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Variaves e constantes - Fundamentos", VariavesEConstantes.Executar },
                {"Inferencias - Fundamentos", Inferencias.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}