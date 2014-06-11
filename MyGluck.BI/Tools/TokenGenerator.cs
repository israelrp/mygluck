using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGluck.BI.Tools
{
    public static class TokenGenerator
    {
        public static string GenerateTokenTime()
        {
            string result = "";
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = new Guid().ToByteArray();
            result = Convert.ToBase64String(time.Concat(key).ToArray());
            return result;
        }

        public static bool IsValidTokenTime(string token)
        {
            bool result = false;
            byte[] data = Convert.FromBase64String(token);
            DateTime creationDate = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
            if (creationDate > DateTime.UtcNow.AddHours(24))
            {
                result = true;
            }
            return result;
        }
    }
}
