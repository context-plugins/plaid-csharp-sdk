using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Contains details about a security
/// </summary>
public record Security
{
    /// <summary>
    /// A unique, Plaid-specific identifier for the security, used to associate securities with holdings. Like all Plaid identifiers, the <c>security_id</c> is case sensitive. The <c>security_id</c> may change if inherent details of the security change due to a corporate action, for example, in the event of a ticker symbol change or CUSIP change.
    /// </summary>
    [JsonPropertyName("security_id")]
    public required string SecurityId { get; init; }

    /// <summary>
    /// 12-character ISIN, a globally unique securities identifier. A verified CUSIP Global Services license is required to receive this data. This field will be null by default for new customers, and null for existing customers starting March 12, 2024. If you would like access to this field, please start the verification process <see href="https://docs.google.com/forms/d/e/1FAIpQLSd9asHEYEfmf8fxJTHZTAfAzW4dugsnSu-HS2J51f1mxwd6Sw/viewform">here</see>.
    /// </summary>
    [JsonPropertyName("isin")]
    public required string? Isin { get; init; }

    /// <summary>
    /// 9-character CUSIP, an identifier assigned to North American securities. A verified CUSIP Global Services license is required to receive this data. This field will be null by default for new customers, and null for existing customers starting March 12, 2024. If you would like access to this field, please start the verification process <see href="https://docs.google.com/forms/d/e/1FAIpQLSd9asHEYEfmf8fxJTHZTAfAzW4dugsnSu-HS2J51f1mxwd6Sw/viewform">here</see>.
    /// </summary>
    [JsonPropertyName("cusip")]
    public required string? Cusip { get; init; }

    /// <summary>
    /// (Deprecated) 7-character SEDOL, an identifier assigned to securities in the UK.
    /// </summary>
    [JsonPropertyName("sedol")]
    public required string? Sedol { get; init; }

    /// <summary>
    /// An identifier given to the security by the institution
    /// </summary>
    [JsonPropertyName("institution_security_id")]
    public required string? InstitutionSecurityId { get; init; }

    /// <summary>
    /// If <c>institution_security_id</c> is present, this field indicates the Plaid <c>institution_id</c> of the institution to whom the identifier belongs.
    /// </summary>
    [JsonPropertyName("institution_id")]
    public required string? InstitutionId { get; init; }

    /// <summary>
    /// In certain cases, Plaid will provide the ID of another security whose performance resembles this security, typically when the original security has low volume, or when a private security can be modeled with a publicly traded security.
    /// </summary>
    [JsonPropertyName("proxy_security_id")]
    public required string? ProxySecurityId { get; init; }

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
    /// Indicates that a security is a highly liquid asset and can be treated like cash.
    /// </summary>
    [JsonPropertyName("is_cash_equivalent")]
    public required bool? IsCashEquivalent { get; init; }

    /// <summary>
    /// The security type of the holding.
    /// <para>
    /// In rare instances, a null value is returned when institutional data is insufficient to determine the security type.
    /// </para>
    /// <para>
    /// Valid security types are:
    /// </para>
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

    /// <summary>
    /// The security subtype of the holding.
    /// <para>
    /// In rare instances, a null value is returned when institutional data is insufficient to determine the security subtype.
    /// </para>
    /// <para>
    /// Possible values: <c>asset backed security</c>, <c>bill</c>, <c>bond</c>, <c>bond with warrants</c>, <c>cash</c>, <c>cash management bill</c>, <c>common stock</c>, <c>convertible bond</c>, <c>convertible equity</c>, <c>cryptocurrency</c>, <c>depositary receipt</c>, <c>depositary receipt on debt</c>, <c>etf</c>, <c>float rating note</c>, <c>fund of funds</c>, <c>hedge fund</c>, <c>limited partnership unit</c>, <c>medium term note</c>, <c>money market debt</c>, <c>mortgage backed security</c>, <c>municipal bond</c>, <c>mutual fund</c>, <c>note</c>, <c>option</c>, <c>other</c>, <c>preferred convertible</c>, <c>preferred equity</c>, <c>private equity fund</c>, <c>real estate investment trust</c>, <c>structured equity product</c>, <c>treasury inflation protected securities</c>, <c>unit</c>, <c>warrant</c>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subtype")]
    public string? Subtype { get; init; }

