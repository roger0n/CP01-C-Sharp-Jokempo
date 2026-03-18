using JokempoLib;
using System;
using System.Windows.Forms;


namespace JokempoWinForms
{
    public partial class Form1 : Form
    {
        private Jogo jogo = new Jogo();
        private Jogador jogadorAtual;
        private Rodada rodada;

        public Form1()
        {
            InitializeComponent();
        }

        // Criar / selecionar jogador
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite um nome válido!");
                return;
            }

            jogadorAtual = jogo.ObterOuCriarJogador(nome);
            MessageBox.Show($"Jogador {nome} pronto!");
        }

        // Jogadas
        private void buttonPedra_Click(object sender, EventArgs e)
        {
            Jogar(Opcao.Pedra);
        }

        private void buttonPapel_Click(object sender, EventArgs e)
        {
            Jogar(Opcao.Papel);
        }

        private void buttonTesoura_Click(object sender, EventArgs e)
        {
            Jogar(Opcao.Tesoura);
        }

        // Método central do jogo
        private void Jogar(Opcao escolha)
        {
            if (jogadorAtual == null)
            {
                MessageBox.Show("Crie um jogador primeiro!");
                return;
            }

            rodada = new Rodada();
            rodada.Jogar(escolha);

            var resultado = rodada.ObterResultado();

            jogo.AtualizarEstatisticas(jogadorAtual, resultado);

            lblResultado.Text = $"Resultado: {resultado}";
            lblPC.Text = $"Computador: {rodada.ComputadorEscolha}";
        }

        // Mostrar estatísticas
        private void btnEstatisticas_Click(object sender, EventArgs e)
        {
            lstEstatisticas.Items.Clear();

            foreach (var j in jogo.Jogadores)
            {
                lstEstatisticas.Items.Add(
                    $"{j.Nome} - V: {j.Estatisticas.Vitorias} | D: {j.Estatisticas.Derrotas} | E: {j.Estatisticas.Empates}"
                );
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}