using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Transaction field for which the rule is defined.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionsRuleField>))]
public sealed record TransactionsRuleField : OpenStringEnum<TransactionsRuleField>
{
    private TransactionsRuleField(string value) : base(value)
    {
    }

    public static readonly TransactionsRuleField TransactionId = new("TRANSACTION_ID");

    public static readonly TransactionsRuleField MerchantName = new("MERCHANT_NAME");

    public TResult Match<TResult>(Func<TResult> onTransactionId,
        Func<TResult> onMerchantName,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TransactionId => onTransactionId(),
            _ when this == MerchantName => onMerchantName(),
            _ => otherwise(Value)
        };

    public void Match(Action onTransactionId, Action onMerchantName, Action<string> otherwise)
    {
        if (this == TransactionId) onTransactionId();
        else if (this == MerchantName) onMerchantName();
        else otherwise(Value);
    }
}
