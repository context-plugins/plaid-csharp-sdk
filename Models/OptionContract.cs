using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// Details about the option security.
/// <para>
/// For the Sandbox environment, this data is currently only available if the Item is using a <see href="https://plaid.com/docs/sandbox/user-custom/">custom Sandbox user</see> and the <c>ticker</c> field of the custom security follows the <see href="https://en.wikipedia.org/wiki/Option_symbol#The_OCC_Option_Symbol">OCC Option Symbol</see> standard with no spaces. For an example of simulating this in Sandbox, see the <see href="https://github.com/plaid/sandbox-custom-users">custom Sandbox GitHub</see>.
/// </para>
/// </summary>
public record OptionContract
{
    /// <summary>
    /// The type of this option contract. It is one of:
    /// <para>
    /// <c>put</c>: for Put option contracts
    /// </para>
    /// <para>
    /// <c>call</c>: for Call option contracts
    /// </para>
    /// </summary>
    [JsonPropertyName("contract_type")]
    public required string ContractType { get; init; }

    /// <summary>
    /// The expiration date for this option contract, in <see href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</see> format.
    /// </summary>
    [JsonPropertyName("expiration_date")]
    public required DateTimeOffset ExpirationDate { get; init; }

    /// <summary>
    /// The strike price for this option contract, per share of security.
    /// </summary>
    [JsonPropertyName("strike_price")]
    public required double StrikePrice { get; init; }

    /// <summary>
    /// The ticker of the underlying security for this option contract.
    /// </summary>
    [JsonPropertyName("underlying_security_ticker")]
    public required string UnderlyingSecurityTicker { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
