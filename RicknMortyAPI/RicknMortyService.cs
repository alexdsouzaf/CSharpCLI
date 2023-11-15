using CSharpCLI.MetodosExtensao;
using CSharpCLI.RicknMortyAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCLI.RicknMortyAPI
{
    /// <summary>
    /// https://rickandmortyapi.com/
    /// </summary>
    public class RicknMortyService
    {
        private const string URL_BASE = "https://rickandmortyapi.com/api/";
        private const string ROTA_PERSONAGEM = "character";
        
        public RicknMortyService()
        {
            
        }

        public async Task GetAllPersonagens()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(URL_BASE + ROTA_PERSONAGEM);

            if (response.TemValor())
            {
                var responseModel = JsonConvert.DeserializeObject<RicknMortyResponseModel>(response);
                if (responseModel.TemValor())
                {
                    Console.WriteLine(responseModel.results.FirstOrDefault()!.name);
                }
            }
        }

        public async Task GetPersonagemPorId(int pId)
        {
            var cliente = new HttpClient();
            var response = await cliente.GetStringAsync($"{URL_BASE}{ROTA_PERSONAGEM}/{pId}");

            if (response.TemValor())
            {
                var responseModel = JsonConvert.DeserializeObject<PersonagemModel>(response);
                if (responseModel.TemValor())
                {
                    Console.WriteLine($"{responseModel.id} - {responseModel.name} / {responseModel.status}");
                }
            }
        }
    }
}
