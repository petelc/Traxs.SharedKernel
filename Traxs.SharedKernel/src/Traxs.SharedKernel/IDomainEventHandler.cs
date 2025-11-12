using MediatR;

namespace Traxs.SharedKernel;

public interface IDomainEventHandler<T> : INotificationHandler<T> where T : IDomainEvent
{
}
