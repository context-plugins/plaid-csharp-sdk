using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The response schema for <c>/beacon/user/account_insights/get</c>
/// </summary>
public record BeaconUserAccountInsightsGetResponse
{
    /// <summary>
    /// ID of the associated Beacon User.
    /// </summary>
    [JsonPropertyName("beacon_user_id")]
    public required string BeaconUserId { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// An ISO8601 formatted timestamp. This field indicates the last time the resource was modified.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// A collection of Bank Accounts linked to an Item that is associated with this Beacon User.
    /// </summary>
    [JsonPropertyName("bank_account_insights")]
    public required BeaconBankAccounts BankAccountInsights { get; init; }

    /// <summary>
    /// A unique identifier for the request, which can be used for troubleshooting. This identifier, like all Plaid identifiers, is case sensitive.
    /// </summary>
    [JsonPropertyName("request_id")]
    public required string RequestId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
