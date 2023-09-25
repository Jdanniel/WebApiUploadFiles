using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiUpload.Wrappers
{
    public class Wrapper
    {

        public int StatusCode { get; set; }
        public dynamic Data { get; set; }
        public List<string> Messages { get; set; }

        public Wrapper(int statusCode, dynamic data, List<string> messages)
        {
            StatusCode = statusCode;
            Data = data;
            Messages = messages;
        }

    }
}
