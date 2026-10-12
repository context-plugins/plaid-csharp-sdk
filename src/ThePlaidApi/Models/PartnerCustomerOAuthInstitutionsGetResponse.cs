using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Response schema for <c>/partner/customer/oauth_institutions/get</c>.
/// </summary>
public record PartnerCustomerOAuthInstitutionsGetResponse
{
    /// <summary>
    /// The status of the addendum to the Plaid MSA ("flowdown") for the end customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flowdown_status")]
    public PartnerEndCustomerFlowdownStatus? FlowdownStatus { get; init; }

    /// <summary>
    /// The status of the end customer's security questionnaire.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("questionnaire_status")]
    public PartnerEndCustomerQuestionnaireStatus? QuestionnaireStatus { get; init; }

    /// <summary>
    /// The OAuth institutions with which the end customer's application is being registered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institutions")]
    public IReadOnlyList<PartnerEndCustomerOAuthInstitution>? Institutions { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
