var faturamentoMensalPorEstado = new Dictionary<string, double>
{
    { "SP", 67836.43 },
    { "MG", 29229.88 },
    { "RJ", 36678.66 }, 
    { "ES", 27165.48 },
    { "Outros", 19849.53 }
};

CacularPercentual(faturamentoMensalPorEstado);

void CacularPercentual(Dictionary<string, double> faturamentoMensalPorEstado)
{
    if (faturamentoMensalPorEstado == null || faturamentoMensalPorEstado.Count == 0) 
    {
        Console.WriteLine("Não há dados para calcular");
        Console.WriteLine("Pressione uma tecla qualquer para encerrar a execução.");
        Console.ReadKey();
        Environment.Exit(0);
    } 

    double total = 0;
    var faturamentoMensalPorEstadoOrdenado = faturamentoMensalPorEstado.OrderByDescending(x => x.Value);

    foreach (var item in faturamentoMensalPorEstadoOrdenado)
    {
        total += item.Value;
    }

    foreach (var item in faturamentoMensalPorEstadoOrdenado)
    {
        var percentual = (item.Value / total) * 100;
        Console.WriteLine($"Estado: {item.Key} - Percentual de participação no faturamento: {percentual.ToString("F2")}%.");
    }
}