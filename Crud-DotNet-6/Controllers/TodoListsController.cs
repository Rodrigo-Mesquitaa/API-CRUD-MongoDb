using Crud_DotNet_6.Domain;
using Crud_DotNet_6.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Crud_DotNet_6.Controllers
{ 

    [Route("api/[controller]")]
    [Controller]
    public class TodoListsController : Controller
    {

        private readonly TodoListService _todoListService;

        public TodoListsController(TodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] TodoList todoList)
        {
            var result = await _todoListService.Insert(todoList);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _todoListService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(string id)
        {
            var result = await _todoListService.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] TodoList todoList)
        {
            var result = await _todoListService.Update(todoList);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            await _todoListService.Remove(id);
            return Ok();
        }

    }
}