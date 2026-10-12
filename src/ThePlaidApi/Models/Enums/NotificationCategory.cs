using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Category of Notification
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NotificationCategory>))]
public sealed record NotificationCategory : OpenStringEnum<NotificationCategory>
{
    private NotificationCategory(string value) : base(value)
    {
    }

    public static readonly NotificationCategory Security = new("SECURITY");

    public static readonly NotificationCategory Maintenance = new("MAINTENANCE");

    public static readonly NotificationCategory Fraud = new("FRAUD");

    public static readonly NotificationCategory Consent = new("CONSENT");

    public static readonly NotificationCategory NewData = new("NEW_DATA");

    public static readonly NotificationCategory TokenizedAccountNumber = new("TOKENIZED_ACCOUNT_NUMBER");

    public TResult Match<TResult>(Func<TResult> onSecurity,
        Func<TResult> onMaintenance,
        Func<TResult> onFraud,
        Func<TResult> onConsent,
        Func<TResult> onNewData,
        Func<TResult> onTokenizedAccountNumber,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Security => onSecurity(),
            _ when this == Maintenance => onMaintenance(),
            _ when this == Fraud => onFraud(),
            _ when this == Consent => onConsent(),
            _ when this == NewData => onNewData(),
            _ when this == TokenizedAccountNumber => onTokenizedAccountNumber(),
            _ => otherwise(Value)
        };

    public void Match(Action onSecurity,
        Action onMaintenance,
        Action onFraud,
        Action onConsent,
        Action onNewData,
        Action onTokenizedAccountNumber,
        Action<string> otherwise)
    {
        if (this == Security) onSecurity();
        else if (this == Maintenance) onMaintenance();
        else if (this == Fraud) onFraud();
        else if (this == Consent) onConsent();
        else if (this == NewData) onNewData();
        else if (this == TokenizedAccountNumber) onTokenizedAccountNumber();
        else otherwise(Value);
    }
}
