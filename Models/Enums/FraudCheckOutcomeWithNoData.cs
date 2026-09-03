using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The outcome of the fraud check.
/// <para>
///
/// <c>success</c> - The check passed.
/// </para>
/// <para>
/// <c>failed</c> - The check did not pass.
/// </para>
/// <para>
/// <c>no_data</c> - The check could not be performed due to insufficient data.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FraudCheckOutcomeWithNoData>))]
public sealed record FraudCheckOutcomeWithNoData : StringEnum<FraudCheckOutcomeWithNoData>
{
    private FraudCheckOutcomeWithNoData(string value) : base(value)
    {
    }

    public static readonly FraudCheckOutcomeWithNoData Success = new("success");

    public static readonly FraudCheckOutcomeWithNoData Failed = new("failed");

    public static readonly FraudCheckOutcomeWithNoData NoData = new("no_data");

    public static FraudCheckOutcomeWithNoData FromValue(string value) => FromValueCore(value);
}
