using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A map of permissible purposes to their corresponding use cases.
/// </summary>
public record PartnerEndCustomerCraPurposes
{
    /// <summary>
    /// The list of use cases associated with a given permissible purpose.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("WRITTEN_INSTRUCTION")]
    public PartnerEndCustomerCraUseCases? WrittenInstruction { get; init; }

    /// <summary>
    /// The list of use cases associated with a given permissible purpose.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EXTENSION_OF_CREDIT_OR_ACCOUNT_REVIEW")]
    public PartnerEndCustomerCraUseCases? ExtensionOfCreditOrAccountReview { get; init; }

    /// <summary>
    /// The list of use cases associated with a given permissible purpose.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EMPLOYMENT")]
    public PartnerEndCustomerCraUseCases? Employment { get; init; }

    /// <summary>
    /// The list of use cases associated with a given permissible purpose.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("INSURANCE_UNDERWRITING")]
    public PartnerEndCustomerCraUseCases? InsuranceUnderwriting { get; init; }

    /// <summary>
    /// The list of use cases associated with a given permissible purpose.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LICENSE_ELIGIBILITY")]
    public PartnerEndCustomerCraUseCases? LicenseEligibility { get; init; }

    /// <summary>
    /// The list of use cases associated with a given permissible purpose.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RISK_ASSESSMENT")]
    public PartnerEndCustomerCraUseCases? RiskAssessment { get; init; }

    /// <summary>
    /// The list of use cases associated with a given permissible purpose.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("BUSINESS_NEED_TRANSACTION")]
    public PartnerEndCustomerCraUseCases? BusinessNeedTransaction { get; init; }

    /// <summary>
    /// The list of use cases associated with a given permissible purpose.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("BUSINESS_NEED_ACCOUNT_REVIEW")]
    public PartnerEndCustomerCraUseCases? BusinessNeedAccountReview { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
