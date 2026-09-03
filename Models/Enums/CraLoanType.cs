using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of loan the user applied for.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CraLoanType>))]
public sealed record CraLoanType : StringEnum<CraLoanType>
{
    private CraLoanType(string value) : base(value)
    {
    }

    public static readonly CraLoanType Personal = new("PERSONAL");

    public static readonly CraLoanType CreditCard = new("CREDIT_CARD");

    public static readonly CraLoanType Business = new("BUSINESS");

    public static readonly CraLoanType Mortgage = new("MORTGAGE");

    public static readonly CraLoanType Auto = new("AUTO");

    public static readonly CraLoanType Payday = new("PAYDAY");

    public static readonly CraLoanType Student = new("STUDENT");

    public static readonly CraLoanType HomeEquity = new("HOME_EQUITY");

    public static readonly CraLoanType Other = new("OTHER");

    public static CraLoanType FromValue(string value) => FromValueCore(value);
}
