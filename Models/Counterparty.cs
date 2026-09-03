using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The counterparty, such as the merchant or financial institution, is extracted by Plaid from the raw description.
/// </summary>
public record Counterparty
{
    /// <summary>
    /// The name of the counterparty, such as the merchant or the financial institution, as extracted by Plaid from the raw description.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// A unique, stable, Plaid-generated ID that maps to the counterparty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity_id")]
    public string? EntityId { get; init; }

    /// <summary>
    /// The counterparty type.
    /// <para>
    /// <c>merchant</c>: a provider of goods or services for purchase
    /// <c>financial_institution</c>: a financial entity (bank, credit union, BNPL, fintech)
    /// <c>payment_app</c>: a transfer or P2P app (e.g. Zelle)
    /// <c>marketplace</c>: a marketplace (e.g. DoorDash, Google Play Store)
    /// <c>payment_terminal</c>: a point-of-sale payment terminal (e.g. Square, Toast)
    /// <c>income_source</c>: the payer in an income transaction (e.g., an employer, client, or government agency)
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required CounterpartyType Type { get; init; }

    /// <summary>
    /// The website associated with the counterparty.
    /// </summary>
    [JsonPropertyName("website")]
    public required string? Website { get; init; }

    /// <summary>
    /// The URL of a logo associated with the counterparty, if available. The logo will always be a 100×100 pixel PNG file.
    /// </summary>
    [JsonPropertyName("logo_url")]
    public required string? LogoUrl { get; init; }

    /// <summary>
    /// A description of how confident we are that the provided counterparty is involved in the transaction.
    /// <para>
    /// <c>VERY_HIGH</c>: We recognize this counterparty and we are more than 98% confident that it is involved in this transaction.
    /// <c>HIGH</c>: We recognize this counterparty and we are more than 90% confident that it is involved in this transaction.
    /// <c>MEDIUM</c>: We are moderately confident that this counterparty was involved in this transaction, but some details may differ from our records.
    /// <c>LOW</c>: We didn't find a matching counterparty in our records, so we are returning a cleansed name parsed out of the request description.
    /// <c>UNKNOWN</c>: We don't know the confidence level for this counterparty.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("confidence_level")]
    public string? ConfidenceLevel { get; init; }

    /// <summary>
    /// The phone number associated with the counterparty in E.164 format. If there is a location match (i.e. a street address is returned in the location object), the phone number will be location specific.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public required string? PhoneNumber { get; init; }

    /// <summary>
    /// Account numbers associated with the counterparty, when available.
    /// This field is currently only filled in for select financial institutions in Europe.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_numbers")]
    public CounterpartyNumbers? AccountNumbers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
