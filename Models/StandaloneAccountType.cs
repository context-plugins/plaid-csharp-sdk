using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// The schema below describes the various <c>types</c> and corresponding <c>subtypes</c> that Plaid recognizes and reports for financial institution accounts. For a mapping of supported types and subtypes to Plaid products, see the <see href="https://plaid.com/docs/api/accounts/#account-type--product-support-matrix">Account type / product support matrix</see>.
/// </summary>
public record StandaloneAccountType
{
    /// <summary>
    /// An account type holding cash, in which funds are deposited.
    /// </summary>
    [JsonPropertyName("depository")]
    public required DepositoryAccount Depository { get; init; }

    /// <summary>
    /// A credit card type account.
    /// </summary>
    [JsonPropertyName("credit")]
    public required CreditAccount Credit { get; init; }

    /// <summary>
    /// A loan type account.
    /// </summary>
    [JsonPropertyName("loan")]
    public required LoanAccount Loan { get; init; }

    /// <summary>
    /// An investment account. In API versions 2018-05-22 and earlier, this type is called <c>brokerage</c>.
    /// </summary>
    [JsonPropertyName("investment")]
    public required InvestmentAccountSubtype1 Investment { get; init; }

    /// <summary>
    /// A payroll account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payroll")]
    public PayrollAccount? Payroll { get; init; }

    /// <summary>
    /// Other or unknown account type.
    /// </summary>
    [JsonPropertyName("other")]
    public required string Other { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
