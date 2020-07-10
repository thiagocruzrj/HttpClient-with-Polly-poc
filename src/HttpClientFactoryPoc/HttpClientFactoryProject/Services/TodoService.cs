using HttpClientFactoryProject.Models;
using System.Threading.Tasks;

namespace HttpClientFactoryProject.Services
{
    public class TodoService : ITodoService
    {
        public async Task<TodoModel> GetTodo(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}