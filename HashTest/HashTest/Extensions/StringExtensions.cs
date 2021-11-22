using HashTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashTest.Extensions
{
    /// <summary>
    /// estensioni per il tipo string
    /// </summary>
    internal static class StringExtensions
    {
        /// <summary>
        /// valore Hash di una stringa
        /// </summary>
        /// <param name="source">stringa da </param>
        /// <returns>array di byte</returns>
        public static byte[] ToHash(this string source)
        {
            if(string.IsNullOrWhiteSpace(source))
            {
                return null;
            }

            try
            {
                return HashService.Hash(source,Config.HashKey);
            }
            catch (Exception)
            {
                return null;
            }
        }


        // solo scopo di demo
        public static string Repeat(this string source, int iterations)
        {
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < iterations; i++)
            {
                builder.Append(source);
            }

            return builder.ToString();
        }
    }
}
