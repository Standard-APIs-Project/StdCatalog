using Domain.Entities;

namespace StandardAPIs.DomainBase
{
    public abstract class DomainEntityBase : IEntity
    {
        public Guid Id { get; set; }        
    }
}