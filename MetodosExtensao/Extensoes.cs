using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCLI.MetodosExtensao
{
    public static class Extensoes
    {
        /// <summary>
        /// a ideia é ser um metodo generico que verifique mais do que apenas se nulo
        /// </summary>
        /// <param name="pVariavel"></param>
        /// <returns></returns>
        public static bool TemValor<T>(this T value) => value != null;

    }
}
