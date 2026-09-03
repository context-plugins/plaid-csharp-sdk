using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the transaction.
/// <para>
/// <c>AUTHORISING</c>: The transaction is being processed for validation and compliance.
/// </para>
/// <para>
/// <c>INITIATED</c>: The transaction has been initiated and is currently being processed.
/// </para>
/// <para>
/// <c>EXECUTED</c>: The transaction has been successfully executed and is considered complete. This is only applicable for debit transactions.
/// </para>
/// <para>
/// <c>SETTLED</c>: The transaction has settled and funds are available for use. This is only applicable for credit transactions. A transaction will typically settle within seconds to several days, depending on which payment rail is used.
/// </para>
/// <para>
/// <c>FAILED</c>: The transaction failed to process successfully. This is a terminal status.
/// </para>
/// <para>
/// <c>BLOCKED</c>: The transaction has been blocked for violating compliance rules. This is a terminal status.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WalletTransactionStatus>))]
public sealed record WalletTransactionStatus : StringEnum<WalletTransactionStatus>
{
    private WalletTransactionStatus(string value) : base(value)
    {
    }

    public static readonly WalletTransactionStatus Authorising = new("AUTHORISING");

    public static readonly WalletTransactionStatus Initiated = new("INITIATED");

    public static readonly WalletTransactionStatus Executed = new("EXECUTED");

    public static readonly WalletTransactionStatus Settled = new("SETTLED");

    public static readonly WalletTransactionStatus Blocked = new("BLOCKED");

    public static readonly WalletTransactionStatus Failed = new("FAILED");

    public static WalletTransactionStatus FromValue(string value) => FromValueCore(value);
}
