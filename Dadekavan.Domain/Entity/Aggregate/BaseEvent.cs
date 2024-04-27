using MediatR;

namespace Dadekavan.Domain.Entity.Aggregate
{
    public class BaseEvent : INotification
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
