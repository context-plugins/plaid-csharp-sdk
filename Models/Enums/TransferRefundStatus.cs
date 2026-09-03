using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the refund.
/// <para>
/// <c>pending</c>: A new refund was created; it is in the pending state.
/// <c>posted</c>: The refund has been successfully submitted to the payment network.
/// <c>settled</c>: Credits have been refunded to the Plaid linked account.
/// <c>cancelled</c>: The refund was cancelled by the client.
/// <c>failed</c>: The refund has failed.
/// <c>returned</c>: The refund was returned.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferRefundStatus>))]
public sealed record TransferRefundStatus : StringEnum<TransferRefundStatus>
{
    private TransferRefundStatus(string value) : base(value)
    {
    }

    public static readonly TransferRefundStatus Pending = new("pending");

    public static readonly TransferRefundStatus Posted = new("posted");

    public static readonly TransferRefundStatus Cancelled = new("cancelled");

    public static readonly TransferRefundStatus Failed = new("failed");

    public static readonly TransferRefundStatus Settled = new("settled");

    public static readonly TransferRefundStatus Returned = new("returned");

    public static TransferRefundStatus FromValue(string value) => FromValueCore(value);
}
