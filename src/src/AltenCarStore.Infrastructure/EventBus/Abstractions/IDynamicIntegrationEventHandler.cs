using System.Threading.Tasks;

namespace AltenCarStore.Infrastructure.EventBus.Abstractions
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
