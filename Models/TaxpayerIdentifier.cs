using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Information about the Taxpayer identification values assigned to the individual or legal entity.
/// </summary>
public record TaxpayerIdentifier
{
    /// <summary>
    /// A value from a MISMO prescribed list that classifies identification numbers used by the Internal Revenue Service (IRS) in the administration of tax laws. A Social Security number (SSN) is issued by the SSA; all other taxpayer identification numbers are issued by the IRS.
    /// </summary>
    [JsonPropertyName("TaxpayerIdentifierType")]
    public required TaxpayerIdentifierType? TaxpayerIdentifierType { get; init; }

    /// <summary>
    /// The value of the taxpayer identifier as assigned by the IRS to the individual or legal entity.
    /// </summary>
    [JsonPropertyName("TaxpayerIdentifierValue")]
    public required string? TaxpayerIdentifierValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
