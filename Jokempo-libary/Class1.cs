namespace JokempoLib
{
    // Enum para representar Pedra, Papel e Tesoura
    public enum Opcao
    {
        Pedra = 0,
        Papel = 1,
        Tesoura = 2
    }

    // Enum para representar o resultado da rodada
    public enum ResultadoRodada
    {
        Vitoria,
        Derrota,
        Empate
    }

    // Classe para armazenar estatísticas
    public class Estatisticas
    {
        public int Vitorias { get; private set; }
        public int Derrotas { get; private set; }
        public int Empates { get; private set; }

        public void RegistrarVitoria() => Vitorias++;
        public void RegistrarDerrota() => Derrotas++;
        public void RegistrarEmpate() => Empates++;
    }

    // Classe que representa um jogador
    public class Jogador
    {
        public string Nome { get; set; }
        public Estatisticas Estatisticas { get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
            Estatisticas = new Estatisticas();
        }
    }

    // Classe responsável por uma rodada
    public class Rodada
    {
        private static Random random = new Random();

        public Opcao JogadorEscolha { get; private set; }
        public Opcao ComputadorEscolha { get; private set; }

        public void Jogar(Opcao escolhaJogador)
        {
            JogadorEscolha = escolhaJogador;
            ComputadorEscolha = (Opcao)random.Next(3);
        }

        public ResultadoRodada ObterResultado()
        {
            if (JogadorEscolha == ComputadorEscolha)
                return ResultadoRodada.Empate;

            if (
                (JogadorEscolha == Opcao.Pedra && ComputadorEscolha == Opcao.Tesoura)
                || (JogadorEscolha == Opcao.Papel && ComputadorEscolha == Opcao.Pedra)
                || (JogadorEscolha == Opcao.Tesoura && ComputadorEscolha == Opcao.Papel)
            )
                return ResultadoRodada.Vitoria;

            return ResultadoRodada.Derrota;
        }
    }

    // Classe principal que controla o jogo
    public class Jogo
    {
        public List<Jogador> Jogadores { get; private set; } = new List<Jogador>();

        public Jogador ObterOuCriarJogador(string nome)
        {
            var jogador = Jogadores.Find(j => j.Nome == nome);

            if (jogador == null)
            {
                jogador = new Jogador(nome);
                Jogadores.Add(jogador);
            }

            return jogador;
        }

        public void AtualizarEstatisticas(Jogador jogador, ResultadoRodada resultado)
        {
            if (resultado == ResultadoRodada.Vitoria)
                jogador.Estatisticas.RegistrarVitoria();
            else if (resultado == ResultadoRodada.Derrota)
                jogador.Estatisticas.RegistrarDerrota();
            else
                jogador.Estatisticas.RegistrarEmpate();
        }
    }
}