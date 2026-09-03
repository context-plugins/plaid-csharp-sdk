using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The webhook codes that can be fired by this test endpoint.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WebhookCode>))]
public sealed record WebhookCode : StringEnum<WebhookCode>
{
    private WebhookCode(string value) : base(value)
    {
    }

    public static readonly WebhookCode DefaultUpdate = new("DEFAULT_UPDATE");

    public static readonly WebhookCode NewAccountsAvailable = new("NEW_ACCOUNTS_AVAILABLE");

    public static readonly WebhookCode SmsMicrodepositsVerification = new("SMS_MICRODEPOSITS_VERIFICATION");

    public static readonly WebhookCode AuthorizationGranted = new("AUTHORIZATION_GRANTED");

    public static readonly WebhookCode UserPermissionRevoked = new("USER_PERMISSION_REVOKED");

    public static readonly WebhookCode UserAccountRevoked = new("USER_ACCOUNT_REVOKED");

    public static readonly WebhookCode PendingDisconnect = new("PENDING_DISCONNECT");

    public static readonly WebhookCode RecurringTransactionsUpdate = new("RECURRING_TRANSACTIONS_UPDATE");

    public static readonly WebhookCode LoginRepaired = new("LOGIN_REPAIRED");

    public static readonly WebhookCode SyncUpdatesAvailable = new("SYNC_UPDATES_AVAILABLE");

    public static readonly WebhookCode ProductReady = new("PRODUCT_READY");

    public static readonly WebhookCode Error = new("ERROR");

    public static WebhookCode FromValue(string value) => FromValueCore(value);
}
