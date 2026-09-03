using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// By default, Link will provide limited account filtering: it will only display Institutions that are compatible with all products supplied in the <c>products</c> parameter of <c>/link/token/create</c>, and, if <c>auth</c> is specified in the <c>products</c> array, will also filter out accounts other than <c>checking</c>, <c>savings</c>, and <c>cash management</c> accounts on the Account Select pane. You can further limit the accounts shown in Link by using <c>account_filters</c> to specify the account subtypes to be shown in Link. Only the specified subtypes will be shown. This filtering applies to both the Account Select view (if enabled) and the Institution Select view. Institutions that do not support the selected subtypes will be omitted from Link. To indicate that all subtypes should be shown, use the value <c>"all"</c>. If the <c>account_filters</c> filter is used, any account type for which a filter is not specified will be entirely omitted from Link. For a full list of valid types and subtypes, see the <see href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</see>.
/// <para>
/// The filter may or may not impact the list of accounts shown by the institution in the OAuth account selection flow, depending on the specific institution. If the user selects excluded account subtypes in the OAuth flow, these accounts will not be added to the Item. If the user selects only excluded account subtypes, the link attempt will fail and the user will be prompted to try again.
/// </para>
/// </summary>
public record LinkTokenAccountFilters
{
    /// <summary>
    /// A filter to apply to <c>depository</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("depository")]
    public DepositoryFilter? Depository { get; init; }

    /// <summary>
    /// A filter to apply to <c>credit</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit")]
    public CreditFilter? Credit { get; init; }

    /// <summary>
    /// A filter to apply to <c>loan</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loan")]
    public LoanFilter? Loan { get; init; }

    /// <summary>
    /// A filter to apply to <c>investment</c>-type accounts (or <c>brokerage</c>-type accounts for API versions 2018-05-22 and earlier).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("investment")]
    public InvestmentFilter? Investment { get; init; }

    /// <summary>
    /// A filter to apply to <c>other</c>-type accounts
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("other")]
    public OtherFilter? Other { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
