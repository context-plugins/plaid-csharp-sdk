using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing identifying numbers used for making electronic transfers to and from the <c>accounts</c>. The identifying number type (ACH, EFT, IBAN, or Bacs) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by any <c>accounts</c> for which data has been requested, the array for that type will be empty.
/// </summary>
public record AuthGetNumbers
{
    /// <summary>
    /// An array of ACH numbers identifying accounts.
    /// </summary>
    [JsonPropertyName("ach")]
    public required IReadOnlyList<NumbersAch> Ach { get; init; }

    /// <summary>
    /// An array of EFT numbers identifying accounts.
    /// </summary>
    [JsonPropertyName("eft")]
    public required IReadOnlyList<NumbersEft> Eft { get; init; }

    /// <summary>
    /// An array of IBAN numbers identifying accounts.
    /// </summary>
    [JsonPropertyName("international")]
    public required IReadOnlyList<NumbersInternational> International { get; init; }

    /// <summary>
    /// An array of Bacs numbers identifying accounts.
    /// </summary>
    [JsonPropertyName("bacs")]
    public required IReadOnlyList<NumbersBacs> Bacs { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
