using Domain.Item;

namespace Application.UseCase
{
    public class GetToDoItemsResponse
    {
        public ToDoItem[] Items { get; set; }
        public string[] Errors { get; set; }
    }
}
