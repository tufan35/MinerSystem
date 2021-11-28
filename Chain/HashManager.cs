using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Chain
{
    internal class HashManager
    {
        public string GetHash(string data)
        {

            var sha256 = new SHA256Managed();
            var hashBuild = new StringBuilder();

            var dataBytes = System.Text.Encoding.Unicode.GetBytes(data);
            var hash = sha256.ComputeHash(dataBytes);

            foreach (var h in hash)
            {
                hashBuild.Append($"{h:x2}");
            }
            return hashBuild.ToString();
        }
    }
}
