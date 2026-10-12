using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An error object plus the <c>item_id</c> of an Item that the end user can repair via Link <see href="https://plaid.com/docs/link/update-mode">update mode</see>. The <c>error_code</c> will be in the <c>ITEM_LOGIN_REQUIRED</c> family.
/// </summary>
public record CheckReportRepairableItem
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
    /// A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use.
    /// </summary>
    [JsonPropertyName("error_message")]
    public required string ErrorMessage { get; init; }

    /// <summary>
    /// A user-friendly representation of the error code. <c>null</c> if the error is not related to user action.
    /// </summary>
    [JsonPropertyName("display_message")]
    public required string? DisplayMessage { get; init; }

    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
