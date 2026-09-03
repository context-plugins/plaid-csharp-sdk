using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the sweep for the transfer.
/// <para>
/// <c>unswept</c>: The transfer hasn't been swept yet.
/// <c>swept</c>: The transfer was swept to the sweep account.
/// <c>swept_settled</c>: Credits are available to be withdrawn or debits have been deducted from the customer's business checking account.
/// <c>return_swept</c>: The transfer was returned, funds were pulled back or pushed back to the sweep account.
/// <c>null</c>: The transfer will never be swept (e.g. if the transfer is cancelled or returned before being swept)
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferSweepStatus>))]
public sealed record TransferSweepStatus : StringEnum<TransferSweepStatus>
{
    private TransferSweepStatus(string value) : base(value)
    {
    }

    public static readonly TransferSweepStatus Unswept = new("unswept");

    public static readonly TransferSweepStatus Swept = new("swept");

    public static readonly TransferSweepStatus SweptSettled = new("swept_settled");

    public static readonly TransferSweepStatus ReturnSwept = new("return_swept");

    public static TransferSweepStatus FromValue(string value) => FromValueCore(value);
}
