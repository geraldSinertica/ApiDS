using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace DataStore.Models
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            this.Data = null;
            Message = string.Empty;
            StatusCode = (int)HttpStatusCode.OK;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
    }
}