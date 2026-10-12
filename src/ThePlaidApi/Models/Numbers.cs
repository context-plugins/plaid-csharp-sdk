using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Account and bank identifier number data used to configure the test account. All values are optional.
/// </summary>
public record Numbers
{
    /// <summary>
    /// Will be used for the account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public string? Account { get; init; }

    /// <summary>
    /// Must be a valid ACH routing number. To test <c>/transfer/capabilities/get</c>, set this to 322271627 to force a <c>true</c> result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach_routing")]
    public string? AchRouting { get; init; }

    /// <summary>
    /// Must be a valid wire transfer routing number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach_wire_routing")]
    public string? AchWireRouting { get; init; }

    /// <summary>
    /// EFT institution number. Must be specified alongside <c>eft_branch</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft_institution")]
    public string? EftInstitution { get; init; }

    /// <summary>
    /// EFT branch number. Must be specified alongside <c>eft_institution</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft_branch")]
    public string? EftBranch { get; init; }

    /// <summary>
    /// Business Identifier Code (BIC). Must be specified alongside <c>international_iban</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("international_bic")]
    public string? InternationalBic { get; init; }

    /// <summary>
    /// International Bank Account Number (IBAN). If no account number is specified via <c>account</c>, will also be used as the account number by default. Must be specified alongside <c>international_bic</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("international_iban")]
    public string? InternationalIban { get; init; }

    /// <summary>
    /// Bacs sort code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs_sort_code")]
    public string? BacsSortCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
