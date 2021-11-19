using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTest.Extensions
{
    /// <summary>
    /// Estensioni per il tipo bool
    /// </summary>
    public static class BoolExtensions
    {
        /// <summary>
        /// Conversione di un booleano nella sua rappresentazione testuale
        /// </summary>
        /// <param name="source">valore da convertire</param>
        /// <returns>string</returns>
        public static string ToYesNo(this bool source)
        {
            return source ? "Uguali" : "Diversi";
        }
    }
}
