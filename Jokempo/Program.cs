using System;
using System.Collections.Generic;

class Program
{
    static Random random = new Random();
    enum Opcao
    {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2
    }

    static Dictionary<string, (int vitorias, int derrotas, int empates)> estatisticas
        = new Dictionary<string, (int, int, int)>();

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Olá! Vamos jogar Jokempo?");

        string jogador = LerNomeJogador();

        Console.WriteLine($"\nQuer jogar jokempo {jogador}?");
        Console.WriteLine("1 - Sim | 0 - Não");

        char continuar = Console.ReadKey().KeyChar;

        while (continuar == '1')
        {
            JogarPartida(jogador);

            Console.WriteLine("\n");
            Console.WriteLine("1 - Jogar novamente");
            Console.WriteLine("2 - Trocar de jogador");
            Console.WriteLine("3 - Ver estatísticas");
            Console.WriteLine("0 - Sair");

            char escolha = Console.ReadKey().KeyChar;

            if (escolha == '1')
            {
                continuar = '1';
            }
            else if (escolha == '2')
            {
                jogador = LerNomeJogador();
                continuar = '1';
            }
            else if (escolha == '3')
            {
                MostrarEstatisticas();
                continuar = PerguntarContinuar();
            }
            else
            {
                continuar = '0';
            }
        }

        Console.WriteLine("\nTchau! Até a próxima!");
    }

    static string LerNomeJogador()
    {
        Console.WriteLine("\nDigite o nome do jogador:");

        string nome = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido. Digite novamente:");
            nome = Console.ReadLine();
        }

        if (!estatisticas.ContainsKey(nome))
            estatisticas[nome] = (0, 0, 0);

        return nome;
    }

    static char PerguntarContinuar()
    {
        Console.WriteLine("\nQuer jogar novamente?");
        Console.WriteLine("1 - Sim | 0 - Não");

        char resp = Console.ReadKey().KeyChar;

        while (resp != '1' && resp != '0')
        {
            Console.WriteLine("\nEntrada inválida. Digite 1 ou 0.");
            resp = Console.ReadKey().KeyChar;
        }

        return resp;
    }

    static void MostrarOpcoes()
    {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("0 - Pedra ✊");
        Console.WriteLine("1 - Papel ✋");
        Console.WriteLine("2 - Tesoura ✌");
    }

    static void JogarPartida(string jogador)
    {
        MostrarOpcoes();

        char entrada = Console.ReadKey().KeyChar;

        while (entrada != '0' && entrada != '1' && entrada != '2')
        {
            Console.WriteLine("\nOpção inválida. Escolha 0, 1 ou 2.");
            entrada = Console.ReadKey().KeyChar;
        }

        Opcao jogadorEscolha = (Opcao)int.Parse(entrada.ToString());
        Opcao pcEscolha = (Opcao)random.Next(3);

        Console.WriteLine($"\nVocê escolheu {jogadorEscolha}");
        Console.WriteLine($"Eu escolhi {pcEscolha}");

        if (jogadorEscolha == pcEscolha)
        {
            Console.WriteLine($"Deu empate {jogador}!!!");

            estatisticas[jogador] = (
                estatisticas[jogador].vitorias,
                estatisticas[jogador].derrotas,
                estatisticas[jogador].empates + 1
            );
        }
        else if (
            (jogadorEscolha == Opcao.Pedra && pcEscolha == Opcao.Tesoura) ||
            (jogadorEscolha == Opcao.Papel && pcEscolha == Opcao.Pedra) ||
            (jogadorEscolha == Opcao.Tesoura && pcEscolha == Opcao.Papel)
        )
        {
            Console.WriteLine($"Parabéns! Você venceu {jogador}.");

            estatisticas[jogador] = (
                estatisticas[jogador].vitorias + 1,
                estatisticas[jogador].derrotas,
                estatisticas[jogador].empates
            );
        }
        else
        {
            Console.WriteLine($"Derrota, Você perdeu {jogador}");

            estatisticas[jogador] = (
                estatisticas[jogador].vitorias,
                estatisticas[jogador].derrotas + 1,
                estatisticas[jogador].empates
            );
        }
    }

    static void MostrarEstatisticas()
    {
        Console.WriteLine("\n--- Estatísticas dos jogadores ---");

        foreach (var jogador in estatisticas)
        {
            Console.WriteLine(
                $"{jogador.Key} -> Vitórias: {jogador.Value.vitorias}, " +
                $"Derrotas: {jogador.Value.derrotas}, " +
                $"Empates: {jogador.Value.empates}"
            );
        }
    }
}