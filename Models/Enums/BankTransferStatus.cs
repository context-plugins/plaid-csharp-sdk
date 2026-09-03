using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the transfer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankTransferStatus>))]
public sealed record BankTransferStatus : StringEnum<BankTransferStatus>
{
    private BankTransferStatus(string value) : base(value)
    {
    }

    public static readonly BankTransferStatus Pending = new("pending");

    public static readonly BankTransferStatus Posted = new("posted");

    public static readonly BankTransferStatus Cancelled = new("cancelled");

    public static readonly BankTransferStatus Failed = new("failed");

    public static readonly BankTransferStatus Reversed = new("reversed");

    public static BankTransferStatus FromValue(string value) => FromValueCore(value);
}
