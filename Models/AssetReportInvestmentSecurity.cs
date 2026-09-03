using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Investment security associated with the account.
/// </summary>
public record AssetReportInvestmentSecurity
{
    /// <summary>
    /// A unique, Plaid-specific identifier for the security, used to associate securities with holdings. Like all Plaid identifiers, the <c>security_id</c> is case sensitive. The <c>security_id</c> may change if inherent details of the security change due to a corporate action, for example, in the event of a ticker symbol change or CUSIP change.
    /// </summary>
    [JsonPropertyName("security_id")]
    public required string SecurityId { get; init; }

    /// <summary>
    /// A descriptive name for the security, suitable for display.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    /// <summary>
    /// The security's trading symbol for publicly traded securities, and otherwise a short identifier if available.
    /// </summary>
    [JsonPropertyName("ticker_symbol")]
    public required string? TickerSymbol { get; init; }

    /// <summary>
    /// The security type of the holding. Valid security types are:
    /// <para>
    /// <c>cash</c>: Cash, currency, and money market funds
    /// </para>
    /// <para>
    /// <c>cryptocurrency</c>: Digital or virtual currencies
    /// </para>
    /// <para>
    /// <c>derivative</c>: Options, warrants, and other derivative instruments
    /// </para>
    /// <para>
    /// <c>equity</c>: Domestic and foreign equities
    /// </para>
    /// <para>
    /// <c>etf</c>: Multi-asset exchange-traded investment funds
    /// </para>
    /// <para>
    /// <c>fixed income</c>: Bonds and certificates of deposit (CDs)
    /// </para>
    /// <para>
    /// <c>loan</c>: Loans and loan receivables
    /// </para>
    /// <para>
    /// <c>mutual fund</c>: Open- and closed-end vehicles pooling funds of multiple investors
    /// </para>
    /// <para>
    /// <c>other</c>: Unknown or other investment types
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required string? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
