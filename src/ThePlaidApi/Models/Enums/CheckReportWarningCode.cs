using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The warning code identifies a specific kind of warning.
/// <c>IDENTITY_UNAVAILABLE</c>:  Account-owner information is not available.
/// <c>TRANSACTIONS_UNAVAILABLE</c>: Transactions information associated with Credit and Depository accounts are unavailable.
/// <c>USER_FRAUD_ALERT</c>: The user has placed a fraud alert on their Plaid Check consumer report due to suspected fraud. Please note that when a fraud alert is in place, the recipient of the consumer report has an obligation to verify the consumer's identity.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CheckReportWarningCode>))]
public sealed record CheckReportWarningCode : OpenStringEnum<CheckReportWarningCode>
{
    private CheckReportWarningCode(string value) : base(value)
    {
    }

    public static readonly CheckReportWarningCode IdentityUnavailable = new("IDENTITY_UNAVAILABLE");

    public static readonly CheckReportWarningCode TransactionsUnavailable = new("TRANSACTIONS_UNAVAILABLE");

    public static readonly CheckReportWarningCode UserFraudAlert = new("USER_FRAUD_ALERT");

    public TResult Match<TResult>(Func<TResult> onIdentityUnavailable,
        Func<TResult> onTransactionsUnavailable,
        Func<TResult> onUserFraudAlert,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IdentityUnavailable => onIdentityUnavailable(),
            _ when this == TransactionsUnavailable => onTransactionsUnavailable(),
            _ when this == UserFraudAlert => onUserFraudAlert(),
            _ => otherwise(Value)
        };

    public void Match(Action onIdentityUnavailable,
        Action onTransactionsUnavailable,
        Action onUserFraudAlert,
        Action<string> otherwise)
    {
        if (this == IdentityUnavailable) onIdentityUnavailable();
        else if (this == TransactionsUnavailable) onTransactionsUnavailable();
        else if (this == UserFraudAlert) onUserFraudAlert();
        else otherwise(Value);
    }
}
