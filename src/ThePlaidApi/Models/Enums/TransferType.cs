using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferType>))]
public sealed record TransferType : OpenStringEnum<TransferType>
{
    private TransferType(string value) : base(value)
    {
    }

    public static readonly TransferType Debit = new("debit");

    public static readonly TransferType Credit = new("credit");

    public TResult Match<TResult>(Func<TResult> onDebit, Func<TResult> onCredit, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Debit => onDebit(),
            _ when this == Credit => onCredit(),
            _ => otherwise(Value)
        };

    public void Match(Action onDebit, Action onCredit, Action<string> otherwise)
    {
        if (this == Debit) onDebit();
        else if (this == Credit) onCredit();
        else otherwise(Value);
    }
}
