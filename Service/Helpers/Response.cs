using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Helpers
{
    public class Response<TResult>
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public TResult Value { get; set; }
    }

}
