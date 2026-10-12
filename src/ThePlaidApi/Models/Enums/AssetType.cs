using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// A value from a MISMO prescribed list that specifies financial assets in a mortgage loan transaction. Assets may be either liquid or fixed and are associated with a corresponding asset amount.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetType>))]
public sealed record AssetType : OpenStringEnum<AssetType>
{
    private AssetType(string value) : base(value)
    {
    }

    public static readonly AssetType CheckingAccount = new("CheckingAccount");

    public static readonly AssetType SavingsAccount = new("SavingsAccount");

    public static readonly AssetType Investment = new("Investment");

    public static readonly AssetType MoneyMarketFund = new("MoneyMarketFund");

    public static readonly AssetType Other = new("Other");

    public TResult Match<TResult>(Func<TResult> onCheckingAccount,
        Func<TResult> onSavingsAccount,
        Func<TResult> onInvestment,
        Func<TResult> onMoneyMarketFund,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CheckingAccount => onCheckingAccount(),
            _ when this == SavingsAccount => onSavingsAccount(),
            _ when this == Investment => onInvestment(),
            _ when this == MoneyMarketFund => onMoneyMarketFund(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onCheckingAccount,
        Action onSavingsAccount,
        Action onInvestment,
        Action onMoneyMarketFund,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == CheckingAccount) onCheckingAccount();
        else if (this == SavingsAccount) onSavingsAccount();
        else if (this == Investment) onInvestment();
        else if (this == MoneyMarketFund) onMoneyMarketFund();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
