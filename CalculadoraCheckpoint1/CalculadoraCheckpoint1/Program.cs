using System;

class Calculadora
{
    static void Main(string[] args)
    {
        int Opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine(" Calculadora (Adição / Subtração / Multiplicação / Divisão)");
            Console.WriteLine("========================================");
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.Write("\nDigite sua opção: ");

            string EntradaOpcao = Console.ReadLine();

            if (!int.TryParse(EntradaOpcao, out Opcao))
            {
                Console.WriteLine("\nOpção inválida! Pressione Enter para tentar novamente.");
                Console.ReadLine();
                continue;
            }

            if (Opcao == 5)
            {
                Console.WriteLine("\nSaindo da calculadora. Até logo!");
                break;
            }

            if (Opcao < 1 || Opcao > 5)
            {
                Console.WriteLine("\nOpção inválida! Pressione Enter para tentar novamente.");
                Console.ReadLine();
                continue;
            }

            Console.Write("\nDigite o primeiro número: ");
            string EntradaPrimeiroNumero = Console.ReadLine();

            Console.Write("Digite o segundo número: ");
            string EntradaSegundoNumero = Console.ReadLine();

            if (!double.TryParse(EntradaPrimeiroNumero, out double PrimeiroNumero) ||
                !double.TryParse(EntradaSegundoNumero, out double SegundoNumero))
            {
                Console.WriteLine("\nEntrada inválida! Por favor, digite apenas números.");
                Console.WriteLine("Pressione Enter para continuar.");
                Console.ReadLine();
                continue;
            }

            double Resultado;

            switch (Opcao)
            {
                case 1:
                    Resultado = PrimeiroNumero + SegundoNumero;
                    Console.WriteLine($"\nResultado: {PrimeiroNumero} + {SegundoNumero} = {Resultado}");
                    break;

                case 2:
                    Resultado = PrimeiroNumero - SegundoNumero;
                    Console.WriteLine($"\nResultado: {PrimeiroNumero} - {SegundoNumero} = {Resultado}");
                    break;

                case 3:
                    Resultado = PrimeiroNumero * SegundoNumero;
                    Console.WriteLine($"\nResultado: {PrimeiroNumero} * {SegundoNumero} = {Resultado}");
                    break;

                case 4:
                    if (SegundoNumero == 0)
                    {
                        Console.WriteLine("\nErro: Divisão por zero não é permitida!");
                    }
                    else
                    {
                        Resultado = PrimeiroNumero / SegundoNumero;
                        Console.WriteLine($"\nResultado: {PrimeiroNumero} / {SegundoNumero} = {Resultado}");
                    }
                    break;
            }

            Console.WriteLine("\nPressione Enter para realizar outra operação.");
            Console.ReadLine();

        } while (true);
    }
}