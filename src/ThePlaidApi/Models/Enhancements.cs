using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// A grouping of the Plaid produced transaction enhancement fields.
/// </summary>
public record Enhancements
{
    /// <summary>
    /// The name of the primary counterparty, such as the merchant or the financial institution, as extracted by Plaid from the raw description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchant_name")]
    public string? MerchantName { get; init; }

    /// <summary>
    /// The website associated with this transaction, if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("website")]
    public string? Website { get; init; }

    /// <summary>
    /// The URL of a logo associated with this transaction, if available. The logo will always be a 100×100 pixel PNG file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo_url")]
    public string? LogoUrl { get; init; }

    /// <summary>
    /// The check number of the transaction. This field is only populated for check transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("check_number")]
    public string? CheckNumber { get; init; }

    /// <summary>
    /// The channel used to make a payment.
    /// <c>online:</c> transactions that took place online.
    /// <para>
    /// <c>in store:</c> transactions that were made at a physical location.
    /// </para>
    /// <para>
    /// <c>other:</c> transactions that relate to banks, e.g. fees or deposits.
    /// </para>
    /// </summary>
    [JsonPropertyName("payment_channel")]
    public required TransactionPaymentChannel PaymentChannel { get; init; }

    /// <summary>
    /// The ID of the category to which this transaction belongs. For a full list of categories, see <see href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></see>.
    /// </summary>
    [JsonPropertyName("category_id")]
    public required string? CategoryId { get; init; }

    /// <summary>
    /// A hierarchical array of the categories to which this transaction belongs. For a full list of categories, see <see href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></see>.
    /// </summary>
    [JsonPropertyName("category")]
    public required IReadOnlyList<string> Category { get; init; }

    /// <summary>
    /// A representation of where a transaction took place. Location data is provided only for transactions at physical locations, not for online transactions. Location data availability depends primarily on the merchant and is most likely to be populated for transactions at large retail chains; small, local businesses are less likely to have location data available.
    /// </summary>
    [JsonPropertyName("location")]
    public required TransactionLocation Location { get; init; }

    /// <summary>
    /// Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases.
    /// <para>
    /// See the <see href="https://plaid.com/documents/pfc-taxonomy-all.csv">taxonomy CSV file</see> for a full list of personal finance categories. If you are migrating to personal finance categories from the legacy categories, also refer to the <see href="https://plaid.com/docs/transactions/pfc-migration/">migration guide</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_finance_category")]
    public PersonalFinanceCategory? PersonalFinanceCategory { get; init; }

    /// <summary>
    /// The URL of an icon associated with the primary personal finance category. The icon will always be a 100×100 pixel PNG file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personal_finance_category_icon_url")]
    public string? PersonalFinanceCategoryIconUrl { get; init; }

    /// <summary>
    /// The counterparties present in the transaction. Counterparties, such as the merchant or the financial institution, are extracted by Plaid from the raw description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterparties")]
    public IReadOnlyList<Counterparty>? Counterparties { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
