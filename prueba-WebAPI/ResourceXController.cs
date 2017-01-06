using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace prueba_WebAPI
{
    public class ResourceXController : ApiController
    {
        public string Get()
        {
            return string.Format("Respuesta desde ResourceXController->Get()->{0}", System.DateTime.Now.ToLongDateString());
        }
    }
}