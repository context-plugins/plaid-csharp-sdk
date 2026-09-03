using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Transaction field for which the rule is defined.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionsRuleField>))]
public sealed record TransactionsRuleField : StringEnum<TransactionsRuleField>
{
    private TransactionsRuleField(string value) : base(value)
    {
    }

    public static readonly TransactionsRuleField TransactionId = new("TRANSACTION_ID");

    public static readonly TransactionsRuleField MerchantName = new("MERCHANT_NAME");

    public static TransactionsRuleField FromValue(string value) => FromValueCore(value);
}
