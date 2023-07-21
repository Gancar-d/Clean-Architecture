using Application.UseCase;
using Domain.Repository;
using Persistence.Repositories;

namespace Application
{
    public static class ServiceCollectionExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IToDoItemRepository, ToDoItemRepository>();
        }

        public static void AddUseCases(this IServiceCollection services)
        {
            services.AddTransient<AddToDoItemUseCase>();
            services.AddTransient<GetToDoItemsUseCase>();
            services.AddTransient<RemoveToDoItemUseCase>();
        }
    }
}
