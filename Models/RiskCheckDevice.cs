using System.Collections.Generic;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;
using ThePlaidApi.Models.Enums;

namespace ThePlaidApi.Models;

/// <summary>
/// Result summary object specifying values for <c>device</c> attributes of risk check.
/// </summary>
public record RiskCheckDevice
{
    /// <summary>
    /// An enum indicating whether a network proxy is present and if so what type it is.
    /// <para>
    /// <c>none_detected</c> indicates the user is not on a detectable proxy network.
    /// </para>
    /// <para>
    /// <c>tor</c> indicates the user was using a Tor browser, which sends encrypted traffic on a decentralized network and is somewhat similar to a VPN (Virtual Private Network).
    /// </para>
    /// <para>
    /// <c>vpn</c> indicates the user is on a VPN (Virtual Private Network)
    /// </para>
    /// <para>
    /// <c>web_proxy</c> indicates the user is on a web proxy server, which may allow them to conceal information such as their IP address or other identifying information.
    /// </para>
    /// <para>
    /// <c>public_proxy</c> indicates the user is on a public web proxy server, which is similar to a web proxy but can be shared by multiple users. This may allow multiple users to appear as if they have the same IP address for instance.
    /// </para>
    /// </summary>
    [JsonPropertyName("ip_proxy_type")]
    public required ProxyType? IpProxyType { get; init; }

    /// <summary>
    /// Count of spam lists the IP address is associated with if known.
    /// </summary>
    [JsonPropertyName("ip_spam_list_count")]
    public required int? IpSpamListCount { get; init; }

    /// <summary>
    /// UTC offset of the timezone associated with the IP address.
    /// </summary>
    [JsonPropertyName("ip_timezone_offset")]
    public required string? IpTimezoneOffset { get; init; }

    /// <summary>
    /// Risk level for the given risk check type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("risk_level")]
    public RiskLevel? RiskLevel { get; init; }

    /// <summary>
    /// List of factors, when available, that contribute towards the risk level of the given risk check type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("factors")]
    public IReadOnlyList<string>? Factors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
