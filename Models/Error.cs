using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
/// </summary>
public record Error
{
    /// <summary>
    /// A broad categorization of the error. Safe for programmatic use.
    /// </summary>
    [JsonPropertyName("error_type")]
    public required PlaidErrorType ErrorType { get; init; }

    /// <summary>
    /// The particular error code. Safe for programmatic use.
    /// </summary>
    [JsonPropertyName("error_code")]
    public required string ErrorCode { get; init; }

    /// <summary>
    /// The specific reason for the error code. Currently, reasons are only supported for OAuth-based item errors; <c>null</c> will be returned otherwise. Safe for programmatic use.
    /// <para>
    /// Possible values:
    /// <c>OAUTH_INVALID_TOKEN</c>: The user's OAuth connection to this institution has been invalidated.
    /// </para>
    /// <para>
    /// <c>OAUTH_CONSENT_EXPIRED</c>: The user's access consent for this OAuth connection to this institution has expired.
    /// </para>
    /// <para>
    /// <c>OAUTH_USER_REVOKED</c>: The user's OAuth connection to this institution is invalid because the user revoked their connection.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error_code_reason")]
    public string? ErrorCodeReason { get; init; }

    /// <summary>
    /// A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use.
    /// </summary>
    [JsonPropertyName("error_message")]
    public required string ErrorMessage { get; init; }

    /// <summary>
    /// A user-friendly representation of the error code. <c>null</c> if the error is not related to user action.
    /// <para>
    /// This may change over time and is not safe for programmatic use.
    /// </para>
    /// </summary>
    [JsonPropertyName("display_message")]
    public required string? DisplayMessage { get; init; }

    /// <summary>
    /// A unique ID identifying the request, to be used for troubleshooting purposes. This field will be omitted in errors provided by webhooks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("request_id")]
    public string? RequestId { get; init; }

    /// <summary>
    /// In this product, a request can pertain to more than one Item. If an error is returned for such a request, <c>causes</c> will return an array of errors containing a breakdown of these errors on the individual Item level, if any can be identified.
    /// <para>
    /// <c>causes</c> will be provided for the <c>error_type</c> <c>ASSET_REPORT_ERROR</c> or <c>CHECK_REPORT_ERROR</c>. <c>causes</c> will also not be populated inside an error nested within a <c>warning</c> object.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("causes")]
    public IReadOnlyList<object>? Causes { get; init; }

    /// <summary>
    /// The HTTP status code associated with the error. This will only be returned in the response body when the error information is provided via a webhook.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public int? Status { get; init; }

    /// <summary>
    /// The URL of a Plaid documentation page with more information about the error
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentation_url")]
    public string? DocumentationUrl { get; init; }

    /// <summary>
    /// Suggested steps for resolving the error
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suggested_action")]
    public string? SuggestedAction { get; init; }

    /// <summary>
    /// A list of the account subtypes that were requested via the <c>account_filters</c> parameter in <c>/link/token/create</c>. Currently only populated for <c>NO_ACCOUNTS</c> errors from Items with <c>investments_auth</c> as an enabled product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("required_account_subtypes")]
    public IReadOnlyList<string>? RequiredAccountSubtypes { get; init; }

    /// <summary>
    /// A list of the account subtypes that were extracted but did not match the requested subtypes via the <c>account_filters</c> parameter in <c>/link/token/create</c>. Currently only populated for <c>NO_ACCOUNTS</c> errors from Items with <c>investments_auth</c> as an enabled product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provided_account_subtypes")]
    public IReadOnlyList<string>? ProvidedAccountSubtypes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
