using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The error code of a failed transaction. Error codes include:
/// <c>EXTERNAL_SYSTEM</c>: The transaction was declined by an external system.
/// <c>EXPIRED</c>: The transaction request has expired.
/// <c>CANCELLED</c>: The transaction request was rescinded.
/// <c>INVALID</c>: The transaction did not meet certain criteria, such as an inactive account or no valid counterparty, etc.
/// <c>ACCOUNT_INVALID</c>: The transaction could not be processed because the wallet account is invalid or inactive.
/// <c>AUTHENTICATION_FAILED</c>: The transaction could not be processed because authentication with the wallet provider failed.
/// <c>UNKNOWN</c>: The transaction was unsuccessful, but the exact cause is unknown.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WalletTransactionFailureReason>))]
public sealed record WalletTransactionFailureReason : OpenStringEnum<WalletTransactionFailureReason>
{
    private WalletTransactionFailureReason(string value) : base(value)
    {
    }

    public static readonly WalletTransactionFailureReason ExternalSystem = new("EXTERNAL_SYSTEM");

    public static readonly WalletTransactionFailureReason Expired = new("EXPIRED");

    public static readonly WalletTransactionFailureReason Cancelled = new("CANCELLED");

    public static readonly WalletTransactionFailureReason Invalid = new("INVALID");

    public static readonly WalletTransactionFailureReason AccountInvalid = new("ACCOUNT_INVALID");

    public static readonly WalletTransactionFailureReason AuthenticationFailed = new("AUTHENTICATION_FAILED");

    public static readonly WalletTransactionFailureReason Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onExternalSystem,
        Func<TResult> onExpired,
        Func<TResult> onCancelled,
        Func<TResult> onInvalid,
        Func<TResult> onAccountInvalid,
        Func<TResult> onAuthenticationFailed,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ExternalSystem => onExternalSystem(),
            _ when this == Expired => onExpired(),
            _ when this == Cancelled => onCancelled(),
            _ when this == Invalid => onInvalid(),
            _ when this == AccountInvalid => onAccountInvalid(),
            _ when this == AuthenticationFailed => onAuthenticationFailed(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onExternalSystem,
        Action onExpired,
        Action onCancelled,
        Action onInvalid,
        Action onAccountInvalid,
        Action onAuthenticationFailed,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == ExternalSystem) onExternalSystem();
        else if (this == Expired) onExpired();
        else if (this == Cancelled) onCancelled();
        else if (this == Invalid) onInvalid();
        else if (this == AccountInvalid) onAccountInvalid();
        else if (this == AuthenticationFailed) onAuthenticationFailed();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
