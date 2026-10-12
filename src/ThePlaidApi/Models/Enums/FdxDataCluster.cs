using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Name of a cluster of data elements permissioned by a consent grant.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxDataCluster>))]
public sealed record FdxDataCluster : OpenStringEnum<FdxDataCluster>
{
    private FdxDataCluster(string value) : base(value)
    {
    }

    public static readonly FdxDataCluster AccountBasic = new("ACCOUNT_BASIC");

    public static readonly FdxDataCluster AccountDetailed = new("ACCOUNT_DETAILED");

    public static readonly FdxDataCluster AccountPayments = new("ACCOUNT_PAYMENTS");

    public static readonly FdxDataCluster Bills = new("BILLS");

    public static readonly FdxDataCluster CustomerContact = new("CUSTOMER_CONTACT");

    public static readonly FdxDataCluster CustomerPersonal = new("CUSTOMER_PERSONAL");

    public static readonly FdxDataCluster Images = new("IMAGES");

    public static readonly FdxDataCluster Investments = new("INVESTMENTS");

    public static readonly FdxDataCluster Notifications = new("NOTIFICATIONS");

    public static readonly FdxDataCluster PaymentSupport = new("PAYMENT_SUPPORT");

    public static readonly FdxDataCluster Rewards = new("REWARDS");

    public static readonly FdxDataCluster Statements = new("STATEMENTS");

    public static readonly FdxDataCluster Tax = new("TAX");

    public static readonly FdxDataCluster Transactions = new("TRANSACTIONS");

    public static readonly FdxDataCluster Balances = new("BALANCES");

    public static readonly FdxDataCluster ScheduledPayments = new("SCHEDULED_PAYMENTS");

    public TResult Match<TResult>(Func<TResult> onAccountBasic,
        Func<TResult> onAccountDetailed,
        Func<TResult> onAccountPayments,
        Func<TResult> onBills,
        Func<TResult> onCustomerContact,
        Func<TResult> onCustomerPersonal,
        Func<TResult> onImages,
        Func<TResult> onInvestments,
        Func<TResult> onNotifications,
        Func<TResult> onPaymentSupport,
        Func<TResult> onRewards,
        Func<TResult> onStatements,
        Func<TResult> onTax,
        Func<TResult> onTransactions,
        Func<TResult> onBalances,
        Func<TResult> onScheduledPayments,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountBasic => onAccountBasic(),
            _ when this == AccountDetailed => onAccountDetailed(),
            _ when this == AccountPayments => onAccountPayments(),
            _ when this == Bills => onBills(),
            _ when this == CustomerContact => onCustomerContact(),
            _ when this == CustomerPersonal => onCustomerPersonal(),
            _ when this == Images => onImages(),
            _ when this == Investments => onInvestments(),
            _ when this == Notifications => onNotifications(),
            _ when this == PaymentSupport => onPaymentSupport(),
            _ when this == Rewards => onRewards(),
            _ when this == Statements => onStatements(),
            _ when this == Tax => onTax(),
            _ when this == Transactions => onTransactions(),
            _ when this == Balances => onBalances(),
            _ when this == ScheduledPayments => onScheduledPayments(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountBasic,
        Action onAccountDetailed,
        Action onAccountPayments,
        Action onBills,
        Action onCustomerContact,
        Action onCustomerPersonal,
        Action onImages,
        Action onInvestments,
        Action onNotifications,
        Action onPaymentSupport,
        Action onRewards,
        Action onStatements,
        Action onTax,
        Action onTransactions,
        Action onBalances,
        Action onScheduledPayments,
        Action<string> otherwise)
    {
        if (this == AccountBasic) onAccountBasic();
        else if (this == AccountDetailed) onAccountDetailed();
        else if (this == AccountPayments) onAccountPayments();
        else if (this == Bills) onBills();
        else if (this == CustomerContact) onCustomerContact();
        else if (this == CustomerPersonal) onCustomerPersonal();
        else if (this == Images) onImages();
        else if (this == Investments) onInvestments();
        else if (this == Notifications) onNotifications();
        else if (this == PaymentSupport) onPaymentSupport();
        else if (this == Rewards) onRewards();
        else if (this == Statements) onStatements();
        else if (this == Tax) onTax();
        else if (this == Transactions) onTransactions();
        else if (this == Balances) onBalances();
        else if (this == ScheduledPayments) onScheduledPayments();
        else otherwise(Value);
    }
}
