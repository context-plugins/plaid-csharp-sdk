using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Originator's diligence status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferDiligenceStatus>))]
public sealed record TransferDiligenceStatus : OpenStringEnum<TransferDiligenceStatus>
{
    private TransferDiligenceStatus(string value) : base(value)
    {
    }

    public static readonly TransferDiligenceStatus NotSubmitted = new("not_submitted");

    public static readonly TransferDiligenceStatus Submitted = new("submitted");

    public static readonly TransferDiligenceStatus UnderReview = new("under_review");

    public static readonly TransferDiligenceStatus Approved = new("approved");

    public static readonly TransferDiligenceStatus Denied = new("denied");

    public static readonly TransferDiligenceStatus MoreInformationRequired = new("more_information_required");

    public TResult Match<TResult>(Func<TResult> onNotSubmitted,
        Func<TResult> onSubmitted,
        Func<TResult> onUnderReview,
        Func<TResult> onApproved,
        Func<TResult> onDenied,
        Func<TResult> onMoreInformationRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotSubmitted => onNotSubmitted(),
            _ when this == Submitted => onSubmitted(),
            _ when this == UnderReview => onUnderReview(),
            _ when this == Approved => onApproved(),
            _ when this == Denied => onDenied(),
            _ when this == MoreInformationRequired => onMoreInformationRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotSubmitted,
        Action onSubmitted,
        Action onUnderReview,
        Action onApproved,
        Action onDenied,
        Action onMoreInformationRequired,
        Action<string> otherwise)
    {
        if (this == NotSubmitted) onNotSubmitted();
        else if (this == Submitted) onSubmitted();
        else if (this == UnderReview) onUnderReview();
        else if (this == Approved) onApproved();
        else if (this == Denied) onDenied();
        else if (this == MoreInformationRequired) onMoreInformationRequired();
        else otherwise(Value);
    }
}
