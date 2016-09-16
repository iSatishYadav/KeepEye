using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeepEye.Models
{
    public class JsonResponse
    {
        public IEnumerable<Result> Result { get; set; }
        public string Uri { get; set; }
        public string Response_Code { get; set; }
    }
}