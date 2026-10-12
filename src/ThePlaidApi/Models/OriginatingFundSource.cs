using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The original source of the funds. This field is required by local regulation for certain businesses (e.g. money remittance) to send payouts to recipients in the EU and UK.
/// </summary>
public record OriginatingFundSource
{
    /// <summary>
    /// The full name associated with the source of the funds.
    /// </summary>
    [JsonPropertyName("full_name")]
    public required string FullName { get; init; }

    /// <summary>
    /// The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.
    /// </summary>
    [JsonPropertyName("address")]
    public required PaymentInitiationAddress? Address { get; init; }

    /// <summary>
    /// The account number from which the funds are sourced.
    /// </summary>
    [JsonPropertyName("account_number")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The Business Identifier Code, also known as SWIFT code, for this bank account.
    /// </summary>
    [JsonPropertyName("bic")]
    [StringLength(11, MinimumLength = 8)]
    public required string Bic { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
