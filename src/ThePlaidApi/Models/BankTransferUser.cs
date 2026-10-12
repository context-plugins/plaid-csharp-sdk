using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The legal name and other information for the account holder.
/// </summary>
public record BankTransferUser
{
    /// <summary>
    /// The account holder's full legal name. If the transfer <c>ach_class</c> is <c>ccd</c>, this should be the business name of the account holder.
    /// </summary>
    [JsonPropertyName("legal_name")]
    public required string LegalName { get; init; }

    /// <summary>
    /// The account holder's email.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email_address")]
    public string? EmailAddress { get; init; }

    /// <summary>
    /// The account holder's routing number. This field is only used in response data. Do not provide this field when making requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routing_number")]
    public string? RoutingNumber { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
