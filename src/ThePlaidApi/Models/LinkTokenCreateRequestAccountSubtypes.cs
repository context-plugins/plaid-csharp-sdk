using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// By default, Link will only display account types that are compatible with all products supplied in the <c>products</c> parameter of <c>/link/token/create</c>. You can further limit the accounts shown in Link by using <c>account_filters</c> to specify the account subtypes to be shown in Link. Only the specified subtypes will be shown. This filtering applies to both the Account Select view (if enabled) and the Institution Select view. Institutions that do not support the selected subtypes will be omitted from Link. To indicate that all subtypes should be shown, use the value <c>"all"</c>. If the <c>account_filters</c> filter is used, any account type for which a filter is not specified will be entirely omitted from Link.
/// <para>
/// For a full list of valid types and subtypes, see the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</see>.
/// </para>
/// <para>
/// For institutions using OAuth, the filter will not affect the list of institutions or accounts shown by the bank in the OAuth window.
/// </para>
/// </summary>
public record LinkTokenCreateRequestAccountSubtypes
{
    /// <summary>
    /// A filter to apply to <c>depository</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("depository")]
    public LinkTokenCreateDepositoryFilter? Depository { get; init; }

    /// <summary>
    /// A filter to apply to <c>credit</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit")]
    public LinkTokenCreateCreditFilter? Credit { get; init; }

    /// <summary>
    /// A filter to apply to <c>loan</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loan")]
    public LinkTokenCreateLoanFilter? Loan { get; init; }

    /// <summary>
    /// A filter to apply to <c>investment</c>-type accounts (or <c>brokerage</c>-type accounts for API versions 2018-05-22 and earlier).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("investment")]
    public LinkTokenCreateInvestmentFilter? Investment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
