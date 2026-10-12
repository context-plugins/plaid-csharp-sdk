using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Metadata about an event that occurred while the user was going through Link
/// </summary>
public record LinkEventMetadata
{
    /// <summary>
    /// The error code that the user encountered. Emitted by <c>ERROR</c>, <c>EXIT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_code")]
    public string? ErrorCode { get; init; }

    /// <summary>
    /// The error message that the user encountered. Emitted by: <c>ERROR</c>, <c>EXIT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; init; }

    /// <summary>
    /// The error type that the user encountered. Emitted by: <c>ERROR</c>, <c>EXIT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_type")]
    public string? ErrorType { get; init; }

    /// <summary>
    /// The status key indicates the point at which the user exited the Link flow. Emitted by: <c>EXIT</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exit_status")]
    public string? ExitStatus { get; init; }

    /// <summary>
    /// The ID of the selected institution. Emitted by: all events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_id")]
    public string? InstitutionId { get; init; }

    /// <summary>
    /// The name of the selected institution. Emitted by: all events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_name")]
    public string? InstitutionName { get; init; }

    /// <summary>
    /// The query used to search for institutions. Emitted by: <c>SEARCH_INSTITUTION</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("institution_search_query")]
    public string? InstitutionSearchQuery { get; init; }

    /// <summary>
    /// The request ID for the last request made by Link. This can be shared with Plaid support to expedite investigation. Emitted by: all events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    /// <summary>
    /// If set, the user has encountered one of the following MFA types: code, device, questions, selections. Emitted by: <c>SUBMIT_MFA</c> and <c>TRANSITION_VIEW</c> when <c>view_name</c> is <c>MFA</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mfa_type")]
    public string? MfaType { get; init; }

    /// <summary>
    /// The name of the view that is being transitioned to. Emitted by: <c>TRANSITION_VIEW</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("view_name")]
    public string? ViewName { get; init; }

    /// <summary>
    /// Either the verification method for a matched institution selected by the user or the Auth Type Select flow type selected by the user. If selection is used to describe selected verification method, then possible values are <c>phoneotp</c> or <c>password</c>;  if selection is used to describe the selected Auth Type Select flow, then possible values are <c>flow_type_manual</c> or <c>flow_type_instant</c>. Emitted by: <c>MATCHED_SELECT_VERIFY_METHOD</c> and <c>SELECT_AUTH_TYPE</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selection")]
    public string? Selection { get; init; }

    /// <summary>
    /// The name of the selected brand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand_name")]
    public string? BrandName { get; init; }

    /// <summary>
    /// The reason this institution was matched. This will be either <c>returning_user</c> or <c>routing_number</c> if emitted by <c>MATCHED_SELECT_INSTITUTION</c>. Otherwise, this will be <c>SAVED_INSTITUTION</c> or <c>AUTO_SELECT_SAVED_INSTITUTION</c> if emitted by <c>SELECT_INSTITUTION</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("match_reason")]
    public string? MatchReason { get; init; }

    /// <summary>
    /// The routing number submitted by the user at the micro-deposits routing number pane. Emitted by <c>SUBMIT_ROUTING_NUMBER</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routing_number")]
    public string? RoutingNumber { get; init; }

    /// <summary>
    /// The account number mask extracted from the user-provided account number. If the user-inputted account number is four digits long, <c>account_number_mask</c> is empty. Emitted by <c>SUBMIT_ACCOUNT_NUMBER</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_number_mask")]
    public string? AccountNumberMask { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
