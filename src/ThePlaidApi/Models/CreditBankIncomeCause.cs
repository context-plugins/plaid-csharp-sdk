using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// An error object and associated <c>item_id</c> used to identify a specific Item and error when a batch operation operating on multiple Items has encountered an error in one of the Items.
/// </summary>
public record CreditBankIncomeCause
{
    /// <summary>
    /// A broad categorization of the error. Safe for programmatic use.
    /// </summary>
    [JsonPropertyName("error_type")]
    public required CreditBankIncomeErrorType ErrorType { get; init; }

    /// <summary>
    /// We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. Error fields will be <c>null</c> if no error has occurred.
    /// </summary>
    [JsonPropertyName("error_code")]
    public required string ErrorCode { get; init; }

    /// <summary>
    /// A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use.
    /// </summary>
    [JsonPropertyName("error_message")]
    public required string ErrorMessage { get; init; }

    /// <summary>
    /// A user-friendly representation of the error code. null if the error is not related to user action.
    /// This may change over time and is not safe for programmatic use.
    /// </summary>
    [JsonPropertyName("display_message")]
    public required string DisplayMessage { get; init; }

    /// <summary>
    /// The <c>item_id</c> of the Item associated with this warning.
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
