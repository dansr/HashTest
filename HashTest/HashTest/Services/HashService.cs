using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HashTest.Services
{
    internal static class HashService
    {

        public static byte[] Hash(string source,string securityKey)
        {
            if(string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(source);
            }

            if (string.IsNullOrWhiteSpace(securityKey))
            {
                throw new ArgumentNullException(securityKey);
            }

            // accodo la chiave al source
            source += securityKey;

            try
            {
                byte[] sourceAscii = Encoding.ASCII.GetBytes(source);
                return new MD5CryptoServiceProvider().ComputeHash(sourceAscii);

            }
            catch (ObjectDisposedException)
            {
                // ComputeHash: Oggetto chiuso o eliminato
            }
            catch (EncoderFallbackException)
            {
                // ASCII: errore nella codifica
                throw;

            }
            catch(InvalidOperationException)
            {
                // CryptoServiceProvider: errore alla chiamata
                throw;
            }
            catch (Exception)
            {

                throw;
            }

            return null;
        }



    }
}
