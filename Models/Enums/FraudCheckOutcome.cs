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
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FraudCheckOutcome>))]
public sealed record FraudCheckOutcome : StringEnum<FraudCheckOutcome>
{
    private FraudCheckOutcome(string value) : base(value)
    {
    }

    public static readonly FraudCheckOutcome Success = new("success");

    public static readonly FraudCheckOutcome Failed = new("failed");

    public static FraudCheckOutcome FromValue(string value) => FromValueCore(value);
}
