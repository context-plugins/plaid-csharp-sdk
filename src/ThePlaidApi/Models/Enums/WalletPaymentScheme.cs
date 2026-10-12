using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The payment scheme used to execute this transaction. This is present only for transaction types <c>PAYOUT</c> and <c>REFUND</c>.
/// <para>
/// <c>FASTER_PAYMENTS</c>: The standard payment scheme within the UK.
/// </para>
/// <para>
/// <c>SEPA_CREDIT_TRANSFER</c>: The standard payment to a beneficiary within the SEPA area.
/// </para>
/// <para>
/// <c>SEPA_CREDIT_TRANSFER_INSTANT</c>: Instant payment to a beneficiary within the SEPA area.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WalletPaymentScheme>))]
public sealed record WalletPaymentScheme : OpenStringEnum<WalletPaymentScheme>
{
    private WalletPaymentScheme(string value) : base(value)
    {
    }

    public static readonly WalletPaymentScheme FasterPayments = new("FASTER_PAYMENTS");

    public static readonly WalletPaymentScheme SepaCreditTransfer = new("SEPA_CREDIT_TRANSFER");

    public static readonly WalletPaymentScheme SepaCreditTransferInstant = new("SEPA_CREDIT_TRANSFER_INSTANT");

    public TResult Match<TResult>(Func<TResult> onFasterPayments,
        Func<TResult> onSepaCreditTransfer,
        Func<TResult> onSepaCreditTransferInstant,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FasterPayments => onFasterPayments(),
            _ when this == SepaCreditTransfer => onSepaCreditTransfer(),
            _ when this == SepaCreditTransferInstant => onSepaCreditTransferInstant(),
            _ => otherwise(Value)
        };

    public void Match(Action onFasterPayments,
        Action onSepaCreditTransfer,
        Action onSepaCreditTransferInstant,
        Action<string> otherwise)
    {
        if (this == FasterPayments) onFasterPayments();
        else if (this == SepaCreditTransfer) onSepaCreditTransfer();
        else if (this == SepaCreditTransferInstant) onSepaCreditTransferInstant();
        else otherwise(Value);
    }
}
