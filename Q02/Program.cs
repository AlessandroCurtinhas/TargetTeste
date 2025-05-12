int numero = 0;

InformarNumero();
ExibirDados(numero);

void InformarNumero()
{
    Console.Write("Digite um número inteiro: ");
    do
    {
        var entrada = int.TryParse(Console.ReadLine(), out numero);

        if (entrada && numero >= 0)
        { 
            Console.Clear(); 
            break; 
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro positivo.");
        }

    } while (true);

}
void ExibirDados(int numero)
{
    var retorno = CalcularFibonacci(numero);
    var pertenceSequencia = EhDaSequencia(retorno, numero);

    if (pertenceSequencia) Console.WriteLine($"O número {numero} está na sequência fibonacci.");
    else Console.WriteLine($"O número {numero} não está na sequência fibonacci.");

    Console.WriteLine("Pressione uma tecla qualquer para encerrar a execução.");
    Console.ReadKey();

}
List<int> CalcularFibonacci(int numero)
{
    var sequenciaFibonaci = new List<int> {0};

    int anterior = 0;
    int atual = 1;
    int proximo = 0;

    while (atual <= numero)
    {
        proximo = anterior + atual;
        anterior = atual;
        atual = proximo;

        sequenciaFibonaci.Add(atual);
    }

    return sequenciaFibonaci;

}
bool EhDaSequencia (List<int> sequencia, int numero)
{   
     if(!sequencia.Exists(x => x.Equals(numero))) return false;

     return true;
}