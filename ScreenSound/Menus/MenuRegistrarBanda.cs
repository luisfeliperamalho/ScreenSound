using OpenAI_API;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public  override void Executar(Dictionary<string, Banda> bandasRegistradas)
    { 
        //override siginifica que a funcao Executar pode ser reescrita
        //base recupera a funcao escrita no objeto pai na funcao Executar
        base.Executar(bandasRegistradas); 
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);


        //var client = new OpenAIAPI("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");

        //var chat = client.Chat.CreateConversation();

        //chat.AppendSystemMessage($"Resuma a banda {nomeDaBanda} em 1 parágrafo. Adote um estilo informal.");

        //string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
        //banda.Resumo = resposta;
        //Console.WriteLine(resposta);


        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
