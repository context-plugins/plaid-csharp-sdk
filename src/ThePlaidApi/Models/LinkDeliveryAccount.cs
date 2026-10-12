using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Information related to account attached to the connected Item
/// </summary>
public record LinkDeliveryAccount
{
    /// <summary>
    /// The Plaid <c>account_id</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The official account name
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts. It may also not match the mask that the bank displays to the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mask")]
    public string? Mask { get; init; }

    /// <summary>
    /// The account type. See the <see href="https://plaid.com/docs/api/accounts/#account-type-schema">Account schema</see> for a full list of possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The account subtype. See the <see href="https://plaid.com/docs/api/accounts/#account-type-schema">Account schema</see> for a full list of possible values
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subtype")]
    public string? Subtype { get; init; }

    /// <summary>
    /// Indicates an Item's micro-deposit-based verification or database verification status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verification_status")]
    public LinkDeliveryVerificationStatus? VerificationStatus { get; init; }

    /// <summary>
    /// If micro-deposit verification is being used, indicates whether the account being verified is a <c>business</c> or <c>personal</c> account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("class_type")]
    public string? ClassType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
