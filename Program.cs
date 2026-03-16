    using System;
    class Program
    {
        //Atividade 1: Escreva um programa que solicite ao usuário sua nota média (números inteiros de 0 a 10) e exiba se ele foi aprovado ou reprovado. O programa deve validar a entrada do usuário, garantindo que seja um número inteiro dentro do intervalo permitido. Se a entrada for inválida, o programa deve solicitar novamente até que uma entrada válida seja fornecida.
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

        //Atividade 2: Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
                string[] linguagens = { "C#", "Java", "JavaScript" };
                
        //Atividade 3: Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
                Console.WriteLine(linguagens[0]);

        }
    }