using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The result of the rule that was triggered for this transaction.
/// <para>
/// <c>ACCEPT</c>: Accept the transaction for processing.
/// <c>REROUTE</c>: Reroute the transaction to a different payment method, as this transaction is too risky.
/// <c>REVIEW</c>: Review the transaction before proceeding.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RuleResult>))]
public sealed record RuleResult : StringEnum<RuleResult>
{
    private RuleResult(string value) : base(value)
    {
    }

    public static readonly RuleResult Accept = new("ACCEPT");

    public static readonly RuleResult Reroute = new("REROUTE");

    public static readonly RuleResult Review = new("REVIEW");

    public static RuleResult FromValue(string value) => FromValueCore(value);
}
