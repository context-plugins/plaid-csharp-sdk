using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// An account type holding cash, in which funds are deposited.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DepositoryAccount>))]
public sealed record DepositoryAccount : OpenStringEnum<DepositoryAccount>
{
    private DepositoryAccount(string value) : base(value)
    {
    }

    public static readonly DepositoryAccount CashManagement = new("cash management");

    public static readonly DepositoryAccount Cd = new("cd");

    public static readonly DepositoryAccount Checking = new("checking");

    public static readonly DepositoryAccount Ebt = new("ebt");

    public static readonly DepositoryAccount Hsa = new("hsa");

    public static readonly DepositoryAccount LimitedPurposeChecking = new("limited purpose checking");

    public static readonly DepositoryAccount MoneyMarket = new("money market");

    public static readonly DepositoryAccount Paypal = new("paypal");

    public static readonly DepositoryAccount Prepaid = new("prepaid");

    public static readonly DepositoryAccount Savings = new("savings");

    public TResult Match<TResult>(Func<TResult> onCashManagement,
        Func<TResult> onCd,
        Func<TResult> onChecking,
        Func<TResult> onEbt,
        Func<TResult> onHsa,
        Func<TResult> onLimitedPurposeChecking,
        Func<TResult> onMoneyMarket,
        Func<TResult> onPaypal,
        Func<TResult> onPrepaid,
        Func<TResult> onSavings,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CashManagement => onCashManagement(),
            _ when this == Cd => onCd(),
            _ when this == Checking => onChecking(),
            _ when this == Ebt => onEbt(),
            _ when this == Hsa => onHsa(),
            _ when this == LimitedPurposeChecking => onLimitedPurposeChecking(),
            _ when this == MoneyMarket => onMoneyMarket(),
            _ when this == Paypal => onPaypal(),
            _ when this == Prepaid => onPrepaid(),
            _ when this == Savings => onSavings(),
            _ => otherwise(Value)
        };

    public void Match(Action onCashManagement,
        Action onCd,
        Action onChecking,
        Action onEbt,
        Action onHsa,
        Action onLimitedPurposeChecking,
        Action onMoneyMarket,
        Action onPaypal,
        Action onPrepaid,
        Action onSavings,
        Action<string> otherwise)
    {
        if (this == CashManagement) onCashManagement();
        else if (this == Cd) onCd();
        else if (this == Checking) onChecking();
        else if (this == Ebt) onEbt();
        else if (this == Hsa) onHsa();
        else if (this == LimitedPurposeChecking) onLimitedPurposeChecking();
        else if (this == MoneyMarket) onMoneyMarket();
        else if (this == Paypal) onPaypal();
        else if (this == Prepaid) onPrepaid();
        else if (this == Savings) onSavings();
        else otherwise(Value);
    }
}
