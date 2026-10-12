using System;
using System.Text.Json.Serialization;
using ThePlaidApi.Core.Enum;

namespace ThePlaidApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<ProxyType>))]
public sealed record ProxyType : OpenStringEnum<ProxyType>
{
    private ProxyType(string value) : base(value)
    {
    }

    public static readonly ProxyType NoneDetected = new("none_detected");

    public static readonly ProxyType Tor = new("tor");

    public static readonly ProxyType Vpn = new("vpn");

    public static readonly ProxyType WebProxy = new("web_proxy");

    public static readonly ProxyType PublicProxy = new("public_proxy");

    public TResult Match<TResult>(Func<TResult> onNoneDetected,
        Func<TResult> onTor,
        Func<TResult> onVpn,
        Func<TResult> onWebProxy,
        Func<TResult> onPublicProxy,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoneDetected => onNoneDetected(),
            _ when this == Tor => onTor(),
            _ when this == Vpn => onVpn(),
            _ when this == WebProxy => onWebProxy(),
            _ when this == PublicProxy => onPublicProxy(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoneDetected,
        Action onTor,
        Action onVpn,
        Action onWebProxy,
        Action onPublicProxy,
        Action<string> otherwise)
    {
        if (this == NoneDetected) onNoneDetected();
        else if (this == Tor) onTor();
        else if (this == Vpn) onVpn();
        else if (this == WebProxy) onWebProxy();
        else if (this == PublicProxy) onPublicProxy();
        else otherwise(Value);
    }
}
