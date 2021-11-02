using System;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;

namespace Library
{
    public class FunctionLibrary
    {
        //This operation won't be shown on the swagger UI
        //but it will be available on http://localhost:7071/api/FunctionLibrary
        [OpenApiOperation("FunctionLibrary")]
        [Function("FunctionLibrary")]
        public static HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
            response.WriteString("Response from library project");

            return response;
        }
    }
}
