using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An optional object to filter <c>/institutions/get</c> results.
/// </summary>
public record InstitutionsGetRequestOptions
{
    /// <summary>
    /// Filter the Institutions based on which products they support. Will only return institutions that support all listed products. When filtering based on <c>auth</c>, an institution must support Instant Auth to match the criterion. To filter for Signal Transaction Scores support, use <c>balance</c>. To filter for Transfer support, use <c>auth</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("products")]
    [MinLength(1)]
    public IReadOnlyList<Products?>? Products { get; init; }

    /// <summary>
    /// Specify an array of routing numbers to filter institutions. The response will only return institutions that match all of the routing numbers in the array. Routing number records used for this matching are generally comprehensive; however, failure to match a given routing number to an institution does not necessarily mean that the institution is unsupported by Plaid. Invalid routing numbers (numbers that are not 9 digits in length or do not have a valid checksum) will be filtered from the array before the response is processed. If all provided routing numbers are invalid, an <c>INVALID_REQUEST</c> error with the code of <c>INVALID_FIELD</c> will be returned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routing_numbers")]
    public IReadOnlyList<string?>? RoutingNumbers { get; init; }

    /// <summary>
    /// Limit results to institutions with or without OAuth login flows. Note that institutions will have <c>oauth</c> set to <c>true</c> if some Items associated with that institution are required to use OAuth flows; institutions in a state of migration to OAuth will have the <c>oauth</c> attribute set to <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("oauth")]
    public bool? Oauth { get; init; }

    /// <summary>
    /// When <c>true</c>, return the institution's homepage URL, logo and primary brand color. Not all institutions' logos are available.
    /// <para>
    /// Note that Plaid does not own any of the logos shared by the API, and that by accessing or using these logos, you agree that you are doing so at your own risk and will, if necessary, obtain all required permissions from the appropriate rights holders and adhere to any applicable usage guidelines. Plaid disclaims all express or implied warranties with respect to the logos.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("include_optional_metadata")]
    public bool? IncludeOptionalMetadata { get; init; }

    /// <summary>
    /// When <c>true</c>, returns metadata related to the Auth product indicating which auth methods are supported.
    /// </summary>
    [JsonPropertyName("include_auth_metadata")]
    public bool? IncludeAuthMetadata { get; init; } = false;

    /// <summary>
    /// When <c>true</c>, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.
    /// </summary>
    [JsonPropertyName("include_payment_initiation_metadata")]
    public bool? IncludePaymentInitiationMetadata { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
