using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// An object containing information about the bank statement upload Item.
/// </summary>
public record CreditBankStatementUploadItem
{
    /// <summary>
    /// The <c>item_id</c> of the Item associated with this webhook, warning, or error
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; init; }

    [JsonPropertyName("bank_statements")]
    public required IReadOnlyList<CreditBankStatementUploadObject> BankStatements { get; init; }

    /// <summary>
    /// Details about the status of the payroll item.
    /// </summary>
    [JsonPropertyName("status")]
    public required PayrollItemStatus? Status { get; init; }

    /// <summary>
    /// Timestamp in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the Item was updated.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset? UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
