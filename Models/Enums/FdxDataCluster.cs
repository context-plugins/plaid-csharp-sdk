using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Name of a cluster of data elements permissioned by a consent grant.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FdxDataCluster>))]
public sealed record FdxDataCluster : StringEnum<FdxDataCluster>
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

    public static FdxDataCluster FromValue(string value) => FromValueCore(value);
}
