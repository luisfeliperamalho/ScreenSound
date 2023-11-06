using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {      
        //override siginifica que a funcao Executar pode ser reescrita
       
        Console.WriteLine("Tchau tchau :)");
    }
}
