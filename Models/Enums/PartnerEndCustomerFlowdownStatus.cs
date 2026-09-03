using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the addendum to the Plaid MSA ("flowdown") for the end customer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerFlowdownStatus>))]
public sealed record PartnerEndCustomerFlowdownStatus : StringEnum<PartnerEndCustomerFlowdownStatus>
{
    private PartnerEndCustomerFlowdownStatus(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerFlowdownStatus NotStarted = new("NOT_STARTED");

    public static readonly PartnerEndCustomerFlowdownStatus InReview = new("IN_REVIEW");

    public static readonly PartnerEndCustomerFlowdownStatus Negotiation = new("NEGOTIATION");

    public static readonly PartnerEndCustomerFlowdownStatus Complete = new("COMPLETE");

    public static PartnerEndCustomerFlowdownStatus FromValue(string value) => FromValueCore(value);
}
