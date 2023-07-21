using Domain.Repository;

namespace Application.UseCase
{
    public class GetToDoItemsUseCase
    {
        private readonly IToDoItemRepository _itemRepository;

        public GetToDoItemsUseCase(IToDoItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void Execute(GetToDoItemsRequest request, GetToDoItemsResponse response)
        {
            response.Items = _itemRepository.GetAll();
        }
    }
}
