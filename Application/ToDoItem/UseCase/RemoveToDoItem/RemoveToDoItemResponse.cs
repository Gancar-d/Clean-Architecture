using Domain.Item;

namespace Application.UseCase
{ 
    public class RemoveToDoItemResponse
    {
        public ToDoItem DeletedItem { get; set; }
        public string[] Errors { get; set; }
    }
}
