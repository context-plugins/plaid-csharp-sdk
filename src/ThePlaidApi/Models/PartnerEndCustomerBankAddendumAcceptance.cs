using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The bank addendum acceptance for the end customer.
/// </summary>
public record PartnerEndCustomerBankAddendumAcceptance
{
    /// <summary>
    /// Denotes whether the end customer has accepted the bank addendum terms.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_accepted")]
    public bool? CustomerAccepted { get; init; }

    /// <summary>
    /// The IP address of the end customer when they accepted the bank addendum.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_ip_address")]
    public string? CustomerIpAddress { get; init; }

    /// <summary>
    /// The timestamp of when the end customer accepted the bank addendum in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customer_agreement_timestamp")]
    public DateTimeOffset? CustomerAgreementTimestamp { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
