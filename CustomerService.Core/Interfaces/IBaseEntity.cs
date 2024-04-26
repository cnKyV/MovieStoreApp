using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Core.Interfaces
{
    public interface IBaseEntity
    {
        Guid Id { get; init; }
        int FriendlyId { get; init; }
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset? LastModified { get; set; }
        string CreatedBy { get; set; }
        string? LastModifiedBy { get; set;}
    }
}
