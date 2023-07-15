using System.ComponentModel.DataAnnotations;

namespace ShylynPerfume.Data.Entities
{
    public interface IEntityBase
    {
        [Key]
        Guid Id { get; set; }

        bool IsDeleted { get; set; }

        Guid InsertedById { get; set; }

        DateTime InsertedAt { get; set; }

        Guid UpdatedById { get; set; }

        DateTime UpdatedAt { get; set; }
    }
}
