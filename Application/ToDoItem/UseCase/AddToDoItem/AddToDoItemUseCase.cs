using Domain.Item;
using Domain.Repository;

namespace Application.UseCase
{
    public class AddToDoItemUseCase
    {
        private readonly IToDoItemRepository _itemRepository;

        public AddToDoItemUseCase(IToDoItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void Execute(AddToDoItemRequest request, AddToDoItemResponse response)
        {
            var item = new ToDoItem
            {
                Description = request.description,
                IsDone = false
            };

            _itemRepository.Add(item);
            response.Item = item;
        }

    }
}
