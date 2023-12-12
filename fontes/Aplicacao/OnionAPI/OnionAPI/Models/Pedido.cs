using Npgsql;
using OfficeOpenXml;
using OnionAPI.Data.Dtos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnionAPI.Models
{
    public class Pedido
    {
        [Key]
        [Required]
        public int IdPedido { get; set; }
        [Required]
        public int IdProduto { get; set; }
        [Required]
        public float NumeroPedido { get; set; }
        [Required]
        public DateTime DataEntrega { get; set; }
        [Required]
        public double Frete { get; set; }
        public string Regiao { get; set; }

        public async Task ConsultaDadosApi(string cep)
        {
            // Substitua a URL pela URL real da API que você deseja chamar
            string apiUrl = $"https://viacep.com.br/ws/{cep}/json/";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Faz a chamada à API e desserializa o JSON em um objeto
                    var res = await client.GetFromJsonAsync<ViaCepDTO>(apiUrl);

                    // Exibe os dados recebidos
                    Console.WriteLine($"Cep: {res.Cep}");
                    Console.WriteLine($"Logradouro: {res.Logradouro}");
                    Console.WriteLine($"Complemento: {res.Complemento}");
                    Console.WriteLine($"Bairro: {res.Bairro}");
                    Console.WriteLine($"Localidade: {res.Localidade}");
                    Console.WriteLine($"Uf: {res.Uf}");
                    Console.WriteLine($"Ibge: {res.Ibge}");
                    Console.WriteLine($"Gia: {res.Gia}");
                    Console.WriteLine($"Ddd: {res.Ddd}");
                    Console.WriteLine($"Siafi: {res.Siafi}");
                }
                catch (HttpRequestException ex)
                {
                    throw new HttpRequestException("Desculpe, houve um problema de comunicação e não foi possível recuperar seus dados.", ex);
                }
            }
        }
        public static double CalcularFretePorRegiao(double valorProduto, string regiao)
        {
            try
            {
                double percentual = 0.0;

                switch (regiao.ToLower())
                {
                    case "norte":
                    case "nordeste":
                        percentual = 0.3;
                        break;
                    case "centro-oeste":
                    case "sul":
                        percentual = 0.2;
                        break;
                    case "sudeste":
                        percentual = 0.1;
                        break;
                    case "saopaulocapital":
                        return 0.0;
                    default:
                        Console.WriteLine("Região não reconhecida. Verifique a digitação.");
                        return 0.0;
                }

                return valorProduto * percentual;
            }
            catch (Exception ex)
            {
                throw new Exception("Região não reconhecida. Verifique a digitação.", ex);
            }
        }

        public static int CalcularTempoEntregaPorRegiao(string regiao)
        {
            try
            {
                switch (regiao.ToLower())
                {
                    case "norte":
                    case "nordeste":
                        return 10; // 10 dias úteis
                    case "centro-oeste":
                    case "sul":
                        return 5;  // 5 dias úteis
                    case "sudeste":
                        return 1;  // 1 dia corrido
                    case "saopaulocapital":
                        return 0;  // Entrega no mesmo dia
                    default:
                        Console.WriteLine("Ops, não foi possível encontrar sua região. Edite seu registro e selecione uma região.");
                        return -1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ops, não foi possível encontrar sua região. Edite seu registro e selecione uma região.", ex);
            }

        }

        //public static List<Pedido> LerArquivosExcel(string caminhoArquivo)
        //{
        //    List<Pedido> pedidos = new List<Pedido>();

        //    FileInfo fileInfo = new FileInfo(caminhoArquivo);

        //    using (ExcelPackage package = new ExcelPackage(fileInfo))
        //    {
        //        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

        //        int rowCount = worksheet.Dimension.Rows;

        //        for (int row = 2; row <= rowCount; row++)
        //        {
        //            Pedido pedido = new Pedido
        //            {
        //                Numero = int.Parse(worksheet.Cells[row, 1].Value.ToString()),
        //                Produto = worksheet.Cells[row, 2].Value.ToString(),
        //                Quantidade = int.Parse(worksheet.Cells[row, 3].Value.ToString()),
        //                ValorUnitario = decimal.Parse(worksheet.Cells[row, 4].Value.ToString())
        //            };

        //            pedidos.Add(pedido);
        //        }
        //    }

        //    return pedidos;
        //}
    }
}
