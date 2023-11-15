using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCLI.RicknMortyAPI.Models
{
    public class InfoModel
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; } = "";
        public string prev { get; set; } = "";

    }
}
