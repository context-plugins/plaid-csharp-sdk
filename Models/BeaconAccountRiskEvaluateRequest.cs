using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// BeaconAccountRiskEvaluateRequest defines the request schema for <c>/beacon/account_risk/v1/evaluate</c>
/// </summary>
public record BeaconAccountRiskEvaluateRequest
{
    /// <summary>
    /// Your Plaid API <c>client_id</c>. The <c>client_id</c> is required and may be provided either in the <c>PLAID-CLIENT-ID</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Your Plaid API <c>secret</c>. The <c>secret</c> is required and may be provided either in the <c>PLAID-SECRET</c> header or as part of a request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The access token associated with the Item for which data is being requested.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; init; }

    /// <summary>
    /// An optional object to filter <c>/beacon/account_risk/v1/evaluate</c> results to a subset of the accounts on the linked Item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public BeaconAccountRiskEvaluateRequestOptions? Options { get; init; }

    /// <summary>
    /// A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple evaluations and/or multiple linked accounts. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_user_id")]
    [StringLength(36, MinimumLength = 1)]
    public string? ClientUserId { get; init; }

    /// <summary>
    /// Unique identifier of what you are looking to evaluate (account add, information change, etc.) to allow us to tie the activity to the decisions and possible fraud outcome sent via our feedback endpoints. You can use your internal request ID or similar.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_evaluation_id")]
    public string? ClientEvaluationId { get; init; }

    /// <summary>
    /// Description of the reason you want to evaluate risk.
    /// <c>ONBOARDING</c>: user links a first bank account as part of the onboarding flow of your platform.
    /// <c>NEW_ACCOUNT</c>: user links another bank account or replaces the currently linked bank account on your platform.
    /// <c>INFORMATION_CHANGE</c>: user changes their information on your platform, e.g., updating their phone number.
    /// <c>DORMANT_USER</c>:  you decide to re-evaluate a user that becomes active after a period of inactivity.
    /// <c>OTHER</c>: any other reasons not listed here
    /// Possible values:  <c>ONBOARDING</c>, <c>NEW_ACCOUNT</c>, <c>INFORMATION_CHANGE</c>, <c>DORMANT_USER</c>, <c>OTHER</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("evaluation_reason")]
    public BeaconAccountRiskEvaluateEvaluationReason? EvaluationReason { get; init; }

    /// <summary>
    /// Details about the end user's device. These fields are optional, but strongly recommended to increase the accuracy of results when using Signal Transaction Scores. When using a Balance-only Ruleset, these fields are ignored if the Signal Addendum has been signed; if it has not been signed, using these fields will result in an error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device")]
    public SignalEvaluateDevice? Device { get; init; }

    /// <summary>
    /// The time the event for evaluation has occurred. Populate this field for backfilling data. If you don't populate this field, we'll use the timestamp at the time of receipt. Use ISO 8601 format (YYYY-MM-DDTHH:mm:ssZ).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("evaluate_time")]
    public string? EvaluateTime { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
