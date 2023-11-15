using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCLI.RicknMortyAPI
{
    public class PersonagemModel
    {
        public int id { get; set; }
        public string name { get; set; } = "";
        public string status { get; set; } = "";
        public string species { get; set; } = "";
        public string type { get; set; } = "";
        public string gender { get; set; } = "";
        public OriginModel origin { get; set; } = new();
        public LocationModel location { get; set; } = new();
        /// <summary>
        /// url da rota para a imagem
        /// </summary>
        public string image { get; set; } = "";
        public List<string> episodes { get; set; } = new();
    }

    public class OriginModel
    {
        public string name { get; set; } = "";
        public string url { get; set; } = "";
    }

    public class LocationModel
    {
        public string name { get; set; } = "";
        public string url { get; set; } = "";
    }
}
