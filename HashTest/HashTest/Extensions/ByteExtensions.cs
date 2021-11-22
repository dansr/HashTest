using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashTest.Extensions
{
    /// <summary>
    /// Estensioni per il tipo byte
    /// </summary>
    public static class ByteExtensions
    {
        /// <summary>
        /// comparazione tra due array di byte
        /// </summary>
        /// <param name="source"></param>
        /// <param name="compareWith"></param>
        /// <returns></returns>
        public static bool Compare(this byte[] source, byte[] compareWith)
        {
            if (source == null || compareWith == null)
            {
                // almeno uno dei parametri è null. è possibile generare l'eccezzione ArgumentException
                return false;
            }

            if (source.Length != compareWith.Length)
            {
                // i parametri hanno lunghezza diversa
                return false;
            }

            if (source.Length == 0 || compareWith.Length == 0)
            {
                // almeno uno dei parametri è un array vuoto
                return false;
            }

            // comparazione tramite equità strutturale
            return StructuralComparisons.
                StructuralEqualityComparer.Equals(source, compareWith);
        }

        public static string ToMD5(this byte[] source)
        {
            if (source == null || !source.Any())
            {
                return null;
            }

            using (var md5 = MD5.Create())
            {
                return BitConverter.ToString(md5.ComputeHash(source)).Replace("-","");
            }
        }
    }
}
