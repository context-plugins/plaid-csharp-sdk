using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The types of source income data that users should be able to share
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeVerificationSourceType>))]
public sealed record IncomeVerificationSourceType : StringEnum<IncomeVerificationSourceType>
{
    private IncomeVerificationSourceType(string value) : base(value)
    {
    }

    public static readonly IncomeVerificationSourceType Bank = new("bank");

    public static readonly IncomeVerificationSourceType Payroll = new("payroll");

    public static IncomeVerificationSourceType FromValue(string value) => FromValueCore(value);
}
