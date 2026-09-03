using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Additional information for the <c>kyc_check</c> (Data Source Verification) step. This field will be <c>null</c> unless <c>steps.kyc_check</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.
/// </summary>
public record KycCheckDetails
{
    /// <summary>
    /// The outcome status for the associated Identity Verification attempt's <c>kyc_check</c> step. This field will always have the same value as <c>steps.kyc_check</c>.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// Result summary object specifying how the <c>address</c> field matched.
    /// </summary>
    [JsonPropertyName("address")]
    public required KycCheckAddressSummary Address { get; init; }

    /// <summary>
    /// Result summary object specifying how the <c>name</c> field matched.
    /// </summary>
    [JsonPropertyName("name")]
    public required KycCheckNameSummary Name { get; init; }

    /// <summary>
    /// Result summary object specifying how the <c>date_of_birth</c> field matched.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public required KycCheckDateOfBirthSummary DateOfBirth { get; init; }

    /// <summary>
    /// Result summary object specifying how the <c>id_number</c> field matched.
    /// </summary>
    [JsonPropertyName("id_number")]
    public required KycCheckIdNumberSummary IdNumber { get; init; }

    /// <summary>
    /// Result summary object specifying how the <c>phone</c> field matched.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required KycCheckPhoneSummary PhoneNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
