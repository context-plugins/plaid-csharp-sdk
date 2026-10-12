using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The direction of the flow of transfer funds.
/// <para>
/// <c>PAYMENT</c>: Transfers funds from an end user's account to your business account.
/// </para>
/// <para>
/// <c>DISBURSEMENT</c>: Transfers funds from your business account to an end user's account.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferIntentCreateMode>))]
public sealed record TransferIntentCreateMode : OpenStringEnum<TransferIntentCreateMode>
{
    private TransferIntentCreateMode(string value) : base(value)
    {
    }

    public static readonly TransferIntentCreateMode Payment = new("PAYMENT");

    public static readonly TransferIntentCreateMode Disbursement = new("DISBURSEMENT");

    public TResult Match<TResult>(Func<TResult> onPayment,
        Func<TResult> onDisbursement,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Payment => onPayment(),
            _ when this == Disbursement => onDisbursement(),
            _ => otherwise(Value)
        };

    public void Match(Action onPayment, Action onDisbursement, Action<string> otherwise)
    {
        if (this == Payment) onPayment();
        else if (this == Disbursement) onDisbursement();
        else otherwise(Value);
    }
}
