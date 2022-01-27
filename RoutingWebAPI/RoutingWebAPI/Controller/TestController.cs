using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingWebAPI.Controller
{
    //[Route("api/[controller]")]
    [ApiController]

    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {
        [Route("~/get")]
        //[Route("~/Get")]
        public string Get()
        {
            return "Hello from /Test/Get";
        }
        
        [Route("~/getall")]

        public string GetAll()
        {
            return "Hello from Test/GetAll";
        }
        
        [Route("~/maha")]
        public string Maha()
        {
            return "hello from Maha (/maha)";
        }

        [Route("{id}")]
        public string GetById(int id)
        {
            return "Hello : " + id;
        }

        public string GetByIdQuery(int id)
        {
            return "Hello : " + id;
        }

        [Route("{id:int:min(10):max(30)}")]
        public string GetByIdConstraint(int id)
        {
            return "Hello : " + id;
        }

        [Route("{name}")]
        public string GetByName(string name)
        {
            return "hello : " + name;
        }

        [Route("{name:length(8)}")]
        public string GetByNameConstraint(string name)
        {
            return "hello : " + name;
        }

        [Route("~/search")]
        public string SearchBook(int id, string name, int authorId, string authorName, int price)
        {
            return "id : " + id + " || name : " + name + " || authorId : " + authorId + " || authorName : " + authorName + " || price : " + price;
        }

    }
}
