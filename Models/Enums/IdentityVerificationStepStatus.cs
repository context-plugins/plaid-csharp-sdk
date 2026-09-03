using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// The status of a step in the Identity Verification process.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentityVerificationStepStatus>))]
public sealed record IdentityVerificationStepStatus : StringEnum<IdentityVerificationStepStatus>
{
    private IdentityVerificationStepStatus(string value) : base(value)
    {
    }

    public static readonly IdentityVerificationStepStatus Success = new("success");

    public static readonly IdentityVerificationStepStatus Active = new("active");

    public static readonly IdentityVerificationStepStatus Failed = new("failed");

    public static readonly IdentityVerificationStepStatus WaitingForPrerequisite = new("waiting_for_prerequisite");

    public static readonly IdentityVerificationStepStatus NotApplicable = new("not_applicable");

    public static readonly IdentityVerificationStepStatus Skipped = new("skipped");

    public static readonly IdentityVerificationStepStatus Expired = new("expired");

    public static readonly IdentityVerificationStepStatus Canceled = new("canceled");

    public static readonly IdentityVerificationStepStatus PendingReview = new("pending_review");

    public static readonly IdentityVerificationStepStatus ManuallyApproved = new("manually_approved");

    public static readonly IdentityVerificationStepStatus ManuallyRejected = new("manually_rejected");

    public static IdentityVerificationStepStatus FromValue(string value) => FromValueCore(value);
}
