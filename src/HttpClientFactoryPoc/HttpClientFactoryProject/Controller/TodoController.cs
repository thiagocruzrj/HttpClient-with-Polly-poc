using HttpClientFactoryProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace HttpClientFactoryProject.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("GetTodo/{id}")]
        public async Task<IActionResult> GetTodo(int id)
        {
            return Ok(await _todoService.GetTodo(id));
        }
    }
}