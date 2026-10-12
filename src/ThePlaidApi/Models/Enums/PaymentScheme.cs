using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Payment scheme. If not specified - the default in the region will be used (e.g. <c>SEPA_CREDIT_TRANSFER</c> for EU). In responses, if the scheme is not explicitly specified in the request, this value will be <c>null</c>. Using unsupported values will result in a failed payment.
/// <para>
/// <c>LOCAL_DEFAULT</c>: The default payment scheme for the selected market and currency will be used.
/// </para>
/// <para>
/// <c>LOCAL_INSTANT</c>: The instant payment scheme for the selected market and currency will be used (if applicable). Fees may be applied by the institution.
/// </para>
/// <para>
/// <c>SEPA_CREDIT_TRANSFER</c>: The standard payment to a beneficiary within the SEPA area.
/// </para>
/// <para>
/// <c>SEPA_CREDIT_TRANSFER_INSTANT</c>: Instant payment within the SEPA area. May involve additional fees and may not be available at some banks.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PaymentScheme>))]
public sealed record PaymentScheme : OpenStringEnum<PaymentScheme>
{
    private PaymentScheme(string value) : base(value)
    {
    }

    public static readonly PaymentScheme LocalDefault = new("LOCAL_DEFAULT");

    public static readonly PaymentScheme LocalInstant = new("LOCAL_INSTANT");

    public static readonly PaymentScheme SepaCreditTransfer = new("SEPA_CREDIT_TRANSFER");

    public static readonly PaymentScheme SepaCreditTransferInstant = new("SEPA_CREDIT_TRANSFER_INSTANT");

    public TResult Match<TResult>(Func<TResult> onLocalDefault,
        Func<TResult> onLocalInstant,
        Func<TResult> onSepaCreditTransfer,
        Func<TResult> onSepaCreditTransferInstant,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LocalDefault => onLocalDefault(),
            _ when this == LocalInstant => onLocalInstant(),
            _ when this == SepaCreditTransfer => onSepaCreditTransfer(),
            _ when this == SepaCreditTransferInstant => onSepaCreditTransferInstant(),
            _ => otherwise(Value)
        };

    public void Match(Action onLocalDefault,
        Action onLocalInstant,
        Action onSepaCreditTransfer,
        Action onSepaCreditTransferInstant,
        Action<string> otherwise)
    {
        if (this == LocalDefault) onLocalDefault();
        else if (this == LocalInstant) onLocalInstant();
        else if (this == SepaCreditTransfer) onSepaCreditTransfer();
        else if (this == SepaCreditTransferInstant) onSepaCreditTransferInstant();
        else otherwise(Value);
    }
}
