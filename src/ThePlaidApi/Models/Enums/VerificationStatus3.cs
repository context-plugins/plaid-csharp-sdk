using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

/// <summary>
/// <c>VERIFICATION_STATUS_PROCESSING_COMPLETE</c>: The income verification status processing has completed. If the user uploaded multiple documents, this webhook will fire when all documents have finished processing. Call the <c>/income/verification/paystubs/get</c> endpoint and check the document metadata to see which documents were successfully parsed.
/// <para>
/// <c>VERIFICATION_STATUS_PROCESSING_FAILED</c>: A failure occurred when attempting to process the verification documentation.
/// </para>
/// <para>
/// <c>VERIFICATION_STATUS_PENDING_APPROVAL</c>: (deprecated) The income verification has been sent to the user for review.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VerificationStatus3>))]
public sealed record VerificationStatus3 : OpenStringEnum<VerificationStatus3>
{
    private VerificationStatus3(string value) : base(value)
    {
    }

    public static readonly VerificationStatus3 VerificationStatusProcessingComplete = new(
        "VERIFICATION_STATUS_PROCESSING_COMPLETE");

    public static readonly VerificationStatus3 VerificationStatusProcessingFailed = new(
        "VERIFICATION_STATUS_PROCESSING_FAILED");

    public static readonly VerificationStatus3 VerificationStatusPendingApproval = new(
        "VERIFICATION_STATUS_PENDING_APPROVAL");

    public TResult Match<TResult>(Func<TResult> onVerificationStatusProcessingComplete,
        Func<TResult> onVerificationStatusProcessingFailed,
        Func<TResult> onVerificationStatusPendingApproval,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == VerificationStatusProcessingComplete => onVerificationStatusProcessingComplete(),
            _ when this == VerificationStatusProcessingFailed => onVerificationStatusProcessingFailed(),
            _ when this == VerificationStatusPendingApproval => onVerificationStatusPendingApproval(),
            _ => otherwise(Value)
        };

    public void Match(Action onVerificationStatusProcessingComplete,
        Action onVerificationStatusProcessingFailed,
        Action onVerificationStatusPendingApproval,
        Action<string> otherwise)
    {
        if (this == VerificationStatusProcessingComplete) onVerificationStatusProcessingComplete();
        else if (this == VerificationStatusProcessingFailed) onVerificationStatusProcessingFailed();
        else if (this == VerificationStatusPendingApproval) onVerificationStatusPendingApproval();
        else otherwise(Value);
    }
}
