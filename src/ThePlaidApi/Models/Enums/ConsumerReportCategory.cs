using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of data being disputed by the consumer
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConsumerReportCategory>))]
public sealed record ConsumerReportCategory : OpenStringEnum<ConsumerReportCategory>
{
    private ConsumerReportCategory(string value) : base(value)
    {
    }

    public static readonly ConsumerReportCategory Transaction = new("TRANSACTION");

    public static readonly ConsumerReportCategory Balance = new("BALANCE");

    public static readonly ConsumerReportCategory Identity = new("IDENTITY");

    public static readonly ConsumerReportCategory Other = new("OTHER");

    public TResult Match<TResult>(Func<TResult> onTransaction,
        Func<TResult> onBalance,
        Func<TResult> onIdentity,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Transaction => onTransaction(),
            _ when this == Balance => onBalance(),
            _ when this == Identity => onIdentity(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onTransaction,
        Action onBalance,
        Action onIdentity,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == Transaction) onTransaction();
        else if (this == Balance) onBalance();
        else if (this == Identity) onIdentity();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
