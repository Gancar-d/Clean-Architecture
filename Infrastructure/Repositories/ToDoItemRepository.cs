using Domain.Repository;
using Domain.Item;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace Persistence.Repositories
{
    public class ToDoItemRepository : DbContext, IToDoItemRepository
    {
        private DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=localhost;initial catalog=db_todo;Integrated Security=True;MultipleActiveResultSets=True;Encrypt=False");
        }


        public ToDoItemRepository()
        {
        }

        public void Add(ToDoItem item)
        {
            ToDoItems.Add(item);
            SaveChanges();
        }

        public ToDoItem Delete(int id)
        {
            var itemToRemove = ToDoItems.First(x => x.Id == id);
            ToDoItems.Remove(itemToRemove);
            SaveChanges();

            return itemToRemove;
        }

        public ToDoItem Get(int id)
        {
            return ToDoItems.First(x => x.Id == id);
        }

        public ToDoItem[] GetAll()
        {
            return ToDoItems.ToArray();
        }

        public void Update(ToDoItem item)
        {
            Update(item);
            SaveChanges();
        }
    }
}
