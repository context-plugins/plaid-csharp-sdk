using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of the addendum to the Plaid MSA ("flowdown") for the end customer.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PartnerEndCustomerFlowdownStatus>))]
public sealed record PartnerEndCustomerFlowdownStatus : OpenStringEnum<PartnerEndCustomerFlowdownStatus>
{
    private PartnerEndCustomerFlowdownStatus(string value) : base(value)
    {
    }

    public static readonly PartnerEndCustomerFlowdownStatus NotStarted = new("NOT_STARTED");

    public static readonly PartnerEndCustomerFlowdownStatus InReview = new("IN_REVIEW");

    public static readonly PartnerEndCustomerFlowdownStatus Negotiation = new("NEGOTIATION");

    public static readonly PartnerEndCustomerFlowdownStatus Complete = new("COMPLETE");

    public TResult Match<TResult>(Func<TResult> onNotStarted,
        Func<TResult> onInReview,
        Func<TResult> onNegotiation,
        Func<TResult> onComplete,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotStarted => onNotStarted(),
            _ when this == InReview => onInReview(),
            _ when this == Negotiation => onNegotiation(),
            _ when this == Complete => onComplete(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotStarted,
        Action onInReview,
        Action onNegotiation,
        Action onComplete,
        Action<string> otherwise)
    {
        if (this == NotStarted) onNotStarted();
        else if (this == InReview) onInReview();
        else if (this == Negotiation) onNegotiation();
        else if (this == Complete) onComplete();
        else otherwise(Value);
    }
}
