using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/institutions/search</c> results.
/// </summary>
public record InstitutionsSearchRequestOptions
{
    /// <summary>
    /// Limit results to institutions with or without OAuth login flows. Note that institutions will have <c>oauth</c> set to <c>true</c> if some Items associated with that institution are required to use OAuth flows; institutions in a state of migration to OAuth will have the <c>oauth</c> attribute set to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oauth")]
    public bool? Oauth { get; init; }

    /// <summary>
    /// When true, return the institution's homepage URL, logo and primary brand color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_optional_metadata")]
    public bool? IncludeOptionalMetadata { get; init; }

    /// <summary>
    /// When <c>true</c>, returns metadata related to the Auth product indicating which auth methods are supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_auth_metadata")]
    public bool? IncludeAuthMetadata { get; init; } = false;

    /// <summary>
    /// When <c>true</c>, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_payment_initiation_metadata")]
    public bool? IncludePaymentInitiationMetadata { get; init; } = false;

    /// <summary>
    /// Additional options that will be used to filter institutions by various Payment Initiation configurations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_initiation")]
    public InstitutionsSearchPaymentInitiationOptions? PaymentInitiation { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
