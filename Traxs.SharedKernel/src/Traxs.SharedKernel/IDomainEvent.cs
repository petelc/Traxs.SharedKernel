using MediatR;

namespace Traxs.SharedKernel;

public interface IDomainEvent : INotification
{
    DateTime DateOccurred { get; }
}
