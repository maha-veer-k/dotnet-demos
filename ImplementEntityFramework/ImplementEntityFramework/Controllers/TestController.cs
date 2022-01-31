using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImplementEntityFramework.Controllers
{
    
    [ApiController]
    public class TestController : ControllerBase
    {
        [Route("/api/get")]
        public string Get()
        {
            return "hello from test";
        }
    }
}
