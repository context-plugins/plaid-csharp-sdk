using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The webhook types that can be fired by this test endpoint.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WebhookType>))]
public sealed record WebhookType : OpenStringEnum<WebhookType>
{
    private WebhookType(string value) : base(value)
    {
    }

    public static readonly WebhookType Auth = new("AUTH");

    public static readonly WebhookType Holdings = new("HOLDINGS");

    public static readonly WebhookType InvestmentsTransactions = new("INVESTMENTS_TRANSACTIONS");

    public static readonly WebhookType Item = new("ITEM");

    public static readonly WebhookType Liabilities = new("LIABILITIES");

    public static readonly WebhookType Transactions = new("TRANSACTIONS");

    public static readonly WebhookType Assets = new("ASSETS");

    public TResult Match<TResult>(Func<TResult> onAuth,
        Func<TResult> onHoldings,
        Func<TResult> onInvestmentsTransactions,
        Func<TResult> onItem,
        Func<TResult> onLiabilities,
        Func<TResult> onTransactions,
        Func<TResult> onAssets,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Auth => onAuth(),
            _ when this == Holdings => onHoldings(),
            _ when this == InvestmentsTransactions => onInvestmentsTransactions(),
            _ when this == Item => onItem(),
            _ when this == Liabilities => onLiabilities(),
            _ when this == Transactions => onTransactions(),
            _ when this == Assets => onAssets(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuth,
        Action onHoldings,
        Action onInvestmentsTransactions,
        Action onItem,
        Action onLiabilities,
        Action onTransactions,
        Action onAssets,
        Action<string> otherwise)
    {
        if (this == Auth) onAuth();
        else if (this == Holdings) onHoldings();
        else if (this == InvestmentsTransactions) onInvestmentsTransactions();
        else if (this == Item) onItem();
        else if (this == Liabilities) onLiabilities();
        else if (this == Transactions) onTransactions();
        else if (this == Assets) onAssets();
        else otherwise(Value);
    }
}
