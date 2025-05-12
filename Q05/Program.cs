string entrada;

InformarTexto();
var textoInvertido = InverterCaracteres(entrada);

Console.WriteLine($"O texto informado invertido é: {textoInvertido}.");
Console.WriteLine("Pressione uma tecla qualquer para encerrar a execução.");
Console.ReadKey();

void InformarTexto()
{
    Console.Write("Digite um texto ou uma palavra: ");
    do
    {
        entrada = Console.ReadLine();
        entrada = entrada.Trim();
        
        if (!string.IsNullOrEmpty(entrada))
        {
            Console.Clear();
            break;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um texto ou uma palavra.");
        }

    } while (string.IsNullOrEmpty(entrada));

}

string InverterCaracteres(string entrada){

    char[] caracteres = entrada.ToCharArray();
    char[] caracteresInvertidos = new char[caracteres.Length];

    int j = 0;

    for (int i = caracteres.Length - 1; i >= 0; i--)
    {
        caracteresInvertidos[j] = caracteres[i];
        j++;

    }

    var stringComCaracteresInvertidos = new string(caracteresInvertidos);

    return stringComCaracteresInvertidos;

}