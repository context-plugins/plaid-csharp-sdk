using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Transaction rule's match type. For <c>TRANSACTION_ID</c> field, <c>EXACT_MATCH</c> is available.
/// Matches are case sensitive.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionsRuleType>))]
public sealed record TransactionsRuleType : StringEnum<TransactionsRuleType>
{
    private TransactionsRuleType(string value) : base(value)
    {
    }

    public static readonly TransactionsRuleType ExactMatch = new("EXACT_MATCH");

    public static readonly TransactionsRuleType SubstringMatch = new("SUBSTRING_MATCH");

    public static TransactionsRuleType FromValue(string value) => FromValueCore(value);
}
