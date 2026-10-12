using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Data about the employee.
/// </summary>
public record CreditPayStubEmployee
{
    /// <summary>
    /// Address on the pay stub.
    /// </summary>
    [JsonPropertyName("address")]
    public required CreditPayStubAddress Address { get; init; }

    /// <summary>
    /// The name of the employee.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    /// <summary>
    /// Marital status of the employee - one of <c>SINGLE</c>, <c>MARRIED</c>, or <c>NOT LISTED</c>.
    /// </summary>
    [JsonPropertyName("marital_status")]
    public required string? MaritalStatus { get; init; }

    /// <summary>
    /// Taxpayer ID of the individual receiving the paystub.
    /// </summary>
    [JsonPropertyName("taxpayer_id")]
    public required PayStubTaxpayerId TaxpayerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
