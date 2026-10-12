using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Valid account subtypes for depository accounts. For a list containing descriptions of each subtype, see <see href="https://plaid.com/docs/api/accounts/#StandaloneAccountType-depository">Account schemas</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DepositoryAccountSubtype>))]
public sealed record DepositoryAccountSubtype : OpenStringEnum<DepositoryAccountSubtype>
{
    private DepositoryAccountSubtype(string value) : base(value)
    {
    }

    public static readonly DepositoryAccountSubtype Checking = new("checking");

    public static readonly DepositoryAccountSubtype Savings = new("savings");

    public static readonly DepositoryAccountSubtype Hsa = new("hsa");

    public static readonly DepositoryAccountSubtype Cd = new("cd");

    public static readonly DepositoryAccountSubtype MoneyMarket = new("money market");

    public static readonly DepositoryAccountSubtype Paypal = new("paypal");

    public static readonly DepositoryAccountSubtype Prepaid = new("prepaid");

    public static readonly DepositoryAccountSubtype CashManagement = new("cash management");

    public static readonly DepositoryAccountSubtype Ebt = new("ebt");

    public static readonly DepositoryAccountSubtype LimitedPurposeChecking = new("limited purpose checking");

    public static readonly DepositoryAccountSubtype All = new("all");

    public TResult Match<TResult>(Func<TResult> onChecking,
        Func<TResult> onSavings,
        Func<TResult> onHsa,
        Func<TResult> onCd,
        Func<TResult> onMoneyMarket,
        Func<TResult> onPaypal,
        Func<TResult> onPrepaid,
        Func<TResult> onCashManagement,
        Func<TResult> onEbt,
        Func<TResult> onLimitedPurposeChecking,
        Func<TResult> onAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Checking => onChecking(),
            _ when this == Savings => onSavings(),
            _ when this == Hsa => onHsa(),
            _ when this == Cd => onCd(),
            _ when this == MoneyMarket => onMoneyMarket(),
            _ when this == Paypal => onPaypal(),
            _ when this == Prepaid => onPrepaid(),
            _ when this == CashManagement => onCashManagement(),
            _ when this == Ebt => onEbt(),
            _ when this == LimitedPurposeChecking => onLimitedPurposeChecking(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onChecking,
        Action onSavings,
        Action onHsa,
        Action onCd,
        Action onMoneyMarket,
        Action onPaypal,
        Action onPrepaid,
        Action onCashManagement,
        Action onEbt,
        Action onLimitedPurposeChecking,
        Action onAll,
        Action<string> otherwise)
    {
        if (this == Checking) onChecking();
        else if (this == Savings) onSavings();
        else if (this == Hsa) onHsa();
        else if (this == Cd) onCd();
        else if (this == MoneyMarket) onMoneyMarket();
        else if (this == Paypal) onPaypal();
        else if (this == Prepaid) onPrepaid();
        else if (this == CashManagement) onCashManagement();
        else if (this == Ebt) onEbt();
        else if (this == LimitedPurposeChecking) onLimitedPurposeChecking();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
