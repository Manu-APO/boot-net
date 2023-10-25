namespace Domain.Entities;

using Domain.Common;

public class ProductBrand : BaseAuditableEntity<Guid>
{
    public string Name { get; set; }
}