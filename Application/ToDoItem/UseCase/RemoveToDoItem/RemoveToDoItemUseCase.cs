using Domain.Repository;

namespace Application.UseCase
{
    public class RemoveToDoItemUseCase
    {
        private readonly IToDoItemRepository _repository;
        public RemoveToDoItemUseCase(IToDoItemRepository toDoItemRepository)
        {
            _repository = toDoItemRepository;
        }

        public void Execute(RemoveToDoItemRequest request, RemoveToDoItemResponse response)
        {
            var errors = new List<string>();
            try
            {
                var deletedItem = _repository.Delete(request.ItemId);
                response.DeletedItem = deletedItem;
            }
            catch(Exception ex)
            {
                errors.Add($"RemoveToDoItem: Failed to remove item with Id : {request.ItemId}");
                errors.Add(ex.Message);
                response.Errors = errors.ToArray();
            }   
        }
    }
}
