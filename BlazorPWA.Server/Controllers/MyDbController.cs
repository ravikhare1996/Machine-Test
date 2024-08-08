using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using XpertStudio.Common.Functions;
using XpertStudio.Framework.Domain;
using XS.ASPNetCore.Server.Controllers;

namespace BlazorPWA.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyDbController:CommonDBController
    {
        protected readonly ICommonDBMethods _service;
        public MyDbController(ICommonDBMethods service):base(service) 
        {
            _service = service;
        }

        [HttpGet]
        [Route("getSingleValue")]
        public override async Task<IActionResult> getSingleValue([FromQuery] string? Query)
        {
            try
            {
                var data = await _service.getSingleValue(Query);
                var jsonData = JsonConvert.SerializeObject(data);
                return Ok(jsonData);
            }
            catch (Exception ex)
            {
                Serilog.Log.Fatal(XpertCommonFunctions.GetInnerException(ex));
                throw;
            }
            
        }
    }
}
