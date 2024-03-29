﻿namespace ShopEstre.Domain.Primitive
{
    public abstract class AggregeteRoot
    {
        private readonly List<DomainEvents> _domainEvents = new();
        public ICollection<DomainEvents> GetDomainEvents() => _domainEvents;
        protected void Raise(DomainEvents domainEvents)
        {
            _domainEvents.Add(domainEvents);
        }
    }
}
