using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;

namespace ADSProject.Utilities
{
    public class JsonHttpStatusResult: JsonResult
    {
        private readonly HttpStatusCode httpStatusCode;

        public JsonHttpStatusResult(object data, HttpStatusCode httpStatus)
        {
            Data = data;
            httpStatusCode = httpStatus;
            JsonRequestBehavior = JsonRequestBehavior.AllowGet;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.RequestContext.HttpContext.Response.StatusCode = (int)httpStatusCode;
            base.ExecuteResult(context);
        }
    }
}