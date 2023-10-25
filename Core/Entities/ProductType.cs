namespace Domain.Entities;

using Domain.Common;

public class ProductType : BaseAuditableEntity<Guid>
{
    public string Name { get; set; }
}