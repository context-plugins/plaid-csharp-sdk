using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object representing payroll data.
/// </summary>
public record PayrollIncomeObject
{
    /// <summary>
    /// ID of the payroll provider account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string? AccountId { get; init; }

    /// <summary>
    /// Array of pay stubs for the user.
    /// </summary>
    [JsonPropertyName("pay_stubs")]
    public required IReadOnlyList<CreditPayStub> PayStubs { get; init; }

    /// <summary>
    /// Array of tax form W-2s.
    /// </summary>
    [JsonPropertyName("w2s")]
    public required IReadOnlyList<CreditW2> W2S { get; init; }

    /// <summary>
    /// Array of tax form 1099s.
    /// </summary>
    [JsonPropertyName("form1099s")]
    public required IReadOnlyList<Credit1099> Form1099S { get; init; }

    /// <summary>
    /// Array of Form I-20 US immigration student documents.
    /// </summary>
    [JsonPropertyName("i20s")]
    public required IReadOnlyList<CreditI20> I20S { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
