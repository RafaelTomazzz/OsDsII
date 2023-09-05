using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OsDsII.api.Http;

namespace OsDsII.api.Exceptions
{
    public class BaseExceptions : Exception
    {
        private HttpErrorRespome HttpResponse { get; set; }
        private HttpStatusCode StatusCode { get; set; }

        public BaseExceptions(string errorCode, string message, statusCode, timestamp)
        {
            StatusCode = httpStatusCode;
            HttpResponse new HttpErrorRespome(errorCode, message, statusCode, timestamp);
        }
        
        public IActionResult GetResponse()
        {
            return new ContentResult
            {
                StatusCode = ((int)StatusCode),
                Content = JsonConvert.SerializeObject(
                    new JsonSerializerSetting
                    {
                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                    }
                    )
            };
        }
    }
}