using Microsoft.AspNetCore.Mvc;

namespace EverisStore.API.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController:ControllerBase
    {
        [Route("/error")]
        public IActionResult ErrorLocal() => Problem();
    }
}