    /// <summary>
    /// Price of the security at the close of the previous trading session. Null for non-public securities.
    /// <para>
    /// If the security is a foreign currency this field will be updated daily and will be priced in USD.
    /// </para>
    /// <para>
    /// If the security is a cryptocurrency, this field will be updated multiple times a day. As crypto prices can fluctuate quickly and data may become stale sooner than other asset classes, refer to <c>update_datetime</c> with the time when the price was last updated.
    /// </para>
    /// </summary>
    [JsonPropertyName("close_price")]
    public required double? ClosePrice { get; init; }

    /// <summary>
    /// Date for which <c>close_price</c> is accurate. Always <c>null</c> if <c>close_price</c> is <c>null</c>.
    /// </summary>
    [JsonPropertyName("close_price_as_of")]
    public required DateTimeOffset? ClosePriceAsOf { get; init; }

    /// <summary>
    /// Date and time at which <c>close_price</c> is accurate, in ISO 8601 format (YYYY-MM-DDTHH:mm:ssZ). Always <c>null</c> if <c>close_price</c> is <c>null</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("update_datetime")]
    public DateTimeOffset? UpdateDatetime { get; init; }

    /// <summary>
    /// The ISO-4217 currency code of the price given. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.
    /// </summary>
    [JsonPropertyName("iso_currency_code")]
    public required string? IsoCurrencyCode { get; init; }

    /// <summary>
    /// The unofficial currency code associated with the security. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
    /// <para>
    /// See the <see href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</see> for a full listing of supported <c>unofficial_currency_code</c>s.
    /// </para>
    /// </summary>
    [JsonPropertyName("unofficial_currency_code")]
    public required string? UnofficialCurrencyCode { get; init; }

    /// <summary>
    /// The ISO-10383 Market Identifier Code of the exchange or market in which the security is being traded.
    /// </summary>
    [JsonPropertyName("market_identifier_code")]
    public required string? MarketIdentifierCode { get; init; }

    /// <summary>
    /// The sector classification of the security, such as Finance, Health Technology, etc.
    /// <para>
    /// For a complete list of possible values, please refer to the <see href="https://docs.google.com/spreadsheets/d/1L7aXUdqLhxgM8qe7hK67qqKXiUdQqILpwZ0LpxvCVnc">"Sectors and Industries" spreadsheet</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("sector")]
    public required string? Sector { get; init; }

    /// <summary>
    /// The industry classification of the security, such as Biotechnology, Airlines, etc.
    /// <para>
    /// For a complete list of possible values, please refer to the <see href="https://docs.google.com/spreadsheets/d/1L7aXUdqLhxgM8qe7hK67qqKXiUdQqILpwZ0LpxvCVnc">"Sectors and Industries" spreadsheet</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("industry")]
    public required string? Industry { get; init; }

    /// <summary>
    /// The ISO-10962 Classification of Financial Instruments Code used to classify the security based on its structure and function.
    /// </summary>
    [JsonPropertyName("cfi_code")]
    public required string? CfiCode { get; init; }

    /// <summary>
    /// 12-character FIGI, a unique Financial Instrument Global Identifier assigned to securities that is immutable and stays consistent across most corporate actions. This is an open data standard issued by the Object Management Group and administered by Bloomberg L.P.
    /// </summary>
    [JsonPropertyName("figi")]
    public required string? Figi { get; init; }

    /// <summary>
    /// Details about the option security.
    /// <para>
    /// For the Sandbox environment, this data is currently only available if the Item is using a <see href="https://plaid.com/docs/sandbox/user-custom/">custom Sandbox user</see> and the <c>ticker</c> field of the custom security follows the <see href="https://en.wikipedia.org/wiki/Option_symbol#The_OCC_Option_Symbol">OCC Option Symbol</see> standard with no spaces. For an example of simulating this in Sandbox, see the <see href="https://github.com/plaid/sandbox-custom-users">custom Sandbox GitHub</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("option_contract")]
    public required OptionContract? OptionContract { get; init; }

    /// <summary>
    /// Details about the fixed income security.
    /// </summary>
    [JsonPropertyName("fixed_income")]
    public required FixedIncome? FixedIncome { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
