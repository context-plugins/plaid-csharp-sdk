using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The confidence that Plaid can support the user in the digital income verification flow instead of requiring a manual paystub upload. One of the following:
/// <para>
/// <c>"HIGH"</c>: It is very likely that this user can use the digital income verification flow.
/// </para>
/// <para>
/// "<c>LOW</c>": It is unlikely that this user can use the digital income verification flow.
/// </para>
/// <para>
/// <c>"UNKNOWN"</c>: It was not possible to determine if the user is supportable with the information passed.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IncomeVerificationPrecheckConfidence>))]
public sealed record IncomeVerificationPrecheckConfidence : StringEnum<IncomeVerificationPrecheckConfidence>
{
    private IncomeVerificationPrecheckConfidence(string value) : base(value)
    {
    }

    public static readonly IncomeVerificationPrecheckConfidence High = new("HIGH");

    public static readonly IncomeVerificationPrecheckConfidence Low = new("LOW");

    public static readonly IncomeVerificationPrecheckConfidence Unknown = new("UNKNOWN");

    public static IncomeVerificationPrecheckConfidence FromValue(string value) => FromValueCore(value);
}
