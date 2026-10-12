namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the GetRecipient operation.
/// </summary>
public sealed record GetRecipientRequest
{
    /// <summary>
    /// Recipient Identifier. Uniquely identifies the recipient
    /// </summary>
    public required string RecipientId { get; init; }

    /// <summary>
    /// The value that is passed into the OAuth URI 'state' query parameter.
    /// </summary>
    public string? OauthStateId { get; init; }
}
