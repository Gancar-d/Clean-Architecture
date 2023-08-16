using Application.UseCase;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchTest.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoItemsController : ControllerBase
    {
        private readonly GetToDoItemsUseCase _getToDoItems;
        private readonly AddToDoItemUseCase _addToDoItems;
        private readonly RemoveToDoItemUseCase _removeTodoItem;

        public ToDoItemsController(GetToDoItemsUseCase getToDoItems,
            AddToDoItemUseCase addToDoItem,
            RemoveToDoItemUseCase removeTodoItem)
        {
            _getToDoItems = getToDoItems;
            _addToDoItems = addToDoItem;
            _removeTodoItem = removeTodoItem;
        }

        [HttpGet(Name = "GetToDoItems")]
        public GetToDoItemsResponse Get()
        {
            var response = new GetToDoItemsResponse();
            _getToDoItems.Execute(new GetToDoItemsRequest(), response);

            return response;
        }

        [HttpPost(Name = "AddToDoItem")]
        public AddToDoItemResponse Add(AddToDoItemRequest request)
        {
            var response = new AddToDoItemResponse();
            _addToDoItems.Execute(request, response);

            return response;
        }

        [HttpDelete(Name = "DeleteToDoItem")]
        public RemoveToDoItemResponse Delete(RemoveToDoItemRequest request)
        {
            var response = new RemoveToDoItemResponse();
            _removeTodoItem.Execute(request, response);

            return response;
        }
    }
}