using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The type of bank transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into your origination account; a <c>credit</c> indicates a transfer of money out of your origination account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferEventListBankTransferType>))]
public sealed record BankTransferEventListBankTransferType : OpenStringEnum<BankTransferEventListBankTransferType>
{
    private BankTransferEventListBankTransferType(string value) : base(value)
    {
    }

    public static readonly BankTransferEventListBankTransferType Debit = new("debit");

    public static readonly BankTransferEventListBankTransferType Credit = new("credit");

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
