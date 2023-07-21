using Domain.Item;

namespace Domain.Repository
{
    public interface IToDoItemRepository
    {
        public ToDoItem[] GetAll();
        public ToDoItem Get(int id);
        public void Add(ToDoItem item);
        public void Update(ToDoItem item);
        public ToDoItem Delete(int id);
    }
}
