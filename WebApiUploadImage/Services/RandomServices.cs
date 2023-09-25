using System;
using System.Linq;
using WebApiUpload.Interfaces;

namespace WebApiUpload.Services
{
    public class RandomServices: IRandomServices
    {
        private readonly Random random = new Random();

        public string String(int length)
        {
            const string chars = "A0B1C2D3E4F5G6H7I8J9K0L1M2N3O4P5Q6R7S8T9U0V1W2X3Y4Z50123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
