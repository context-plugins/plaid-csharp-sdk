using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the recurring transfer.
/// <para>
/// <c>active</c>: The recurring transfer is currently active.
/// <c>cancelled</c>: The recurring transfer was cancelled by the client or Plaid.
/// <c>expired</c>: The recurring transfer has completed all originations according to its recurring schedule.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferRecurringStatus>))]
public sealed record TransferRecurringStatus : StringEnum<TransferRecurringStatus>
{
    private TransferRecurringStatus(string value) : base(value)
    {
    }

    public static readonly TransferRecurringStatus Active = new("active");

    public static readonly TransferRecurringStatus Cancelled = new("cancelled");

    public static readonly TransferRecurringStatus Expired = new("expired");

    public static TransferRecurringStatus FromValue(string value) => FromValueCore(value);
}
