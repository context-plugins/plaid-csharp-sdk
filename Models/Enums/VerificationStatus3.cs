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
public sealed record VerificationStatus3 : StringEnum<VerificationStatus3>
{
    private VerificationStatus3(string value) : base(value)
    {
    }

    public static readonly VerificationStatus3 VerificationStatusProcessingComplete = new("VERIFICATION_STATUS_PROCESSING_COMPLETE");

    public static readonly VerificationStatus3 VerificationStatusProcessingFailed = new("VERIFICATION_STATUS_PROCESSING_FAILED");

    public static readonly VerificationStatus3 VerificationStatusPendingApproval = new("VERIFICATION_STATUS_PENDING_APPROVAL");

    public static VerificationStatus3 FromValue(string value) => FromValueCore(value);
}
