using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShylynPerfume.Data.Entities
{
    [Index(nameof(IsDeleted))]
    public class EntityBase : IEntityBase
    {
        [Key]
        public Guid Id { get; set; }

        //[Logger(false)]
        public bool IsDeleted { get; set; }

        //[Logger(false)]
        public Guid InsertedById { get; set; }

        [ForeignKey("InsertedById")]
        public virtual ApplicationUser InsertedBy { get; set; }

        //[Logger(false)]
        public DateTime InsertedAt { get; set; }

        //[Logger(false)]
        public Guid UpdatedById { get; set; }

        [ForeignKey("UpdatedById")]
        public virtual ApplicationUser UpdatedBy { get; set; }

        //[Logger(false)]
        public DateTime UpdatedAt { get; set; }
    }
}
