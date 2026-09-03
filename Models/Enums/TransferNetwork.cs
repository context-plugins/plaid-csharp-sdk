using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The network or rails used for the transfer.
/// <para>
/// For transfers submitted as <c>ach</c> or <c>same-day-ach</c>, the Standard ACH cutoff is 8:30 PM Eastern Time.
/// </para>
/// <para>
/// For transfers submitted as <c>same-day-ach</c>, the Same Day ACH cutoff is 3:00 PM Eastern Time.  It is recommended to send the request 15 minutes prior to the cutoff to ensure that it will be processed in time for submission before the cutoff. If the transfer is processed after this cutoff but before the Standard ACH cutoff, it will be sent over Standard ACH rails and will not incur same-day charges; this will apply to both legs of the transfer if applicable. The transaction limit for a Same Day ACH transfer is $1,000,000. Authorization requests sent with an amount greater than $1,000,000 will fail.
/// </para>
/// <para>
/// For transfers submitted as <c>rtp</c>, Plaid will automatically route between the Real-Time Payments (RTP) rail by TCH or FedNow rails as necessary. If a transfer is submitted as <c>rtp</c> and the counterparty account is not eligible for RTP, the <c>/transfer/authorization/create</c> request will fail with an <c>INVALID_FIELD</c> error code. To pre-check to determine whether a counterparty account can support RTP, call <c>/transfer/capabilities/get</c> before calling <c>/transfer/authorization/create</c>.
/// </para>
/// <para>
/// Wire transfers are currently in early availability. To request access to <c>wire</c> as a payment network, contact your account manager. For transfers submitted as <c>wire</c>, the <c>type</c> must be <c>credit</c>; wire debits are not supported. The cutoff to submit a wire payment is 6:30 PM Eastern Time on a business day; wires submitted after that time will be processed on the next business day. The transaction limit for a wire is $999,999.99. Authorization requests sent with an amount greater than $999,999.99 will fail.
/// </para>
/// <para>
/// Support for <c>rfp</c> (request for payment) is currently in closed beta. To learn more, contact your Plaid account manager. For transfers submitted as <c>rfp</c>, the <c>type</c> must be <c>debit</c>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferNetwork>))]
public sealed record TransferNetwork : StringEnum<TransferNetwork>
{
    private TransferNetwork(string value) : base(value)
    {
    }

    public static readonly TransferNetwork Ach = new("ach");

    public static readonly TransferNetwork SameDayAch = new("same-day-ach");

    public static readonly TransferNetwork Rtp = new("rtp");

    public static readonly TransferNetwork Wire = new("wire");

    public static readonly TransferNetwork Rfp = new("rfp");

    public static TransferNetwork FromValue(string value) => FromValueCore(value);
}
