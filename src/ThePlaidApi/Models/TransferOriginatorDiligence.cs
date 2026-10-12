using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// The diligence information for the originator.
/// </summary>
public record TransferOriginatorDiligence
{
    /// <summary>
    /// The business name of the originator.
    /// </summary>
    [JsonPropertyName("dba")]
    public required string Dba { get; init; }

    /// <summary>
    /// The tax ID of the originator.
    /// </summary>
    [JsonPropertyName("tax_id")]
    [MinLength(1)]
    public required string TaxId { get; init; }

    /// <summary>
    /// Specifies the originator's expected usage of credits. For all dollar amounts, use a decimal string with two digits of precision e.g. "10.00". This field is required if the originator is expected to process credit transfers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit_usage_configuration")]
    public TransferCreditUsageConfiguration? CreditUsageConfiguration { get; init; }

    /// <summary>
    /// Specifies the originator's expected usage of debits. For all dollar amounts, use a decimal string with two digits of precision e.g. "10.00". This field is required if the originator is expected to process debit transfers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debit_usage_configuration")]
    public TransferDebitUsageConfiguration? DebitUsageConfiguration { get; init; }

    /// <summary>
    /// The originator's address.
    /// </summary>
    [JsonPropertyName("address")]
    public required TransferOriginatorAddress Address { get; init; }

    /// <summary>
    /// The website of the originator.
    /// </summary>
    [JsonPropertyName("website")]
    public required string Website { get; init; }

    /// <summary>
    /// The NAICS code of the originator.
    /// </summary>
    [JsonPropertyName("naics_code")]
    [StringLength(6, MinimumLength = 6)]
    public required string NaicsCode { get; init; }

    /// <summary>
    /// The originator's funding account, linked with Plaid Link or <c>/transfer/migrate_account</c>.
    /// </summary>
    [JsonPropertyName("funding_account")]
    public required TransferFundingAccount FundingAccount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
