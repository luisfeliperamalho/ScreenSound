using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExibirBandasRegistradas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //override siginifica que a funcao Executar pode ser reescrita
        //base recupera a funcao escrita no objeto pai na funcao Executar
        base.Executar(bandasRegistradas);  
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        
    }
}
