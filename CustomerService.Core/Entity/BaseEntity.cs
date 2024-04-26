using CustomerService.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Core.Entity
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; init; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FriendlyId { get; init; }
        public required DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? LastModified { get; set; }
        public required string CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }

        public BaseEntity()
        {
            if (Id == Guid.Empty) 
            { 
                Id = Guid.NewGuid(); 
            }
        }
    }
}
