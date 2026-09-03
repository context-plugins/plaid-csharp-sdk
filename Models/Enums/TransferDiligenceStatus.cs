using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// Originator's diligence status.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferDiligenceStatus>))]
public sealed record TransferDiligenceStatus : StringEnum<TransferDiligenceStatus>
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

    public static TransferDiligenceStatus FromValue(string value) => FromValueCore(value);
}
