using Q03.Model;
using System.Reflection;
using System.Text.Json;

namespace Q03.Data
{
    public class FaturamentoData
    {
        public List<Faturamento> ObterFaturamentoMensal()
        {
            var jsonString = LerArquivo();

            if (string.IsNullOrEmpty(jsonString))
            {

                Console.WriteLine("Ocorreu um erro ao tentar recuperar um recurso.");
                Console.WriteLine("Pressione uma tecla qualquer para encerrar a execução.");

                Console.ReadKey();
                Environment.Exit(0);

            }

            return JsonSerializer.Deserialize<List<Faturamento>>(jsonString);

        }

        private string LerArquivo()
        {
            var nomeArquivo = "Q03.Resources.dados.json";
            using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(nomeArquivo);
            using StreamReader reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }

    }
}
