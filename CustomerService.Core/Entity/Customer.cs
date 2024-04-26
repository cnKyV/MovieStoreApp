using CustomerService.Core.Interfaces;

namespace CustomerService.Core.Entity
{
    public partial class Customer : BaseEntity, IBaseEntity
    {
        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public string? MiddleName { get; set; }

        public DateTimeOffset DateOfBirth { get; set; }

        public string? PlaceOfBirth { get; set; }

        public required Contact Contact { get; set; }

        public required Identity Identity { get; set; }

        public required Address Address { get; set; }
    }
}
