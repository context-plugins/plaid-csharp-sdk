using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The webhook codes that can be fired by this test endpoint.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WebhookCode>))]
public sealed record WebhookCode : OpenStringEnum<WebhookCode>
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

    public TResult Match<TResult>(Func<TResult> onDefaultUpdate,
        Func<TResult> onNewAccountsAvailable,
        Func<TResult> onSmsMicrodepositsVerification,
        Func<TResult> onAuthorizationGranted,
        Func<TResult> onUserPermissionRevoked,
        Func<TResult> onUserAccountRevoked,
        Func<TResult> onPendingDisconnect,
        Func<TResult> onRecurringTransactionsUpdate,
        Func<TResult> onLoginRepaired,
        Func<TResult> onSyncUpdatesAvailable,
        Func<TResult> onProductReady,
        Func<TResult> onError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DefaultUpdate => onDefaultUpdate(),
            _ when this == NewAccountsAvailable => onNewAccountsAvailable(),
            _ when this == SmsMicrodepositsVerification => onSmsMicrodepositsVerification(),
            _ when this == AuthorizationGranted => onAuthorizationGranted(),
            _ when this == UserPermissionRevoked => onUserPermissionRevoked(),
            _ when this == UserAccountRevoked => onUserAccountRevoked(),
            _ when this == PendingDisconnect => onPendingDisconnect(),
            _ when this == RecurringTransactionsUpdate => onRecurringTransactionsUpdate(),
            _ when this == LoginRepaired => onLoginRepaired(),
            _ when this == SyncUpdatesAvailable => onSyncUpdatesAvailable(),
            _ when this == ProductReady => onProductReady(),
            _ when this == Error => onError(),
            _ => otherwise(Value)
        };

    public void Match(Action onDefaultUpdate,
        Action onNewAccountsAvailable,
        Action onSmsMicrodepositsVerification,
        Action onAuthorizationGranted,
        Action onUserPermissionRevoked,
        Action onUserAccountRevoked,
        Action onPendingDisconnect,
        Action onRecurringTransactionsUpdate,
        Action onLoginRepaired,
        Action onSyncUpdatesAvailable,
        Action onProductReady,
        Action onError,
        Action<string> otherwise)
    {
        if (this == DefaultUpdate) onDefaultUpdate();
        else if (this == NewAccountsAvailable) onNewAccountsAvailable();
        else if (this == SmsMicrodepositsVerification) onSmsMicrodepositsVerification();
        else if (this == AuthorizationGranted) onAuthorizationGranted();
        else if (this == UserPermissionRevoked) onUserPermissionRevoked();
        else if (this == UserAccountRevoked) onUserAccountRevoked();
        else if (this == PendingDisconnect) onPendingDisconnect();
        else if (this == RecurringTransactionsUpdate) onRecurringTransactionsUpdate();
        else if (this == LoginRepaired) onLoginRepaired();
        else if (this == SyncUpdatesAvailable) onSyncUpdatesAvailable();
        else if (this == ProductReady) onProductReady();
        else if (this == Error) onError();
        else otherwise(Value);
    }
}
