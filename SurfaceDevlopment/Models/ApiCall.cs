using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurfaceDevlopment.Models
{
    public class ApiCall
    {
        public string Error { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}
