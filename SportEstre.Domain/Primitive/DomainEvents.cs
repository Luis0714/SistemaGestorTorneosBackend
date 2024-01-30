using MediatR;

namespace ShopEstre.Domain.Primitive
{
    public record DomainEvents(Guid Id) : INotification;
}
