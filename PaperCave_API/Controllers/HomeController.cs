using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace PaperCave_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public HomeController(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        [Route("/Get")]
        public HttpResponse Get()
        {
                   
        }
    }
}