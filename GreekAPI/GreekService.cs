using CSharpCLI.GreekAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCLI.GreekAPI
{
    public class GreekService
    {
        private const string BASE_URL = "https://anfi.tk/greekApi/person";

        public GreekService()
        {
        }

        public async Task GetAll()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync($"{BASE_URL}/GetAll");

            if (!string.IsNullOrEmpty(response))
            {
                PersonsList lista = JsonConvert.DeserializeObject<PersonsList>(response) ?? new();
                if (lista.persons.Count > 0)
                {
                    this.GerarArquivoNomes(lista);
                }
            }

        }

        private void GerarArquivoNomes(PersonsList pList)
        {
            string filePath = "GreekNames.txt";
            string diretorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string caminhoCompleto = Path.Combine(diretorio, filePath);

            if (File.Exists(caminhoCompleto))
                File.Delete(caminhoCompleto);


            using (StreamWriter sw = new StreamWriter(caminhoCompleto))
            {
                var filtro = pList.persons.Where(x => x.name.Length == 5).ToList();
                filtro.ForEach(item =>
                {
                    sw.WriteLine(item.name);
                });
            }
        }
    }
}
