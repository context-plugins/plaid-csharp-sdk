namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the FdxConsentsGet operation.
/// </summary>
public sealed record FdxConsentsGetRequest
{
    /// <summary>
    /// Consent Grant Identifier. Uniquely identifies the consent grant
    /// </summary>
    public required string ConsentId { get; init; }
}
