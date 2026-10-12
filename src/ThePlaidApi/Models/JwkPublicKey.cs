using System.Text.Json.Serialization;
using ThePlaidApi.Core.Models;

namespace ThePlaidApi.Models;

/// <summary>
/// A JSON Web Key (JWK) that can be used in conjunction with <see href="https://jwt.io/#libraries-io">JWT libraries</see> to verify Plaid webhooks
/// </summary>
public record JwkPublicKey
{
    /// <summary>
    /// The alg member identifies the cryptographic algorithm family used with the key.
    /// </summary>
    [JsonPropertyName("alg")]
    public required string Alg { get; init; }

    /// <summary>
    /// The crv member identifies the cryptographic curve used with the key.
    /// </summary>
    [JsonPropertyName("crv")]
    public required string Crv { get; init; }

    /// <summary>
    /// The kid (Key ID) member can be used to match a specific key. This can be used, for instance, to choose among a set of keys within the JWK during key rollover.
    /// </summary>
    [JsonPropertyName("kid")]
    public required string Kid { get; init; }

    /// <summary>
    /// The kty (key type) parameter identifies the cryptographic algorithm family used with the key, such as RSA or EC.
    /// </summary>
    [JsonPropertyName("kty")]
    public required string Kty { get; init; }

    /// <summary>
    /// The use (public key use) parameter identifies the intended use of the public key.
    /// </summary>
    [JsonPropertyName("use")]
    public required string Use { get; init; }

    /// <summary>
    /// The x member contains the x coordinate for the elliptic curve point, provided as a base64url-encoded string of the coordinate's big endian representation.
    /// </summary>
    [JsonPropertyName("x")]
    public required string X { get; init; }

    /// <summary>
    /// The y member contains the y coordinate for the elliptic curve point, provided as a base64url-encoded string of the coordinate's big endian representation.
    /// </summary>
    [JsonPropertyName("y")]
    public required string Y { get; init; }

    /// <summary>
    /// The timestamp when the key was created, in Unix time.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required int CreatedAt { get; init; }

    /// <summary>
    /// The timestamp when the key expired, in Unix time.
    /// </summary>
    [JsonPropertyName("expired_at")]
    public required int? ExpiredAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
