namespace CustomerService.Core.Entity
{
    public partial class Customer
    {
        public string FullName
        {
            get
            {
                if (MiddleName != null)
                {
                    return $"{FirstName} {MiddleName} {LastName}";
                }
                return $"{FirstName} {LastName}";
            }
        }

        public bool IsCustomerLegalAge(DateTimeOffset currentDate,TimeZoneInfo timeZone)
        {
            var currentDateInTimeZone = TimeZoneInfo.ConvertTime(, timeZone);
        }
    }
}
