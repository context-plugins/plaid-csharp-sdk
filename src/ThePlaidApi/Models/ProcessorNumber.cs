using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing identifying numbers used for making electronic transfers to and from the <c>account</c>. The identifying number type (ACH, EFT, IBAN, or Bacs) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by the <c>account</c> for which auth data has been requested, a null value will be returned.
/// </summary>
public record ProcessorNumber
{
    /// <summary>
    /// Identifying information for transferring money to or from a US account via ACH or wire transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach")]
    public NumbersAchNullable? Ach { get; init; }

    /// <summary>
    /// Identifying information for transferring money to or from a Canadian bank account via EFT.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft")]
    public NumbersEftNullable? Eft { get; init; }

    /// <summary>
    /// Identifying information for transferring money to or from an international bank account via wire transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("international")]
    public NumbersInternationalNullable? International { get; init; }

    /// <summary>
    /// Identifying information for transferring money to or from a UK bank account via Bacs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public NumbersBacsNullable? Bacs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
