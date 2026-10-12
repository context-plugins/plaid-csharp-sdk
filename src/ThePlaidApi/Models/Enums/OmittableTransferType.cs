using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of transfer. Valid values are <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account. This field is omitted for Plaid Ledger Sweep events.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OmittableTransferType>))]
public sealed record OmittableTransferType : OpenStringEnum<OmittableTransferType>
{
    private OmittableTransferType(string value) : base(value)
    {
    }

    public static readonly OmittableTransferType Debit = new("debit");

    public static readonly OmittableTransferType Credit = new("credit");

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
