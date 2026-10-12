using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Type of entity causing origination of a notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationPayloadIdType>))]
public sealed record NotificationPayloadIdType : OpenStringEnum<NotificationPayloadIdType>
{
    private NotificationPayloadIdType(string value) : base(value)
    {
    }

    public static readonly NotificationPayloadIdType Account = new("ACCOUNT");

    public static readonly NotificationPayloadIdType Customer = new("CUSTOMER");

    public static readonly NotificationPayloadIdType Party = new("PARTY");

    public static readonly NotificationPayloadIdType Maintenance = new("MAINTENANCE");

    public static readonly NotificationPayloadIdType Consent = new("CONSENT");

    public TResult Match<TResult>(Func<TResult> onAccount,
        Func<TResult> onCustomer,
        Func<TResult> onParty,
        Func<TResult> onMaintenance,
        Func<TResult> onConsent,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Account => onAccount(),
            _ when this == Customer => onCustomer(),
            _ when this == Party => onParty(),
            _ when this == Maintenance => onMaintenance(),
            _ when this == Consent => onConsent(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccount,
        Action onCustomer,
        Action onParty,
        Action onMaintenance,
        Action onConsent,
        Action<string> otherwise)
    {
        if (this == Account) onAccount();
        else if (this == Customer) onCustomer();
        else if (this == Party) onParty();
        else if (this == Maintenance) onMaintenance();
        else if (this == Consent) onConsent();
        else otherwise(Value);
    }
}
