using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing an <see href="https://plaid.com/docs/link/web/#onexit">onExit</see> callback from Link. If you are not receiving this field and are instead receiving the deprecated <c>on_exit</c> field, contact your account manager to update your integration.
/// </summary>
public record LinkSessionExit
{
    /// <summary>
    /// Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.
    /// </summary>
    [JsonPropertyName("error")]
    public required Error? Error { get; init; }

    /// <summary>
    /// Displayed if a user exits Link without successfully linking an Item.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required LinkSessionExitMetadata? Metadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
