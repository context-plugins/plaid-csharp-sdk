using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Commonly used term to describe the line item.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TotalCanonicalDescription>))]
public sealed record TotalCanonicalDescription : StringEnum<TotalCanonicalDescription>
{
    private TotalCanonicalDescription(string value) : base(value)
    {
    }

    public static readonly TotalCanonicalDescription Bonus = new("BONUS");

    public static readonly TotalCanonicalDescription Commission = new("COMMISSION");

    public static readonly TotalCanonicalDescription Overtime = new("OVERTIME");

    public static readonly TotalCanonicalDescription PaidTimeOff = new("PAID TIME OFF");

    public static readonly TotalCanonicalDescription RegularPay = new("REGULAR PAY");

    public static readonly TotalCanonicalDescription Vacation = new("VACATION");

    public static readonly TotalCanonicalDescription EmployeeMedicare = new("EMPLOYEE MEDICARE");

    public static readonly TotalCanonicalDescription Fica = new("FICA");

    public static readonly TotalCanonicalDescription SocialSecurityEmployeeTax = new("SOCIAL SECURITY EMPLOYEE TAX");

    public static readonly TotalCanonicalDescription Medical = new("MEDICAL");

    public static readonly TotalCanonicalDescription Vision = new("VISION");

    public static readonly TotalCanonicalDescription Dental = new("DENTAL");

    public static readonly TotalCanonicalDescription NetPay = new("NET PAY");

    public static readonly TotalCanonicalDescription Taxes = new("TAXES");

    public static readonly TotalCanonicalDescription NotFound = new("NOT_FOUND");

    public static readonly TotalCanonicalDescription Other = new("OTHER");

    public static TotalCanonicalDescription FromValue(string value) => FromValueCore(value);
}
