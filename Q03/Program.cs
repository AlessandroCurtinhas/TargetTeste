using Q03.Data;
using Q03.Model;

FaturamentoData faturamentoMensal = new FaturamentoData();
var faturamento = faturamentoMensal.ObterFaturamentoMensal();

if (faturamento == null || faturamento.Count == 0)
{
    Console.WriteLine("Não há dados para calcular.");
    Console.WriteLine("Pressione uma tecla qualquer para encerrar a execução.");

    Console.ReadKey();
    Environment.Exit(0);
}

ExibirDados();

void ExibirDados(){

    var menorFaturamento = MenorFaturamentoNoMês(faturamento);
    var maiorFaturamento = MaiorFaturamentoNoMês(faturamento);
    var numerodedias = CalculaNumeroDeDiasComFaturamentoSuperiorMensal(faturamento);

    Console.WriteLine($"O menor faturamento ocorrido em um dia do mês foi: R$ {menorFaturamento.valor.ToString("F2")}.");
    Console.WriteLine($"O maior faturamento ocorrido em um dia do mês foi: R$ {maiorFaturamento.valor.ToString("F2")}.");
    Console.WriteLine($"A quantidade de dias em que o faturamento diário superou a média mensal: {numerodedias} dia(s).");

    Console.WriteLine("--");
    Console.WriteLine("Pressione uma tecla qualquer para encerrar a execução.");
    Console.ReadKey();
}
int CalculaNumeroDeDiasComFaturamentoSuperiorMensal(List<Faturamento> faturamento)
{
    int quantidadeDeDiasFaturamentoAcimaMedia = 0;
    var faturamentoComValores = faturamento.Where(x => x.valor != 0);
    
    var mediaMensal = faturamentoComValores.Average(x => x.valor);

    foreach (var item in faturamentoComValores)
    {
        if (item.valor > mediaMensal) quantidadeDeDiasFaturamentoAcimaMedia++;

    }

    return quantidadeDeDiasFaturamentoAcimaMedia;

}

Faturamento MenorFaturamentoNoMês(List<Faturamento> faturamento)
{

    return faturamento.OrderBy(x => x.valor)
                      .Where(x => x.valor != 0)
                      .FirstOrDefault();

}

Faturamento MaiorFaturamentoNoMês(List<Faturamento> faturamento)
{

    return faturamento.OrderByDescending(x => x.valor)
                      .Where(x => x.valor != 0)
                      .FirstOrDefault();

}



