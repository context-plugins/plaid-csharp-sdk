using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the transfer.
/// <para>
/// <c>pending</c>: A new transfer was created; it is in the pending state.
/// <c>posted</c>: The transfer has been successfully submitted to the payment network.
/// <c>settled</c>: The transfer was successfully completed by the payment network. Note that funds from received debits are not available to be moved out of the Ledger until the transfer reaches <c>funds_available</c> status. For credit transactions, <c>settled</c> means the funds have been delivered to the receiving bank account. This is the terminal state of a successful credit transfer.
/// <c>funds_available</c>: Funds from the transfer have been released from hold and applied to the ledger's available balance. (Only applicable to ACH debits.) This is the terminal state of a successful debit transfer.
/// <c>cancelled</c>: The transfer was cancelled by the client. This is the terminal state of a cancelled transfer.
/// <c>failed</c>: The transfer failed, no funds were moved. This is the terminal state of a failed transfer.
/// <c>returned</c>: A posted transfer was returned. This is the terminal state of a returned transfer.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferStatus>))]
public sealed record TransferStatus : StringEnum<TransferStatus>
{
    private TransferStatus(string value) : base(value)
    {
    }

    public static readonly TransferStatus Pending = new("pending");

    public static readonly TransferStatus Posted = new("posted");

    public static readonly TransferStatus Settled = new("settled");

    public static readonly TransferStatus FundsAvailable = new("funds_available");

    public static readonly TransferStatus Cancelled = new("cancelled");

    public static readonly TransferStatus Failed = new("failed");

    public static readonly TransferStatus Returned = new("returned");

    public static TransferStatus FromValue(string value) => FromValueCore(value);
}
