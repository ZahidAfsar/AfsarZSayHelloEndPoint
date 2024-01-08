using Microsoft.AspNetCore.Mvc;

namespace AfsarZSayHelloEndPoint.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        public List<string> greeting = new();

        [HttpPost]
        [Route("NameReturn/{user}")]

        public List<string> NameReturn(string user)
        {
            greeting.Add($"Hello, {user}");
            return greeting;
        }
    
    }
    
