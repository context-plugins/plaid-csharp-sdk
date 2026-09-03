using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A payroll account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PayrollAccount>))]
public sealed record PayrollAccount : StringEnum<PayrollAccount>
{
    private PayrollAccount(string value) : base(value)
    {
    }

    public static readonly PayrollAccount Payroll = new("payroll");

    public static PayrollAccount FromValue(string value) => FromValueCore(value);
}
