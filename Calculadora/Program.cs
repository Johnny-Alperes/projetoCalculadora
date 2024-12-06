using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à Calculadora!");

            while (true) // Loop infinito para repetir as operações até o usuário escolher sair
            {
                // Pergunta a operação
                Console.WriteLine("\nEscolha a operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite 'exit' para encerrar a calculadora.");
                Console.Write("Digite o número correspondente à operação desejada: ");
                
                string operacao = Console.ReadLine()?.Trim().ToLower();

                // Verifica se o usuário deseja sair
                if (operacao == "0" || operacao == "exit")
                {
                    Console.WriteLine("Obrigado por usar a calculadora. Até mais!");
                    break;
                }

                // Verifica se a operação é válida
                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4")
                {
                    Console.WriteLine("Operação inválida. Tente novamente.");
                    continue;
                }

                // Solicita os números
                Console.Write("Digite o primeiro número: ");
                if (!double.TryParse(Console.ReadLine(), out double numero1))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    continue;
                }

                Console.Write("Digite o segundo número: ");
                if (!double.TryParse(Console.ReadLine(), out double numero2))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    continue;
                }

                // Realiza a operação
                double resultado = 0;
                switch (operacao)
                {
                    case "1":
                        resultado = numero1 + numero2;
                        Console.WriteLine($"Resultado da Adição: {numero1} + {numero2} = {resultado}");
                        break;
                    case "2":
                        resultado = numero1 - numero2;
                        Console.WriteLine($"Resultado da Subtração: {numero1} - {numero2} = {resultado}");
                        break;
                    case "3":
                        resultado = numero1 * numero2;
                        Console.WriteLine($"Resultado da Multiplicação: {numero1} * {numero2} = {resultado}");
                        break;
                    case "4":
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        }
                        else
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine($"Resultado da Divisão: {numero1} / {numero2} = {resultado}");
                        }
                        break;
                }
            }
        }
    }
}
