using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An insight that can be detected by the Cash Flow Updates product
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CashFlowInsight>))]
public sealed record CashFlowInsight : StringEnum<CashFlowInsight>
{
    private CashFlowInsight(string value) : base(value)
    {
    }

    public static readonly CashFlowInsight LargeDepositDetected = new("LARGE_DEPOSIT_DETECTED");

    public static readonly CashFlowInsight LowBalanceDetected = new("LOW_BALANCE_DETECTED");

    public static readonly CashFlowInsight NewLoanPaymentDetected = new("NEW_LOAN_PAYMENT_DETECTED");

    public static readonly CashFlowInsight NsfOverdraftDetected = new("NSF_OVERDRAFT_DETECTED");

    public static CashFlowInsight FromValue(string value) => FromValueCore(value);
}
