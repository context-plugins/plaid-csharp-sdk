using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Asset Transaction Type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetTransactionType>))]
public sealed record AssetTransactionType : OpenStringEnum<AssetTransactionType>
{
    private AssetTransactionType(string value) : base(value)
    {
    }

    public static readonly AssetTransactionType Credit = new("Credit");

    public static readonly AssetTransactionType Debit = new("Debit");

    public TResult Match<TResult>(Func<TResult> onCredit, Func<TResult> onDebit, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Credit => onCredit(),
            _ when this == Debit => onDebit(),
            _ => otherwise(Value)
        };

    public void Match(Action onCredit, Action onDebit, Action<string> otherwise)
    {
        if (this == Credit) onCredit();
        else if (this == Debit) onDebit();
        else otherwise(Value);
    }
}
