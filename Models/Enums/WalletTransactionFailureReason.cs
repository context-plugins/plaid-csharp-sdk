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
public sealed record WalletTransactionFailureReason : StringEnum<WalletTransactionFailureReason>
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

    public static WalletTransactionFailureReason FromValue(string value) => FromValueCore(value);
}
