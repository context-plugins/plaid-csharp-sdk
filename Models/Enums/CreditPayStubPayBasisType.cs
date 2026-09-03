using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The explicit pay basis on the paystub (if present).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditPayStubPayBasisType>))]
public sealed record CreditPayStubPayBasisType : StringEnum<CreditPayStubPayBasisType>
{
    private CreditPayStubPayBasisType(string value) : base(value)
    {
    }

    public static readonly CreditPayStubPayBasisType Salary = new("SALARY");

    public static readonly CreditPayStubPayBasisType Hourly = new("HOURLY");

    public static readonly CreditPayStubPayBasisType Commission = new("COMMISSION");

    public static CreditPayStubPayBasisType FromValue(string value) => FromValueCore(value);
}
