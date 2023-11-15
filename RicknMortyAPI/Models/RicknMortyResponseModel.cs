using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCLI.RicknMortyAPI.Models
{
    public class RicknMortyResponseModel
    {
        public InfoModel info { get; set; } = new InfoModel();
        public List<PersonagemModel> results { get; set; } = new List<PersonagemModel>();
    }
}
