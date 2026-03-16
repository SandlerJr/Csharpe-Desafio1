    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int nota = -1;
            while (nota == -1) {
                Console.WriteLine("Digite sua nota media(numeros inteiros de 0 a 10):");
                nota = int.TryParse(Console.ReadLine(), out int result) ? result : -1;
                if (nota > 10 || nota < 0)
                {

                    Console.WriteLine("Nota inválida.");
                    nota = -1;
                } else {
                    if (nota >= 6)
                    {
                        Console.WriteLine("Aprovado");
                    }
                    else
                    {
                        Console.WriteLine("Reprovado");
                    }
                }
            }
        }
    }