using ScreenSound.Menus;
using ScreenSound.Models;

internal class Program
{
    private static void Main(string[] args)
    {

        Banda gusttavoLima = new("Gusttavo Lima");
        gusttavoLima.AdicionarNota(new Avaliacao(10));
        gusttavoLima.AdicionarNota(new Avaliacao(6));
        gusttavoLima.AdicionarNota(new Avaliacao(4));

        Banda henriqueEJuliano = new("Henrique e Juliano");
        henriqueEJuliano.AdicionarNota(new Avaliacao(9));
        henriqueEJuliano.AdicionarNota(new Avaliacao(5));
        henriqueEJuliano.AdicionarNota(new Avaliacao(7));

        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(gusttavoLima.Nome, gusttavoLima);
        bandasRegistradas.Add(henriqueEJuliano.Nome, henriqueEJuliano);

        Dictionary<int, Menu> opcoes = new();

        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuExibirBandasRegistradas());
        opcoes.Add(4, new MenuAvaliarBanda());
        opcoes.Add(5, new MenuAvaliarAlbum());
        opcoes.Add(6, new MenuExibirDetalhes());
        opcoes.Add(-1, new MenuSair());


        void ExibirLogo()
        {
            Console.WriteLine(@"

            ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
            ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
            ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
            ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
            ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
            ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
            ");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para avaliar um álbum");
            Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
                menuASerExibido.Executar(bandasRegistradas);
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }

        ExibirOpcoesDoMenu();

    }
}