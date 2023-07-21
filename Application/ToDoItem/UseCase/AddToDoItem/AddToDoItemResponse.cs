using Domain.Item;

namespace Application.UseCase
{
    public class AddToDoItemResponse
    {
        public ToDoItem Item {  get; set; }
        public string[] Errors { get; set; }
    }
}
