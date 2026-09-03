using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The version of cashflow attributes. Required if using Cash Flow Insights.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashflowAttributesVersion>))]
public sealed record CashflowAttributesVersion : StringEnum<CashflowAttributesVersion>
{
    private CashflowAttributesVersion(string value) : base(value)
    {
    }

    public static readonly CashflowAttributesVersion V10 = new("v1.0");

    public static readonly CashflowAttributesVersion V20 = new("v2.0");

    public static readonly CashflowAttributesVersion Cfi1 = new("CFI1");

    public static CashflowAttributesVersion FromValue(string value) => FromValueCore(value);
}
